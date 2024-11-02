using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAcademia
{
    internal class cadastrar
    {
        private string nome;
        private string professor;
        private string plano;
        private double valor;

        public cadastrar(string _nome, string _professor, string _plano, double _valor)
        {
            nome = _nome;
            professor = _professor;
            plano = _plano;
            valor = _valor;
        }



        public string Nome { get => nome; set => nome = value; }
        public string Professor { get => professor; set => professor = value; }
        public string Plano { get => plano; set => plano = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}
