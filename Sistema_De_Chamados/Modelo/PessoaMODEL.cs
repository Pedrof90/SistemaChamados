using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Chamados.Modelo
{
    public class Cadastro
    {
        public static string Login { get; set; }

        public static string Inscricao { get; set; }

        public static string Email { get; set; }

        public static string Celular { get; set; }

        public static string Senha { get; set; }
    }

    public class AlteraCadastroMODEL
    {
        public static string Login { get; set; }

        public static int Inscricao { get; set; }

        public static string Email { get; set; }

        public static int Celular { get; set; }

        public static int Senha { get; set; }
    }

    public class ConsultaPessoaMODEL
    {
        public static string Login { get; set; }

        public static string Inscricao { get; set; }

        public static string Email { get; set; }

        public static string Senha { get; set; }

        public static string Celular { get; set; }


    }
}