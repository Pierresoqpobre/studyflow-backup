using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string senha = txtSenha.Text;


            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha nome e senha.");
                return;
            }

            if (Nomeusuario.contador >= Nomeusuario.nomes.Length)
            {
                MessageBox.Show("Limite de cadastros atingido.");
                return;
            }

            // Cadastra nos vetores
            Nomeusuario.nomes[Nomeusuario.contador] = nome;
            Nomeusuario.senhas[Nomeusuario.contador] = senha;
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=pgadmin;Database=StudyFlow";
            try
            {
                using (var conn = new Npgsql.NpgsqlConnection(connString))
                {
                    conn.Open();

                    string sql = "INSERT INTO registros (Nome, Senha) VALUES (@nome, @senha)";
                    using (var cmd = new Npgsql.NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("nome", nome);
                        cmd.Parameters.AddWithValue("senha", senha);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar no banco: " + ex.Message);
                return;

                MessageBox.Show($"Cadastro realizado com sucesso! (Posição {Nomeusuario.contador})");

                // Limpa os campos e incrementa o contador
                txtNome.Clear();
                txtSenha.Clear();
                Nomeusuario.contador++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
