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
            //variaveis usadas
            string nome = txtnome.Text;
            
            string senha = txtsenha.Text;


            //função do click
            if (nome.Equals("administrador", StringComparison.OrdinalIgnoreCase) &&
        senha.Equals("pigeon", StringComparison.OrdinalIgnoreCase))
            {
                panel2.Visible = true;
                MessageBox.Show("Acesso administrativo liberado!");

                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha))
                {
                    return;

                }
                else
                {

                    Form2 frm2 = new Form2(); frm2.Show();

                }
                for (Nomeusuario.contador = 0; Nomeusuario.contador < 249; Nomeusuario.contador++)
                {


                    if (Nomeusuario.contador == 0)
                    {

                        txtnome.Text = Adm.nomeadm;
                        txtsenha.Text = Adm.senhaadm;



                    }

                    if (Nomeusuario.contador >= Nomeusuario.logados.Length)
                    {
                        MessageBox.Show("Limite de usuários atingido.");

                    }



                    // Simples validação
                    if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha))
                    {
                        MessageBox.Show("Preencha todos os campos.");

                    }

                    // Salva no vetor
                    Nomeusuario.logados[Nomeusuario.contador] = $"[{Nomeusuario.contador}] {nome}  - Senha: {senha}";
                    listBoxlogados.Items.Add(Nomeusuario.contador);

                    Nomeusuario.contador++; // Incrementa o índice
                    txtnome.Clear();
                    
                    txtsenha.Clear();
                    

                }
                }
                }
                
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxlogados.Items.Add($"[{Nomeusuario.contador}] {txtnome.Text} - {txtsenha.Text}");
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
            
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            txtsenha.Clear();

            panel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }
    }
}
