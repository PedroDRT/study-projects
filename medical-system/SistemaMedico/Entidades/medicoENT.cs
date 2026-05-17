using SistemaMedico.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Entidades
{
    class medicoENT
    {
        private int ID_Med;
        private string Nome;
        private int Idade;
        private string CRM;
        private string CPF;
        private string Especialidade;

        public int id { get => ID_Med; set => ID_Med = value; }
        public string nome { get => Nome; set => Nome = value; }
        public int idade { get => Idade; set => Idade = value; }
        public string crm { get => CRM; set => CRM = value; }
        public string cpf { get => CPF; set => CPF = value; }
        public string especialidade { get => Especialidade; set => Especialidade = value; }

        internal static int Alterar(medicoENT objtabela)
        {
            return new medicoDAO().Alterar(objtabela);
        }
    }
}
