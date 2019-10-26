using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_De_Chamados.Modelo;

namespace Sistema_De_Chamados.DAL
{
   class ChamadoDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        internal bool salvo;
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        int numeroChamado;

        public string ordemservico(string titulo, string produto, string contato, string descricao, string usuario)
        {
            DateTime dataCadastro = DateTime.Now;
            //comandos para verificar se tem no bancop
            cmd.CommandText = "insert into Chamado (titulo, produto, contato, Descricao, dataCriacao,UsuarioChamado,StatusChamado, Prioridade) values(@t,@p,@c,@d,@dtc,@u,'ABERTO', 'MEDIO')";
            cmd.Parameters.AddWithValue("@t", titulo);
            cmd.Parameters.AddWithValue("@p", produto);
            cmd.Parameters.AddWithValue("@c", contato);
            cmd.Parameters.AddWithValue("@d", descricao);   
            cmd.Parameters.AddWithValue("@dtc", dataCadastro);
            cmd.Parameters.AddWithValue("@u", usuario);

            try
            {
                cmd.Connection = con.conectar();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.CommandText = "Select IdChamado From Chamado Where COnvert(varchar, DataCriacao,120) = '" + dataCadastro.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                    numeroChamado = (int)cmd.ExecuteScalar();
                }
                con.desconectar();
                this.mensagem = "Chamado Criado com Sucesso!\nNúmero do Chamado: " + numeroChamado.ToString();
                tem = true;
            }
            catch (Exception ex)
            {
                this.mensagem = "Erro de banco de dados";
            }

            return this.mensagem;
        }

        public DataTable ConsultarChamado(int idChamado)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataReader dr;
            Conexao con = new Conexao();
            DataTable dt = new DataTable();
            if(idChamado > 0)
            {
                cmd.CommandText = "select * from CHamado Where idChamado = " + idChamado.ToString() + " Order by DataCriacao";
            }
            else
            {
                cmd.CommandText = "select * from CHamado Where  UsuarioChamado = '" + Cadastro.Login + "' Order by DataCriacao";
            }

            
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

        public DataTable ConsultaChamadosSuporte()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from CHamado Order by DataCriacao";
      
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

        public bool AlteraChamado(string StatusChamado, string prioridade, string solucao, DateTime dataAlteracao, int idChamado, string tecnico)
        {
            DateTime dataCadastro = DateTime.Now;
            //comandos para verificar se tem no bancop
            cmd.CommandText = "Update Chamado set StatusChamado = @sc, Prioridade = @p, Solucao = @s, DataAlteracao = @da, Tecnico = @tec where IdChamado = @id";
            cmd.Parameters.AddWithValue("@sc", StatusChamado);
            cmd.Parameters.AddWithValue("@p", prioridade);
            cmd.Parameters.AddWithValue("@s", solucao);
            cmd.Parameters.AddWithValue("@da", dataAlteracao);
            cmd.Parameters.AddWithValue("@id", idChamado);
            cmd.Parameters.AddWithValue("@tec", tecnico);
   

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

        public DataTable GeraRelatorio()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "Select Count(StatusChamado) [Qtd Chamados], StatusChamado, c.Tecnico " +
                               " From Chamado As C " +
                               "Join Usuario As U ON C.Tecnico = Login " +
                               " WHere U.TipoUsuario = 1 " +
                               " Group BY StatusChamado, c.Tecnico ";

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
