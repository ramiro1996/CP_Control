using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Control.CP_Control
{
   abstract  class ManejadorBaseDatos
    {
        public abstract System.Data.DataSet ConsultarTablaBD(string consulta);
        public abstract object ConsultaEscalarBD(string consulta);
        public abstract void InsertaModificaBD(string consulta);
        public abstract int InsertaRegC(string consulta);
    }
}
