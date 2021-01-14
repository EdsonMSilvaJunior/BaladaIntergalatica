using AutoMapper;
using Balada.Domain.Entities;
using Balada.Domain.Interfaces;
using Balada.Domain.Validators;
using Balada.Infrastructure.IoC.Interfaces;
using Balada.Infrastructure.IoC.Models.Estabelecimentos;
using FluentValidation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Balada.Infrastructure.IoC.Service
{
    public class EstabelecimentoService : IEstabelecimentoService
    {
        private IEstabelecimentoRepository _estabelecimentoRepository;
        public EstabelecimentoService(IEstabelecimentoRepository estabelecimentoRepository)
        {
            _estabelecimentoRepository = estabelecimentoRepository;
        }

        public async Task<int> CreateAsync(EstabelecimentoRequestModel estabelecimentoRequestModel)
        {
            var configuration = new MapperConfiguration(x =>
            {
                x.CreateMap<EstabelecimentoRequestModel, Estabelecimento>();
            });
            var mapper = configuration.CreateMapper();
            var estabelecimento = mapper.Map<Estabelecimento>(estabelecimentoRequestModel);
            var validator = new EstabelecimentoValidator();
            validator.ValidateAndThrow(estabelecimento);
            foreach (var restrictObject in estabelecimentoRequestModel.RestrictedObjects)
            {
                estabelecimento.AddRestrictedObjects(restrictObject);
            }
            await _estabelecimentoRepository.CreateAsync(estabelecimento);

            return estabelecimento.Id;
        }

        public async Task DeleteAsync(int id)
        {
            await _estabelecimentoRepository.DeleteAsync(id);
        }

        public async Task<List<EstabelecimentoResponseModel>> GetAllAsync()
        {
            var estabelecimentos = await _estabelecimentoRepository.GetAllAsync();
            var configuration = new MapperConfiguration(x =>
            {
                x.CreateMap<Estabelecimento, EstabelecimentoResponseModel>();
            });
            var mapper = configuration.CreateMapper();
            var estabelecimentoResponseModel = new List<EstabelecimentoResponseModel>();
            for (int i = 0; i < estabelecimentos.Count; i++)
            {
                estabelecimentoResponseModel.Add(mapper.Map<EstabelecimentoResponseModel>(estabelecimentos[i]));
            }
            return estabelecimentoResponseModel;
        }

        public async Task<EstabelecimentoResponseModel> GetByIdAsync(int id)
        {
            var estabelecimento = await _estabelecimentoRepository.GetByIdAsync(id);
            var configuration = new MapperConfiguration(x =>
            {
                x.CreateMap<Estabelecimento, EstabelecimentoResponseModel>();
            });
            var mapper = configuration.CreateMapper();
            return mapper.Map<EstabelecimentoResponseModel>(estabelecimento);
        }

        public async Task UpdateAsync(int id, EstabelecimentoUpdateModel estabelecimentoUpdateModel)
        {
            var estabelecimento = await _estabelecimentoRepository.GetByIdAsync(id);
            estabelecimento.Update(estabelecimentoUpdateModel.Name);
            await _estabelecimentoRepository.UpdateAsync(estabelecimento);

        }
    }
}
