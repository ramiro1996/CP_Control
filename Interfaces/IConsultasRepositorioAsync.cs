using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Control.CP_Control.IRepositorios
{
    internal interface IConsultasRepositorioAsync
    {
        DataSet ConsultarTablaBD(string consulta);
        object ConsultaEscalarBD(string consulta);
        void InsertaModificaBD(string consulta);
        int InsertaRegC(string consulta);
    }
}
