using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAcademia
{
    internal class Professor
    {
        private string nome;
        private string telefone;
        private string especialidade;
        private int tempoDeProfissao;

        public Professor(string _nome, string _telefone, string _especialidade, int _tempoDeProfissao)
        {
            nome = _nome;
            telefone = _telefone;
            especialidade = _especialidade;
            tempoDeProfissao = _tempoDeProfissao;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Especialidade { get => especialidade; set => especialidade = value; }
        public int TempoDeProfissao { get => tempoDeProfissao; set => tempoDeProfissao = value; }
    }
}
