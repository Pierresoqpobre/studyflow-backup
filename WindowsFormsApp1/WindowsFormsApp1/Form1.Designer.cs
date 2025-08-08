namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxlogados = new System.Windows.Forms.ListBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsobrenome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtsenha);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblresultado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtsobrenome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 748);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Senha";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsenha
            // 
            this.txtsenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsenha.BackColor = System.Drawing.Color.SlateBlue;
            this.txtsenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsenha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtsenha.Location = new System.Drawing.Point(506, 496);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(170, 20);
            this.txtsenha.TabIndex = 20;
            this.txtsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(695, 579);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "apagar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.listBoxlogados);
            this.panel2.Location = new System.Drawing.Point(85, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 337);
            this.panel2.TabIndex = 17;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // listBoxlogados
            // 
            this.listBoxlogados.FormattingEnabled = true;
            this.listBoxlogados.Location = new System.Drawing.Point(66, 65);
            this.listBoxlogados.Name = "listBoxlogados";
            this.listBoxlogados.Size = new System.Drawing.Size(120, 95);
            this.listBoxlogados.TabIndex = 0;
            this.listBoxlogados.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(574, 131);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(35, 13);
            this.lblresultado.TabIndex = 16;
            this.lblresultado.Text = "label4";
            this.lblresultado.Click += new System.EventHandler(this.lblresultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnome
            // 
            this.txtnome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnome.BackColor = System.Drawing.Color.SlateBlue;
            this.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnome.Location = new System.Drawing.Point(506, 381);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(170, 20);
            this.txtnome.TabIndex = 10;
            this.txtnome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.anunimo;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.anunimo;
            this.pictureBox1.InitialImage = global::WindowsFormsApp1.Properties.Resources.anunimo;
            this.pictureBox1.Location = new System.Drawing.Point(506, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sobrenome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsobrenome
            // 
            this.txtsobrenome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsobrenome.BackColor = System.Drawing.Color.SlateBlue;
            this.txtsobrenome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsobrenome.Location = new System.Drawing.Point(506, 439);
            this.txtsobrenome.Name = "txtsobrenome";
            this.txtsobrenome.Size = new System.Drawing.Size(170, 20);
            this.txtsobrenome.TabIndex = 14;
            this.txtsobrenome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1064, 749);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Study Flow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxlogados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsobrenome;
    }
}

