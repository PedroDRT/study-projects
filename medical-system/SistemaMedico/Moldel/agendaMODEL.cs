using SistemaMedico.DAO;
using SistemaMedico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Moldel
{
    class agendaMODEL
    {
        internal static int Inserir(agendaENT objtabela)
        {
            return new agendaDAO().Inserir(objtabela);
        }

        internal List<agendaENT> Lista()
        {
            return new agendaDAO().Lista();
        }

        internal static int Deletar(agendaENT objtabela)
        {
            return new agendaDAO().Deletar(objtabela);
        }
    }
}
