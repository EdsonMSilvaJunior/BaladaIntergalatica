using System;
using System.Collections.Generic;

namespace Balada.Domain.Entities
{
    public class Alien : BaseEntity
    {
        public string Name { get; protected set; }
        public DateTime DateBirth { get; protected set; }
        public IList<string> Objects { get; protected set; }

        public Alien(string name, DateTime datebirth)
        {
            Name = name;
            DateBirth = datebirth;
        }
        public void AddObjtects(string nameobject)
        {
            Objects.Add(nameobject);
        }

        public void Update(string name, DateTime dateBirth)
        {
            Name = name;
            DateBirth = dateBirth;
        }

        protected Alien()
        {
            Objects = new List<string>();
        }
    }
}
