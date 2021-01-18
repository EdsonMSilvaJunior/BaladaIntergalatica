using System;

namespace Balada.Domain.Entities
{
    public class Check : BaseEntity
    {
        public DateTime CheckIn { get; protected set; }
        public DateTime CheckOut { get; protected set; }
        public int AlienId { get; protected set; }
        public virtual Alien Alien { get; protected set; }
        public int EstabelecimentoId { get; protected set; }
        public virtual Estabelecimento Estabelecimento { get; protected set; }

        public Check(DateTime checkin, Alien alien, Estabelecimento estabelecimento)
        {
            CheckIn = checkin;
            Alien = alien;
            Estabelecimento = estabelecimento;
        }

        public void Update(DateTime checkOut)
        {
            CheckOut = checkOut;
        }
    }
}
