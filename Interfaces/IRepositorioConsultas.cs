using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Control.CP_Control.IRepositorios
{
    internal interface IRepositorioConsultas
    {
        DataSet ConsultarTablaBD();
        object ConsultaEscalarBD();
        void InsertaModificaBD();
        int InsertaRegC();
    }
}
