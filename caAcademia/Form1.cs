using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaTrabalhoFinal;
using static System.Net.Mime.MediaTypeNames;

namespace caAcademia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bt_cadastrarAluno_Click(object sender, EventArgs e)//cadastro do aluno
        {
            Aluno aluno1 = new Aluno(tbNome.Text,tbtelefonealuno.Text, tbEmail.Text, Convert.ToInt16(tbIdade.Text));
            ConexaoString stringConexao = new ConexaoString(); // objeto de conexão

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            string commandText = String.Format("insert into alunos(nome_aluno, idade, email_aluno, telefone_aluno)" +
                                                "values('{0}',{1},'{2}',{3})", aluno1.Nome, aluno1.Idade, aluno1.Email, aluno1.Telefone);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Cadastro Inserido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparTextAluno();
        }

        private void bt_ExcluirAluno_Click(object sender, EventArgs e)
        {
            string nome = tbNome.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            string commandText = String.Format("DELETE FROM alunos WHERE nome_aluno = '{0}'", nome);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Cadastro Removido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparTextAluno();

        }

        private void bt_AtualizarDadosAluno_Click(object sender, EventArgs e)
        {
            string nome = tbNome.Text;

            string telefone = tbtelefonealuno.Text;

            string email = tbEmail.Text;

            int idade = Convert.ToInt16(tbIdade.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            string commandText = String.Format("UPDATE alunos SET nome_aluno = '{0}', idade = {1}, email_aluno = '{2}', telefone_aluno = {3} WHERE nome_aluno = '{4}'", nome, idade, email, telefone, nome);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Cadastro Atualizado com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparTextAluno();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_ExibirAlunos_Click(object sender, EventArgs e)//exibir alunos
        {
            ConexaoString stringConexao = new ConexaoString(); // cria um objeto de conexão

            string conexao = stringConexao.ConnString(); // executa o método ConnString

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            DataTable dt = new DataTable(); // Objeto que pode conter tabelas

            string commandText = "SELECT * FROM alunos";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
            {
                Adpt.Fill(dt);
            }

            dataGridView1.DataSource = dt;

            con.Close();  // Fecha a Conexao com o banco
        }

        public void limparTextAluno()
        {
            tbNome.Text = String.Empty;
            tbIdade.Text = String.Empty;
            tbEmail.Text = String.Empty;
            tbtelefonealuno.Text = String.Empty;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Professor p1 = new Professor(tbNomeProf.Text, mbTelefoneProf.Text, tbEspecialidade.Text, Convert.ToInt16(mbTempoProf.Text));
            ConexaoString stringConexao = new ConexaoString(); // objeto de conexão

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            string commandText = String.Format("insert into professores(nome_professor, tempo_profissao, telefone_professor, especialidade)" +
                                                "values('{0}',{1},'{2}','{3}')", p1.Nome, p1.TempoDeProfissao, p1.Telefone, p1.Especialidade);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Cadastro Inserido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button13_Click(object sender, EventArgs e)// exibir professores
        {
            ConexaoString stringConexao = new ConexaoString(); // cria um objeto de conexão

            string conexao = stringConexao.ConnString(); // executa o método ConnString

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            DataTable dt = new DataTable(); // Objeto que pode conter tabelas

            string commandText = "SELECT * FROM professores";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
            {
                Adpt.Fill(dt);
            }

            dgProfessores.DataSource = dt;

            con.Close();  // Fecha a Conexao com o banco
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)//cadastro do plano
        {
            Plano plano1 = new Plano(textBox5.Text,Convert.ToDouble(maskedTextBox2.Text), maskedTextBox1.Text);
            ConexaoString stringConexao = new ConexaoString(); // objeto de conexão

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            string commandText = String.Format("insert into plano(nome_plano, data_adesao, valor)" +
                                                "values('{0}',{1},'{2}')", plano1.Nome, plano1.Data, plano1.Valor);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Cadastro Inserido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //limparTextAluno();

        }

        private void btExibirplanos_Click(object sender, EventArgs e) //exibir planos
        {
            ConexaoString stringConexao = new ConexaoString(); // cria um objeto de conexão

            string conexao = stringConexao.ConnString(); // executa o método ConnString

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            DataTable dt = new DataTable(); // Objeto que pode conter tabelas

            string commandText = "SELECT * FROM plano";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
            {
                Adpt.Fill(dt);
            }

            dataGridView2.DataSource = dt;

            con.Close();  // Fecha a Conexao com o banco

        }

        private void button6_Click(object sender, EventArgs e) //excluir plano
        {
            string nome = textBox5.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            string commandText = String.Format("DELETE FROM plano WHERE nome_plano = '{0}'", nome);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Cadastro Removido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //limparTextAluno();
        }

        private void tabPage4_Click(object sender, EventArgs e) 
        {

        }

        

        private void button10_Click(object sender, EventArgs e) // exibir professores na pagina de cadastro
        {
            ConexaoString stringConexao = new ConexaoString(); // cria um objeto de conexão

            string conexao = stringConexao.ConnString(); // executa o método ConnString

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            DataTable dt = new DataTable(); // Objeto que pode conter tabelas

            string commandText = "SELECT * FROM professores";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
            {
                Adpt.Fill(dt);
            }

            dataGridView4.DataSource = dt;

            con.Close();  // Fecha a Conexao com o banco

        }

        private void button9_Click(object sender, EventArgs e)// exibir planos na paagina de cadastro
        {
            ConexaoString stringConexao = new ConexaoString(); // cria um objeto de conexão

            string conexao = stringConexao.ConnString(); // executa o método ConnString

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            DataTable dt = new DataTable(); // Objeto que pode conter tabelas

            string commandText = "SELECT * FROM plano";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
            {
                Adpt.Fill(dt);
            }

            dataGridView5.DataSource = dt;

            con.Close();  // Fecha a Conexao com o banco

        }

        private void button8_Click(object sender, EventArgs e)// exibir alunos na pagina de cadastro
        {
            ConexaoString stringConexao = new ConexaoString(); // cria um objeto de conexão

            string conexao = stringConexao.ConnString(); // executa o método ConnString

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            DataTable dt = new DataTable(); // Objeto que pode conter tabelas

            string commandText = "SELECT * FROM alunos";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
            {
                Adpt.Fill(dt);
            }

            dataGridView3.DataSource = dt;

            con.Close();  // Fecha a Conexao com o banco

        }

        private void button1_Click(object sender, EventArgs e) //matricular alunos na pagina de cadastro
        {
            cadastrar c1= new cadastrar(textBox8.Text, textBox9.Text, textBox10.Text, Convert.ToDouble(textBox1.Text));

            string nome = textBox8.Text;
            string professor = textBox9.Text;
            string plano = textBox10.Text;
            double valor = Convert.ToDouble(textBox1.Text);

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            string commandText = String.Format("insert into alunos_ativos(nome_ativo, nome_professor, nome_plano,valor_apagar)" +
                                                "values('{0}','{1}','{2}','{3}')", c1.Nome, c1.Professor, c1.Plano, c1.Valor);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Cadastro Inserido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //limparTextAluno();

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//exibir alunos ativos
        {
            ConexaoString stringConexao = new ConexaoString(); // cria um objeto de conexão

            string conexao = stringConexao.ConnString(); // executa o método ConnString

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            DataTable dt = new DataTable(); // Objeto que pode conter tabelas

            string commandText = "SELECT * FROM alunos_ativos";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
            {
                Adpt.Fill(dt);
            }

            dataGridView6.DataSource = dt;

            con.Close();  // Fecha a Conexao com o banco

        }

        private void button2_Click(object sender, EventArgs e)// desmatricular alunos
        {
            string nome = textBox8.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            string commandText = String.Format("DELETE FROM alunos_ativos WHERE nome_ativo = '{0}'", nome);

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Cadastro Removido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //limparTextAluno();
        }
        

    
    }
    }
   
