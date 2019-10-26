using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_De_Chamados.Modelo;

namespace Sistema_De_Chamados.DAL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha)
        {
            //comandos para verificar se tem no bancop
            cmd.CommandText = "select * from Usuario where Login = @login and Senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {

                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    tem = true;
                }
                while (dr.Read())
                {
                    Cadastro.Login = dr[0].ToString();
                    Cadastro.Senha = dr[4].ToString();
                    Cadastro.Inscricao = dr[1].ToString();
                    Cadastro.Email = dr[2].ToString();
                    Cadastro.Celular = dr[3].ToString();
                }
                con.desconectar();
                dr.Close();
            }
            catch(SqlException)
            {

                this.mensagem = "Erro com banco de dados!";
            }
            return tem;
        }

        public string cadastro(String login, String email, String senha, String celular, String inscricao)
        {

            
                cmd.CommandText = "insert into Usuario (Login,Inscricao,Email,Celular,Senha,TipoUsuario) values (@l,@i,@e,@c,@s,2);";
                cmd.Parameters.AddWithValue("@l", login);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);
                cmd.Parameters.AddWithValue("@c", celular);
                cmd.Parameters.AddWithValue("@i", inscricao);

            try
                {
                    cmd.Connection = con.conectar();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        con.desconectar();
                        this.mensagem = "Cadastrado com sucesso";
                        tem = true;
                    }
                }
                catch(Exception ex)
                {
                    this.mensagem = "Erro de banco de dados | Erro: " + ex.Message;
                }

          
            //comandos para inserir
            return mensagem;
        }

        public bool VerificaADM(string login, string senha)
        {
            cmd.CommandText = "select * from Usuario where Login = @login and Senha = @senha And TipoUsuario = 3";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {

                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool VerificaSuporte(string login, string senha)
        {
            cmd.CommandText = "select * from Usuario where Login = @login and Senha = @senha And TipoUsuario = 1";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {

                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }


    }
}

