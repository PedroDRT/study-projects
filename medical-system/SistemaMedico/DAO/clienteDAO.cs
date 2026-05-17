using SistemaMedico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaMedico.DAO
{
    class clienteDAO
    {
        internal int Inserir(clienteENT objtabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();




                cn.CommandText = "INSERT INTO cadcli ([Nome],[CPF],[Convenio],[Idade],[Sexo],[Endereço],[Telefone],[Celular],[CEP]) VALUES (@Nome, @CPF, @Convenio, @Idade, @Sexo, @Endereço, @Telefone, @Celular, @CEP)";
                cn.Parameters.Add("Nome", SqlDbType.VarChar).Value = objtabela.nome;
                cn.Parameters.Add("CPF", SqlDbType.VarChar).Value = objtabela.cpf;
                cn.Parameters.Add("Convenio", SqlDbType.VarChar).Value = objtabela.convenio;
                cn.Parameters.Add("Idade", SqlDbType.Int).Value = objtabela.idade;
                cn.Parameters.Add("Sexo", SqlDbType.VarChar).Value = objtabela.sexo;
                cn.Parameters.Add("Endereço", SqlDbType.VarChar).Value = objtabela.endereco;
                cn.Parameters.Add("Telefone", SqlDbType.VarChar).Value = objtabela.telefone;
                cn.Parameters.Add("Celular", SqlDbType.VarChar).Value = objtabela.celular;
                cn.Parameters.Add("CEP", SqlDbType.VarChar).Value = objtabela.cep;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

            }

            }

        internal int Deletar(clienteENT objtabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM cadcli WHERE ID_Cli=@ID_Cli";
                cn.Parameters.Add("ID_ClI", SqlDbType.Int).Value = objtabela.ID;
                cn.Parameters.Add("Nome", SqlDbType.VarChar).Value = objtabela.nome;
                cn.Parameters.Add("CPF", SqlDbType.VarChar).Value = objtabela.cpf;
                cn.Parameters.Add("Convenio", SqlDbType.VarChar).Value = objtabela.convenio;
                cn.Parameters.Add("Idade", SqlDbType.Int).Value = objtabela.idade;
                cn.Parameters.Add("Sexo", SqlDbType.VarChar).Value = objtabela.sexo;
                cn.Parameters.Add("Endereço", SqlDbType.VarChar).Value = objtabela.endereco;
                cn.Parameters.Add("Telefone", SqlDbType.VarChar).Value = objtabela.telefone;
                cn.Parameters.Add("Celular", SqlDbType.VarChar).Value = objtabela.celular;
                cn.Parameters.Add("CEP", SqlDbType.VarChar).Value = objtabela.cep;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

            }
        }

        internal int Alterar(clienteENT objtabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();

                //con conversa/instansia com bd cn estancia/recebendo a função da sqlcommand

                cn.CommandText = "UPDATE cadcli SET Nome=@Nome, CPF=@CPF, Convenio=@Convenio, Idade=@Idade, Sexo=@Sexo, Endereço=@Endereço, Telefone=@Telefone, Celular=@Celular, CEP=@CEP WHERE ID_Cli=@ID_Cli";
                cn.Parameters.Add("ID_ClI", SqlDbType.Int).Value = objtabela.ID;
                cn.Parameters.Add("Nome", SqlDbType.VarChar).Value = objtabela.nome;
                cn.Parameters.Add("CPF", SqlDbType.VarChar).Value = objtabela.cpf;
                cn.Parameters.Add("Convenio", SqlDbType.VarChar).Value = objtabela.convenio;
                cn.Parameters.Add("Idade", SqlDbType.Int).Value = objtabela.idade;
                cn.Parameters.Add("Sexo", SqlDbType.VarChar).Value = objtabela.sexo;
                cn.Parameters.Add("Endereço", SqlDbType.VarChar).Value = objtabela.endereco;
                cn.Parameters.Add("Telefone", SqlDbType.VarChar).Value = objtabela.telefone;
                cn.Parameters.Add("Celular", SqlDbType.VarChar).Value = objtabela.celular;
                cn.Parameters.Add("CEP", SqlDbType.VarChar).Value = objtabela.cep;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

                //vai retornar de quem chamou!



            }
        }

        internal List<clienteENT> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM cadcli";
                cn.Connection = con;
                SqlDataReader dr;
                List<clienteENT> lista = new List<clienteENT>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        clienteENT dado = new clienteENT();
                        dado.ID = Convert.ToInt32(dr["ID_Cli"]);
                        dado.nome = Convert.ToString(dr["Nome"]);
                        dado.cpf = Convert.ToString(dr["CPF"]);
                        dado.convenio = Convert.ToString(dr["Convenio"]);
                        dado.idade = Convert.ToInt32(dr["Idade"]);
                        dado.sexo = Convert.ToString(dr["Sexo"]);
                        dado.endereco = Convert.ToString(dr["Endereço"]);
                        dado.telefone = Convert.ToString(dr["Telefone"]);
                        dado.celular = Convert.ToString(dr["Celular"]);
                        dado.cep = Convert.ToString(dr["CEP"]);

                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }
    }
}
