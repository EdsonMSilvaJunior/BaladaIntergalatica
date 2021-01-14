using System.Collections.Generic;

namespace Balada.Infrastructure.IoC.Models.Estabelecimentos
{
    public class EstabelecimentoUpdateModel : EstabelecimentoBaseModel
    {
        public IList<string> BannedList { get; set; }
    }
}
