using System.Collections.Generic;

namespace Balada.Domain.Entities
{
    public class Estabelecimento : BaseEntity
    {
        public string Name { get; protected set; }
        public IList<string> RestrictedObjects { get; protected set; }
        public IList<string> BannedList { get; protected set; }

        public Estabelecimento(string name)
        {
            Name = name;
        }

        public void AddRestrictedObjects(string nameRestrictedObjects)
        {
            RestrictedObjects.Add(nameRestrictedObjects);
        }

        protected Estabelecimento()
        {
            RestrictedObjects = new List<string>();
            BannedList = new List<string>();
        }
    }
}
