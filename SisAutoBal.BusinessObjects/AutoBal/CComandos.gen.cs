using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisAutoBal.BusinessObjects.AutoBal
{
    public partial class CComandos
    {
        [Key] // Agrega la anotación [Key] a la propiedad Id.

        public int? Id { get; set; }
        public string? sn { get; set; }
        public string? Comando { get; set; }
        public string? Estado { get; set; }
        public CComandos()
        { }

        public CComandos(int? Id_, string? sn_, string? Comando_, string? Estado_)
        {
            Id = Id_;
            sn = sn_;
            Comando = Comando_;
            Estado = Estado_;
        }
    }
}
