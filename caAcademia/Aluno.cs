using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAcademia
{
    internal class Aluno
    {
        private string nome;
        private string telefone;
        private string email;
        private int idade;

        public Aluno(string _nome, string _telefone, string _email, int _idade)
        {
            nome = _nome;
            telefone = _telefone;
            email = _email;
            idade = _idade;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public int Idade { get => idade; set => idade = value; }

       
    }
}
