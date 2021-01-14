using Balada.Domain.Entities;
using Balada.Domain.Interfaces;
using Balada.Infrastructure.IoC.Interfaces;
using Balada.Infrastructure.IoC.Models.Check;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Balada.Infrastructure.IoC.Service
{
    public class CheckService : ICheckService
    {
        private ICheckRepository _checkRepository;
        private IEstabelecimentoRepository _estabelecimentoRepository;
        private IAlienRepository _alienRepository;

        public CheckService(ICheckRepository checkRepository, IAlienRepository alienRepository, IEstabelecimentoRepository estabelecimentoRepository)
        {
            _checkRepository = checkRepository;
            _alienRepository = alienRepository;
            _estabelecimentoRepository = estabelecimentoRepository;

        }

        public async Task CreateAsync(CheckRequestModel entity)
        {
            var alien = await _alienRepository.GetByIdAsync(entity.AlienID);
            var estabelecimento = await _estabelecimentoRepository.GetByIdAsync(entity.EstabalecimentoId);
            var check = new Check(DateTime.Now, alien, estabelecimento);
            var checkDb = await _checkRepository.GetCheckByUserId(entity.AlienID);

            if (estabelecimento.BannedList.Contains(checkDb.AlienId))
            {
                throw new Exception("Alien banido.");
            }
            if (checkDb != null && checkDb.CheckOut == null)
            {
                estabelecimento.BannedList.Add(alien.Id);
                await _estabelecimentoRepository.UpdateAsync(estabelecimento);
                throw new Exception("Alien banido.");
            }
            if ((DateTime.Now.Year - alien.DateBirth.Year) < 250)
            {
                throw new Exception("Alien menor de idade.");
            }
            foreach (var objectAlien in alien.Objects)
            {
                if (estabelecimento.RestrictedObjects.Contains(objectAlien))
                {
                    throw new Exception("Objeto não permitido.");
                }
            }
            await _checkRepository.CreateAsync(check);
        }

        public Task DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<CheckResponseModel>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<CheckResponseModel> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task UpdateAsync(int id, CheckUpdateModel entity)
        {
            var alien = await _alienRepository.GetByIdAsync(entity.AlienID);
            var estabelecimento = await _estabelecimentoRepository.GetByIdAsync(entity.EstabalecimentoId);
            var check = new Check(DateTime.Now, alien, estabelecimento);
            var checkDb = await _checkRepository.GetCheckByUserId(entity.AlienID);

            if ((DateTime.Now.Minute - check.CheckIn.Minute) < 1)
            {
                throw new Exception("Tempo de checkIn menor que 1 minuto."); ;
            }
            check.Update(DateTime.Now);
            await _checkRepository.UpdateAsync(check);
        }
    }
}
