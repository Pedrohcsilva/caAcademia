using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAcademia
{
    internal class Plano
    {
        private string nome;
        private double valor;
        private string data;

        public Plano(string _nome, double _valor, string _data)
        {
            nome = _nome;
            valor = _valor;
            data = _data;
        }
        public double valorapagar()
        {
            return valor;
        }
        

        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Data { get => data; set => data = value; }
    }
}
