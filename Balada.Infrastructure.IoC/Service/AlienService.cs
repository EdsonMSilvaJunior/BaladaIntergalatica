using AutoMapper;
using Balada.Domain.Entities;
using Balada.Domain.Interfaces;
using Balada.Domain.Validators;
using Balada.Infrastructure.IoC.Interfaces;
using Balada.Infrastructure.IoC.Models.Aliens;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balada.Infrastructure.IoC.Service
{
    public class AlienService : IAlienService
    {
        private IAlienRepository _alienRepository;
        public AlienService(IAlienRepository alienRepository)
        {
            _alienRepository = alienRepository;
        }
        

        public async Task<int> CreateAsync(AlienRequestModel entity)
        {
            var configuration = new MapperConfiguration(x =>
            {
                x.CreateMap<AlienRequestModel, Alien>();
            });
            var mapper = configuration.CreateMapper();
            var alien = mapper.Map<Alien>(entity);
            var validator = new AlienValidator();
            validator.ValidateAndThrow(alien);
            await _alienRepository.CreateAsync(alien);
            return alien.Id;
        }

        public async Task DeleteAsync(int id)
        {
            await _alienRepository.DeleteAsync(id);
        }

        public async Task<List<AlienResponseModel>> GetAllAsync()
        {
            var aliens = await _alienRepository.GetAllAsync();
            var configuration = new MapperConfiguration(x =>
            {
                x.CreateMap<Alien, AlienResponseModel>();
            });
            var mapper = configuration.CreateMapper();
            var aliensResponseModel = new List<AlienResponseModel>();
            for (int i = 0; i < aliens.Count; i++)
            {
                aliensResponseModel.Add(mapper.Map<AlienResponseModel>(aliens[i]));
            }
            return aliensResponseModel;
        }

        public async Task<AlienResponseModel> GetByIdAsync(int id)
        {
            var alien = await _alienRepository.GetByIdAsync(id);
            var configuration = new MapperConfiguration(x =>
            {
                x.CreateMap<Alien, AlienResponseModel>();
            });
            var mapper = configuration.CreateMapper();
            return mapper.Map<AlienResponseModel>(alien);
        }

        public async Task UpdateAsync(int id, AlienUpdateModel entity)
        {
            var alien = await _alienRepository.GetByIdAsync(id);
            alien.Update(entity.Name, entity.DateBirth);
            await _alienRepository.UpdateAsync(alien);
        }
    }
}
