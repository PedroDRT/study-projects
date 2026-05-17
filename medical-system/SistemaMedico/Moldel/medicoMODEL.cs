using SistemaMedico.DAO;
using SistemaMedico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Moldel
{
    class medicoMODEL
    {
        internal static int Inserir(medicoENT objtabela)
        {
            return new medicoDAO().Inserir(objtabela);
        }

        internal List<medicoENT> Lista()
        {
            return new medicoDAO().Lista();
        }

        internal static int Deletar(medicoENT objtabela)
        {
            return new medicoDAO().Deletar(objtabela);
        }
    }
}
