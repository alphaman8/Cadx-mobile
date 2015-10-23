using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Cadx
{
    class Usuario
    {
        private static bool logado = false;
        private static string mysqlUser;
        private static string mysqlSenha;
        private static string idDevice;

        public static bool Logado
        {
            get { return logado; }
            set { logado = value; }
        }        

        public static string MysqlUser
        {
            get { return Usuario.mysqlUser; }
            set { Usuario.mysqlUser = value; }
        }        

        public static string MysqlSenha
        {
            get { return Usuario.mysqlSenha; }
            set { Usuario.mysqlSenha = value; }
        }
        
        public static string IdDevice
        {
            get { return Usuario.idDevice; }
            set { Usuario.idDevice = value; }
        }
    }
}
