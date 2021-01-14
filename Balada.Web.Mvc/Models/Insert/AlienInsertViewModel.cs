using System;
using System.ComponentModel;

namespace Balada.Web.Mvc.Models.Insert
{
    public class AlienInsertViewModel
    {
        [DisplayName]
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Objeto { get; set; }
    }
}
