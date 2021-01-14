using System.Collections.Generic;

namespace Balada.Web.Mvc.Models.Insert
{
    public class EstabelecimentoInsertViewModel
    {
        public string Name { get; set; }
        public IList<string> RestrictedObjects { get; set; }
        public IList<string> BannedList { get; set; }
    }
}
