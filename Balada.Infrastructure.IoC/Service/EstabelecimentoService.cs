using AutoMapper;
using Balada.Domain.Entities;
using Balada.Domain.Interfaces;
using Balada.Infrastructure.IoC.Interfaces;
using Balada.Infrastructure.IoC.Models.Estabelecimentos;
using System;
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

        public Task<int> CreateAsync(Estabelecimento entity)
        {
            var configuration = new MapperConfiguration(x =>
            {
                x.CreateMap<EstabelecimentoRequestModel, Estabelecimento>();
            });
            var mapper = configuration.CreateMapper();
            var alien = mapper.Map<Estabelecimento>(entity);
            var validator = new AlienValidator();
            validator.ValidateAndThrow(alien);
            await _alienRepository.CreateAsync(alien);
            return alien.Id;
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Domain.Entities.Estabelecimento>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.Estabelecimento> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Domain.Entities.Estabelecimento entity)
        {
            throw new NotImplementedException();
        }
    }
}
