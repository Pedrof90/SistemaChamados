using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Chamados.DAL
{
    class PessoaDaoComandos
    {
        public bool SalvarDados(String login, String email, String senha, String celular, String inscricao, int tipoUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            cmd.CommandText = "update Usuario set Inscricao = @i, Email = @e, Celular = @c , Senha = @s, TipoUsuario = @tp where login = @l";
            cmd.Parameters.AddWithValue("@l", login);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@s", senha);
            cmd.Parameters.AddWithValue("@c", celular);
            cmd.Parameters.AddWithValue("@i", inscricao);
            cmd.Parameters.AddWithValue("@tp", tipoUsuario);

            try
            {
                cmd.Connection = con.conectar();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    con.desconectar();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public DataTable consultaUsuarios()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataReader dr;
            Conexao con = new Conexao();
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from Usuario";
            try
            {
                cmd.Connection = con.conectar();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                con.desconectar();

            }
            catch (SqlException)
            {

            }

            return dt;
        }
        
        public DataTable ConsultaTecnico()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataReader dr;
            Conexao con = new Conexao();
            DataTable dt = new DataTable();

            cmd.CommandText = "select Login from Usuario Where TipoUsuario = 1";
            try
            {
                cmd.Connection = con.conectar();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                con.desconectar();

            }
            catch (SqlException)
            {

            }

            return dt;
        }
    }
}
