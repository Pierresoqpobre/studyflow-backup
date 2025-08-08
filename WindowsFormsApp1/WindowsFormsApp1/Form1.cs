using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static string nomecompleto;
        public Form1()
        {


            InitializeComponent();

            
    }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            string sobrenome = txtsobrenome.Text;
            string senha = txtsenha.Text;



            if (nome.Equals("administrador", StringComparison.OrdinalIgnoreCase) &&
        senha.Equals("pigeon", StringComparison.OrdinalIgnoreCase))
            {
                panel2.Visible = true;
                MessageBox.Show("Acesso administrativo liberado!");

                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(sobrenome) || string.IsNullOrWhiteSpace(senha))
                {
                    return;

                }
                else
                {

                    Form2 frm2 = new Form2(); frm2.Show();

                }
                for (int i = 0; i < 249; i++)
                {


                    if (i == 0)
                    {

                        txtnome.Text = Adm.nomeadm;
                        txtsenha.Text = Adm.senhaadm;



                    }

                    if (i >= Nomeusuario.logados.Length)
                    {
                        MessageBox.Show("Limite de usuários atingido.");

                    }



                    // Simples validação
                    if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha))
                    {
                        MessageBox.Show("Preencha todos os campos.");

                    }

                    // Salva no vetor
                    Nomeusuario.logados[i] = $"[{i}] {nome} {sobrenome} - Senha: {senha}";
                    listBoxlogados.Items.Add(i);

                    i++; // Incrementa o índice
                    txtnome.Clear();
                    txtsobrenome.Clear();
                    txtsenha.Clear();












                }
            }
        }
        

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtsenha.Clear();
            txtnome.Clear();
            txtsobrenome.Clear();
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }
    }
}
