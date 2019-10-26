using Sistema_De_Chamados.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_De_Chamados.Modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";

        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
        public String cadastro(String login, String senha, String repsenha, String inscricao, String celular, String email)
        { 
 
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastro(login, email, senha, celular, inscricao);
            if (loginDao.tem)
            {

                this.tem = true;
            }
            return mensagem;
        }

        public void SalvaDados()
        {

            String strConnection = "";
            String strSQL = "INSERT INTO USUARIO (login, inscricao, email, celular, senha)";
            SqlConnection dbConnection = new SqlConnection(strConnection);
            SqlCommand sql = new SqlCommand(strSQL, dbConnection);

            try
            {
                dbConnection.Open();

                sql.ExecuteNonQuery();

                MessageBox.Show("Dados salvos com sucesso");
            }

            catch (SqlException ex)
            {
                MessageBox.Show("ERRO!" + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
           
        }
            
    }

}
