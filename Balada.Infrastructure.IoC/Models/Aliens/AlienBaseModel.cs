using System;
using System.Collections.Generic;

namespace Balada.Infrastructure.IoC.Models.Aliens
{
    public class AlienBaseModel : AlienUpdateModel
    {
        public IList<string> Objects { get; protected set; }
    }
}
