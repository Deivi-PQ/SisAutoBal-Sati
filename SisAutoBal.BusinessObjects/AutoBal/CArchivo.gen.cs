using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisAutoBal.BusinessObjects.AutoBal
{
    public partial class CArchivo
    {
        public string ContentType { get; set; }
        public string ContentAsBase64String { get; set; }
        public string FileName { get; set; }
        public CArchivo() { }
        public CArchivo(string ContentType_, String ContentAsBase64String_, String FileNamwe_)
        {
            ContentType = ContentType_;
            ContentAsBase64String = ContentAsBase64String_;
            FileName = FileNamwe_;

        }
    }
}
