namespace Aula62Exe2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbVeiculos = new System.Windows.Forms.ComboBox();
            this.rbtnMotos = new System.Windows.Forms.RadioButton();
            this.rbtnCarros = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataInicial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataDeEntrega = new System.Windows.Forms.TextBox();
            this.txtValorPorHora = new System.Windows.Forms.TextBox();
            this.txtValorPorDia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblValorAvaria = new System.Windows.Forms.Label();
            this.txtValorAvaria = new System.Windows.Forms.TextBox();
            this.rbtnAvariaNao = new System.Windows.Forms.RadioButton();
            this.rbtnAvariaSim = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente: ";
            // 
            // cbbClientes
            // 
            this.cbbClientes.FormattingEnabled = true;
            this.cbbClientes.Location = new System.Drawing.Point(103, 30);
            this.cbbClientes.Name = "cbbClientes";
            this.cbbClientes.Size = new System.Drawing.Size(382, 28);
            this.cbbClientes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Veiculo";
            // 
            // cbbVeiculos
            // 
            this.cbbVeiculos.FormattingEnabled = true;
            this.cbbVeiculos.Location = new System.Drawing.Point(103, 96);
            this.cbbVeiculos.Name = "cbbVeiculos";
            this.cbbVeiculos.Size = new System.Drawing.Size(382, 28);
            this.cbbVeiculos.TabIndex = 4;
            // 
            // rbtnMotos
            // 
            this.rbtnMotos.AutoSize = true;
            this.rbtnMotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMotos.Location = new System.Drawing.Point(174, 130);
            this.rbtnMotos.Name = "rbtnMotos";
            this.rbtnMotos.Size = new System.Drawing.Size(62, 20);
            this.rbtnMotos.TabIndex = 5;
            this.rbtnMotos.TabStop = true;
            this.rbtnMotos.Text = "Motos";
            this.rbtnMotos.UseVisualStyleBackColor = true;
            this.rbtnMotos.CheckedChanged += new System.EventHandler(this.rbtnMotos_CheckedChanged);
            // 
            // rbtnCarros
            // 
            this.rbtnCarros.AutoSize = true;
            this.rbtnCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCarros.Location = new System.Drawing.Point(103, 130);
            this.rbtnCarros.Name = "rbtnCarros";
            this.rbtnCarros.Size = new System.Drawing.Size(65, 20);
            this.rbtnCarros.TabIndex = 5;
            this.rbtnCarros.TabStop = true;
            this.rbtnCarros.Text = "Carros";
            this.rbtnCarros.UseVisualStyleBackColor = true;
            this.rbtnCarros.CheckedChanged += new System.EventHandler(this.rbtnCarros_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Inicial";
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Location = new System.Drawing.Point(125, 233);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(183, 26);
            this.txtDataInicial.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de Entrega";
            // 
            // txtDataDeEntrega
            // 
            this.txtDataDeEntrega.Location = new System.Drawing.Point(164, 283);
            this.txtDataDeEntrega.Name = "txtDataDeEntrega";
            this.txtDataDeEntrega.Size = new System.Drawing.Size(144, 26);
            this.txtDataDeEntrega.TabIndex = 7;
            // 
            // txtValorPorHora
            // 
            this.txtValorPorHora.Location = new System.Drawing.Point(149, 178);
            this.txtValorPorHora.Name = "txtValorPorHora";
            this.txtValorPorHora.Size = new System.Drawing.Size(100, 26);
            this.txtValorPorHora.TabIndex = 8;
            // 
            // txtValorPorDia
            // 
            this.txtValorPorDia.Location = new System.Drawing.Point(368, 178);
            this.txtValorPorDia.Name = "txtValorPorDia";
            this.txtValorPorDia.Size = new System.Drawing.Size(117, 26);
            this.txtValorPorDia.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor por Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor por Dia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Seguro";
            // 
            // txtSeguro
            // 
            this.txtSeguro.Location = new System.Drawing.Point(415, 233);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(100, 26);
            this.txtSeguro.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblValorAvaria);
            this.panel1.Controls.Add(this.txtValorAvaria);
            this.panel1.Controls.Add(this.rbtnAvariaNao);
            this.panel1.Controls.Add(this.rbtnAvariaSim);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(343, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 12;
            // 
            // lblValorAvaria
            // 
            this.lblValorAvaria.AutoSize = true;
            this.lblValorAvaria.Location = new System.Drawing.Point(12, 62);
            this.lblValorAvaria.Name = "lblValorAvaria";
            this.lblValorAvaria.Size = new System.Drawing.Size(46, 20);
            this.lblValorAvaria.TabIndex = 4;
            this.lblValorAvaria.Text = "Valor";
            this.lblValorAvaria.Visible = false;
            // 
            // txtValorAvaria
            // 
            this.txtValorAvaria.Location = new System.Drawing.Point(72, 59);
            this.txtValorAvaria.Name = "txtValorAvaria";
            this.txtValorAvaria.Size = new System.Drawing.Size(116, 26);
            this.txtValorAvaria.TabIndex = 3;
            this.txtValorAvaria.Visible = false;
            // 
            // rbtnAvariaNao
            // 
            this.rbtnAvariaNao.AutoSize = true;
            this.rbtnAvariaNao.Location = new System.Drawing.Point(132, 16);
            this.rbtnAvariaNao.Name = "rbtnAvariaNao";
            this.rbtnAvariaNao.Size = new System.Drawing.Size(56, 24);
            this.rbtnAvariaNao.TabIndex = 2;
            this.rbtnAvariaNao.TabStop = true;
            this.rbtnAvariaNao.Text = "Não";
            this.rbtnAvariaNao.UseVisualStyleBackColor = true;
            // 
            // rbtnAvariaSim
            // 
            this.rbtnAvariaSim.AutoSize = true;
            this.rbtnAvariaSim.Location = new System.Drawing.Point(72, 16);
            this.rbtnAvariaSim.Name = "rbtnAvariaSim";
            this.rbtnAvariaSim.Size = new System.Drawing.Size(54, 24);
            this.rbtnAvariaSim.TabIndex = 1;
            this.rbtnAvariaSim.TabStop = true;
            this.rbtnAvariaSim.Text = "Sim";
            this.rbtnAvariaSim.UseVisualStyleBackColor = true;
            this.rbtnAvariaSim.CheckedChanged += new System.EventHandler(this.rbtnAvariaSim_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Avaria";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(450, 426);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(106, 39);
            this.btnFinalizar.TabIndex = 13;
            this.btnFinalizar.Text = "Finalizar ";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 477);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSeguro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorPorDia);
            this.Controls.Add(this.txtValorPorHora);
            this.Controls.Add(this.txtDataDeEntrega);
            this.Controls.Add(this.txtDataInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtnMotos);
            this.Controls.Add(this.rbtnCarros);
            this.Controls.Add(this.cbbVeiculos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbVeiculos;
        private System.Windows.Forms.RadioButton rbtnMotos;
        private System.Windows.Forms.RadioButton rbtnCarros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataDeEntrega;
        private System.Windows.Forms.TextBox txtValorPorHora;
        private System.Windows.Forms.TextBox txtValorPorDia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValorAvaria;
        private System.Windows.Forms.TextBox txtValorAvaria;
        private System.Windows.Forms.RadioButton rbtnAvariaNao;
        private System.Windows.Forms.RadioButton rbtnAvariaSim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFinalizar;
    }
}

