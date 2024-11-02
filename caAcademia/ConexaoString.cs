using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaTrabalhoFinal
{
    internal class ConexaoString
    {
        string serverName = "localhost"; // localhost 
        string port = "5432"; // porta default
        string userName = "postgres"; // nome do administrador
        string password = "1234"; // Senha do SGDB
        string dataBaseName = "BDAcademia"; // Nome do Banco de Dados

        public string ConnString()
        {
            string connString = "Server =" + serverName + ";Port = " + port + ";Username = " + userName + ";Password=" + password +
                 ";Database=" + dataBaseName + ";";

            return connString;
        }
    }
}
