using System.Collections.Generic;

namespace Balada.Infrastructure.IoC.Models.Estabelecimentos
{
    public class EstabelecimentoRequestModel : EstabelecimentoBaseModel
    {
        public IList<string> RestrictedObjects { get;  set; }
    }
}
