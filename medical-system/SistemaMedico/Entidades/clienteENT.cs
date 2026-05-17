using SistemaMedico.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Entidades
{
    class clienteENT
    {
        private int ID_Cli;
        private string Nome;
        private string CPF;
        private string Convenio;
        private int Idade;
        private string Sexo;
        private string Endereço;
        private string Telefone;
        private string Celular;
        private string CEP;


        public int ID { get => ID_Cli; set => ID_Cli = value; }
        public string nome { get => Nome; set => Nome = value; }
        public string cpf { get => CPF; set => CPF = value; }
        public string convenio { get => Convenio; set => Convenio = value; }
        public int idade { get => Idade; set => Idade = value; }
        public string sexo { get => Sexo; set => Sexo = value; }
        public string endereco { get => Endereço; set => Endereço = value; }
        public string telefone { get => Telefone; set => Telefone = value; }
        public string celular { get => Celular; set => Celular = value; }
        public string cep { get => CEP; set => CEP = value; }

        internal static int Alterar(clienteENT objtabela)
        {
            return new clienteDAO().Alterar(objtabela);
        }
    }
}
