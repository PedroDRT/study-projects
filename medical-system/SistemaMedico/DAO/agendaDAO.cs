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
    class agendaDAO
    {
        internal int Inserir(agendaENT objtabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();




                cn.CommandText = "INSERT INTO agendacli ([ID_Cli],[Medico],[Especialidade],[Data],[Horario]) VALUES (@ID_Cli, @Medico, @Especialidade, @Data, @Horario)";
                cn.Parameters.Add("ID_Cli", SqlDbType.Int).Value = objtabela.ID2;
                cn.Parameters.Add("Medico", SqlDbType.VarChar).Value = objtabela.medico;
                cn.Parameters.Add("Especialidade", SqlDbType.VarChar).Value = objtabela.especialidade;
                cn.Parameters.Add("Data", SqlDbType.Date).Value = objtabela.data;
                cn.Parameters.Add("Horario", SqlDbType.VarChar).Value = objtabela.horario;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

            }
        }

        internal int Deletar(agendaENT objtabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM agendacli WHERE ID_agenda=@ID_agenda";
                cn.Parameters.Add("ID_agenda", SqlDbType.Int).Value = objtabela.ID;
                cn.Parameters.Add("Medico", SqlDbType.VarChar).Value = objtabela.medico;
                cn.Parameters.Add("Especialidade", SqlDbType.VarChar).Value = objtabela.especialidade;
                cn.Parameters.Add("Data", SqlDbType.DateTime).Value = objtabela.data;
                cn.Parameters.Add("Horario", SqlDbType.Int).Value = objtabela.horario;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

            }
        }

        internal int Alterar(agendaENT objtabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();

                //con conversa/instansia com bd cn estancia/recebendo a função da sqlcommand

                cn.CommandText = "UPDATE agendacli SET Medico=@Medico, Especialidade=@Especialidade, Data=@Data, Horario=@Horario WHERE ID_agenda=@ID_agenda";
                cn.Parameters.Add("ID_agenda", SqlDbType.Int).Value = objtabela.ID;
                cn.Parameters.Add("ID_Cli", SqlDbType.Int).Value = objtabela.ID2;
                cn.Parameters.Add("Medico", SqlDbType.VarChar).Value = objtabela.medico;
                cn.Parameters.Add("Especialidade", SqlDbType.VarChar).Value = objtabela.especialidade;
                cn.Parameters.Add("Data", SqlDbType.DateTime).Value = objtabela.data;
                cn.Parameters.Add("Horario", SqlDbType.Int).Value = objtabela.horario;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

                //vai retornar de quem chamou!



            }
        }

        internal List<agendaENT> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM agendacli";
                cn.Connection = con;
                SqlDataReader dr;
                List<agendaENT> lista = new List<agendaENT>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        agendaENT dado = new agendaENT();
                        dado.ID = Convert.ToInt32(dr["ID_agenda"]);
                        dado.ID2 = Convert.ToInt32(dr["ID_Cli"]);
                        dado.medico = Convert.ToString(dr["Medico"]);
                        dado.especialidade = Convert.ToString(dr["Especialidade"]);
                        dado.data = Convert.ToDateTime(dr["Data"]);
                        dado.horario = Convert.ToString(dr["Horario"]);

                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }
    }
}
