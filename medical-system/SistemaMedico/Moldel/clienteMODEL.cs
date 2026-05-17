using SistemaMedico.DAO;
using SistemaMedico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Moldel
{
    class clienteMODEL
    {
        internal static int Inserir(clienteENT objtabela)
        {
            return new clienteDAO().Inserir(objtabela);
        }

        internal List<clienteENT> Lista()
        {
            return new clienteDAO().Lista();
        }

        internal static int Deletar(clienteENT objtabela)
        {
            return new clienteDAO().Deletar(objtabela);
        }
    }
}
