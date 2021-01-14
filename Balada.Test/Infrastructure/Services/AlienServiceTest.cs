using Balada.Domain.Entities;
using Balada.Domain.Interfaces;
using Balada.Infrastructure.IoC.Models.Aliens;
using Balada.Infrastructure.IoC.Service;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Balada.Test.Infrastructure.Services
{
    public class AlienServiceTest
    {
        private IAlienRepository _alienRepository;
        private AlienService _alienService;

        public AlienServiceTest()
        {
            _alienRepository = Substitute.For<IAlienRepository>();
            _alienService = new AlienService(_alienRepository);
        }
        
        [Fact]
        public async Task CreateAsync()
        {
            //Arrang
            IList<string> objects = new string[] {"batata","lata","mouse"};

            var alien = new AlienRequestModel
            {
                Name = "Joao",
                DateBirth = DateTime.MinValue,
                Objects = objects
            }; 
            //act
            await _alienService.CreateAsync(alien);
            //assert
            await _alienRepository.Received(1).CreateAsync(Arg.Is<Alien>(x =>
                x.Name == alien.Name &&
                x.DateBirth == alien.DateBirth &&
                x.Objects == alien.Objects
            ));
        }
    }
}
