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
    class medicoDAO
    {
        internal int Inserir(medicoENT objtabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();

                cn.CommandText = "INSERT INTO Medico ([Nome],[Idade],[CRM],[CPF],[Especialidade])VALUES (@Nome, @Idade, @CRM, @CPF, @Especialidade)";
                cn.Parameters.Add("Nome", SqlDbType.VarChar).Value = objtabela.nome;
                cn.Parameters.Add("Idade", SqlDbType.Int).Value = objtabela.idade;
                cn.Parameters.Add("CRM", SqlDbType.VarChar).Value = objtabela.crm;
                cn.Parameters.Add("CPF", SqlDbType.VarChar).Value = objtabela.cpf;
                cn.Parameters.Add("Especialidade", SqlDbType.VarChar).Value = objtabela.especialidade;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

            }
        }

        internal int Deletar(medicoENT objtabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();

                cn.CommandText = "DELETE FROM Medico WHERE ID_Med=@ID_Med";
                cn.Parameters.Add("ID_Med", SqlDbType.Int).Value = objtabela.id;
                cn.Parameters.Add("Nome", SqlDbType.VarChar).Value = objtabela.nome;
                cn.Parameters.Add("Idade", SqlDbType.Int).Value = objtabela.idade;
                cn.Parameters.Add("CRM", SqlDbType.VarChar).Value = objtabela.crm;
                cn.Parameters.Add("CPF", SqlDbType.VarChar).Value = objtabela.cpf;
                cn.Parameters.Add("Especialidade", SqlDbType.VarChar).Value = objtabela.especialidade;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

            }
        }

        internal int Alterar(medicoENT objtabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();

                cn.CommandText = "UPDATE Medico SET Nome=@Nome, Idade=@Idade, CRM=@CRM, CPF=@CPF, Especialidade=@Especialidade WHERE ID_Med=@ID_Med";
                cn.Parameters.Add("ID_Med", SqlDbType.Int).Value = objtabela.id;
                cn.Parameters.Add("Nome", SqlDbType.VarChar).Value = objtabela.nome;
                cn.Parameters.Add("Idade", SqlDbType.Int).Value = objtabela.idade;
                cn.Parameters.Add("CRM", SqlDbType.VarChar).Value = objtabela.crm;
                cn.Parameters.Add("CPF", SqlDbType.VarChar).Value = objtabela.cpf;
                cn.Parameters.Add("Especialidade", SqlDbType.VarChar).Value = objtabela.especialidade;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

            }
        }

        internal List<medicoENT> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();


                cn.CommandText = "SELECT * FROM Medico";
                cn.Connection = con;
                SqlDataReader dr;
                List<medicoENT> lista = new List<medicoENT>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        medicoENT dado = new medicoENT();
                        dado.id = Convert.ToInt32(dr["ID_Med"]);
                        dado.nome = Convert.ToString(dr["Nome"]);
                        dado.idade = Convert.ToInt32(dr["Idade"]);
                        dado.crm = Convert.ToString(dr["CRM"]);
                        dado.cpf = Convert.ToString(dr["CPF"]);
                        dado.especialidade = Convert.ToString(dr["Especialidade"]);
                        lista.Add(dado);

                    }
                }
                return lista;
            }
        }
    }
}
