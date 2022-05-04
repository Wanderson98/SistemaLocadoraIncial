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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnAvariaNao = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnAvariaSim = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblValorAvaria = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorAvaria = new MaterialSkin.Controls.MaterialTextBox();
            this.cbbClientes = new MaterialSkin.Controls.MaterialComboBox();
            this.cbbVeiculos = new MaterialSkin.Controls.MaterialComboBox();
            this.rbtnCarros = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnMotos = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtValorPorHora = new MaterialSkin.Controls.MaterialTextBox();
            this.txtValorPorDia = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDataInicial = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDataDeEntrega = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeguro = new MaterialSkin.Controls.MaterialTextBox();
            this.btnFinalizar = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 65);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Entrega";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor por Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor por Dia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Seguro";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnAvariaNao);
            this.panel1.Controls.Add(this.rbtnAvariaSim);
            this.panel1.Controls.Add(this.lblValorAvaria);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtValorAvaria);
            this.panel1.Location = new System.Drawing.Point(355, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 133);
            this.panel1.TabIndex = 12;
            // 
            // rbtnAvariaNao
            // 
            this.rbtnAvariaNao.AutoSize = true;
            this.rbtnAvariaNao.Depth = 0;
            this.rbtnAvariaNao.Location = new System.Drawing.Point(191, 13);
            this.rbtnAvariaNao.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnAvariaNao.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnAvariaNao.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnAvariaNao.Name = "rbtnAvariaNao";
            this.rbtnAvariaNao.Ripple = true;
            this.rbtnAvariaNao.Size = new System.Drawing.Size(64, 37);
            this.rbtnAvariaNao.TabIndex = 21;
            this.rbtnAvariaNao.TabStop = true;
            this.rbtnAvariaNao.Text = "Não";
            this.rbtnAvariaNao.UseVisualStyleBackColor = true;
            // 
            // rbtnAvariaSim
            // 
            this.rbtnAvariaSim.AutoSize = true;
            this.rbtnAvariaSim.Depth = 0;
            this.rbtnAvariaSim.Location = new System.Drawing.Point(101, 13);
            this.rbtnAvariaSim.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnAvariaSim.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnAvariaSim.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnAvariaSim.Name = "rbtnAvariaSim";
            this.rbtnAvariaSim.Ripple = true;
            this.rbtnAvariaSim.Size = new System.Drawing.Size(63, 37);
            this.rbtnAvariaSim.TabIndex = 20;
            this.rbtnAvariaSim.TabStop = true;
            this.rbtnAvariaSim.Text = "Sim";
            this.rbtnAvariaSim.UseVisualStyleBackColor = true;
            this.rbtnAvariaSim.CheckedChanged += new System.EventHandler(this.rbtnAvariaSim_CheckedChanged_1);
            // 
            // lblValorAvaria
            // 
            this.lblValorAvaria.AutoSize = true;
            this.lblValorAvaria.Location = new System.Drawing.Point(11, 83);
            this.lblValorAvaria.Name = "lblValorAvaria";
            this.lblValorAvaria.Size = new System.Drawing.Size(46, 20);
            this.lblValorAvaria.TabIndex = 4;
            this.lblValorAvaria.Text = "Valor";
            this.lblValorAvaria.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Avaria";
            // 
            // txtValorAvaria
            // 
            this.txtValorAvaria.AnimateReadOnly = false;
            this.txtValorAvaria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorAvaria.Depth = 0;
            this.txtValorAvaria.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtValorAvaria.LeadingIcon = null;
            this.txtValorAvaria.Location = new System.Drawing.Point(101, 66);
            this.txtValorAvaria.MaxLength = 50;
            this.txtValorAvaria.MouseState = MaterialSkin.MouseState.OUT;
            this.txtValorAvaria.Multiline = false;
            this.txtValorAvaria.Name = "txtValorAvaria";
            this.txtValorAvaria.Size = new System.Drawing.Size(154, 50);
            this.txtValorAvaria.TabIndex = 19;
            this.txtValorAvaria.Text = "";
            this.txtValorAvaria.TrailingIcon = null;
            // 
            // cbbClientes
            // 
            this.cbbClientes.AutoResize = false;
            this.cbbClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbClientes.Depth = 0;
            this.cbbClientes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbClientes.DropDownHeight = 174;
            this.cbbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClientes.DropDownWidth = 121;
            this.cbbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbClientes.FormattingEnabled = true;
            this.cbbClientes.IntegralHeight = false;
            this.cbbClientes.ItemHeight = 43;
            this.cbbClientes.Location = new System.Drawing.Point(98, 85);
            this.cbbClientes.MaxDropDownItems = 4;
            this.cbbClientes.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbClientes.Name = "cbbClientes";
            this.cbbClientes.Size = new System.Drawing.Size(536, 49);
            this.cbbClientes.StartIndex = 0;
            this.cbbClientes.TabIndex = 14;
            // 
            // cbbVeiculos
            // 
            this.cbbVeiculos.AutoResize = false;
            this.cbbVeiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbVeiculos.Depth = 0;
            this.cbbVeiculos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbVeiculos.DropDownHeight = 174;
            this.cbbVeiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbVeiculos.DropDownWidth = 121;
            this.cbbVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbVeiculos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbVeiculos.FormattingEnabled = true;
            this.cbbVeiculos.IntegralHeight = false;
            this.cbbVeiculos.ItemHeight = 43;
            this.cbbVeiculos.Location = new System.Drawing.Point(98, 152);
            this.cbbVeiculos.MaxDropDownItems = 4;
            this.cbbVeiculos.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbVeiculos.Name = "cbbVeiculos";
            this.cbbVeiculos.Size = new System.Drawing.Size(536, 49);
            this.cbbVeiculos.StartIndex = 0;
            this.cbbVeiculos.TabIndex = 16;
            // 
            // rbtnCarros
            // 
            this.rbtnCarros.AutoSize = true;
            this.rbtnCarros.Depth = 0;
            this.rbtnCarros.Location = new System.Drawing.Point(98, 215);
            this.rbtnCarros.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnCarros.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnCarros.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnCarros.Name = "rbtnCarros";
            this.rbtnCarros.Ripple = true;
            this.rbtnCarros.Size = new System.Drawing.Size(81, 37);
            this.rbtnCarros.TabIndex = 18;
            this.rbtnCarros.TabStop = true;
            this.rbtnCarros.Text = "Carros";
            this.rbtnCarros.UseVisualStyleBackColor = true;
            this.rbtnCarros.CheckedChanged += new System.EventHandler(this.rbtnCarros_CheckedChanged_1);
            // 
            // rbtnMotos
            // 
            this.rbtnMotos.AutoSize = true;
            this.rbtnMotos.Depth = 0;
            this.rbtnMotos.Location = new System.Drawing.Point(188, 215);
            this.rbtnMotos.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnMotos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnMotos.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnMotos.Name = "rbtnMotos";
            this.rbtnMotos.Ripple = true;
            this.rbtnMotos.Size = new System.Drawing.Size(80, 37);
            this.rbtnMotos.TabIndex = 18;
            this.rbtnMotos.TabStop = true;
            this.rbtnMotos.Text = "Motos";
            this.rbtnMotos.UseVisualStyleBackColor = true;
            this.rbtnMotos.CheckedChanged += new System.EventHandler(this.rbtnMotos_CheckedChanged_1);
            // 
            // txtValorPorHora
            // 
            this.txtValorPorHora.AnimateReadOnly = false;
            this.txtValorPorHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorPorHora.Depth = 0;
            this.txtValorPorHora.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtValorPorHora.LeadingIcon = null;
            this.txtValorPorHora.Location = new System.Drawing.Point(147, 266);
            this.txtValorPorHora.MaxLength = 50;
            this.txtValorPorHora.MouseState = MaterialSkin.MouseState.OUT;
            this.txtValorPorHora.Multiline = false;
            this.txtValorPorHora.Name = "txtValorPorHora";
            this.txtValorPorHora.Size = new System.Drawing.Size(154, 50);
            this.txtValorPorHora.TabIndex = 19;
            this.txtValorPorHora.Text = "";
            this.txtValorPorHora.TrailingIcon = null;
            // 
            // txtValorPorDia
            // 
            this.txtValorPorDia.AnimateReadOnly = false;
            this.txtValorPorDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorPorDia.Depth = 0;
            this.txtValorPorDia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtValorPorDia.LeadingIcon = null;
            this.txtValorPorDia.Location = new System.Drawing.Point(147, 337);
            this.txtValorPorDia.MaxLength = 50;
            this.txtValorPorDia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtValorPorDia.Multiline = false;
            this.txtValorPorDia.Name = "txtValorPorDia";
            this.txtValorPorDia.Size = new System.Drawing.Size(154, 50);
            this.txtValorPorDia.TabIndex = 19;
            this.txtValorPorDia.Text = "";
            this.txtValorPorDia.TrailingIcon = null;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.AnimateReadOnly = false;
            this.txtDataInicial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataInicial.Depth = 0;
            this.txtDataInicial.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataInicial.LeadingIcon = null;
            this.txtDataInicial.Location = new System.Drawing.Point(456, 266);
            this.txtDataInicial.MaxLength = 50;
            this.txtDataInicial.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDataInicial.Multiline = false;
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(178, 50);
            this.txtDataInicial.TabIndex = 20;
            this.txtDataInicial.Text = "";
            this.txtDataInicial.TrailingIcon = null;
            // 
            // txtDataDeEntrega
            // 
            this.txtDataDeEntrega.AnimateReadOnly = false;
            this.txtDataDeEntrega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataDeEntrega.Depth = 0;
            this.txtDataDeEntrega.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataDeEntrega.LeadingIcon = null;
            this.txtDataDeEntrega.Location = new System.Drawing.Point(456, 337);
            this.txtDataDeEntrega.MaxLength = 50;
            this.txtDataDeEntrega.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDataDeEntrega.Multiline = false;
            this.txtDataDeEntrega.Name = "txtDataDeEntrega";
            this.txtDataDeEntrega.Size = new System.Drawing.Size(178, 50);
            this.txtDataDeEntrega.TabIndex = 20;
            this.txtDataDeEntrega.Text = "";
            this.txtDataDeEntrega.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Veiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cliente";
            // 
            // txtSeguro
            // 
            this.txtSeguro.AnimateReadOnly = false;
            this.txtSeguro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeguro.Depth = 0;
            this.txtSeguro.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSeguro.LeadingIcon = null;
            this.txtSeguro.Location = new System.Drawing.Point(147, 415);
            this.txtSeguro.MaxLength = 50;
            this.txtSeguro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSeguro.Multiline = false;
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(154, 50);
            this.txtSeguro.TabIndex = 19;
            this.txtSeguro.Text = "";
            this.txtSeguro.TrailingIcon = null;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinalizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFinalizar.Depth = 0;
            this.btnFinalizar.HighEmphasis = true;
            this.btnFinalizar.Icon = null;
            this.btnFinalizar.Location = new System.Drawing.Point(476, 573);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFinalizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFinalizar.Size = new System.Drawing.Size(94, 36);
            this.btnFinalizar.TabIndex = 22;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFinalizar.UseAccentColor = false;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 618);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataDeEntrega);
            this.Controls.Add(this.txtDataInicial);
            this.Controls.Add(this.txtSeguro);
            this.Controls.Add(this.txtValorPorDia);
            this.Controls.Add(this.txtValorPorHora);
            this.Controls.Add(this.rbtnMotos);
            this.Controls.Add(this.rbtnCarros);
            this.Controls.Add(this.cbbVeiculos);
            this.Controls.Add(this.cbbClientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 65, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locação Cast";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValorAvaria;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialComboBox cbbClientes;
        private MaterialSkin.Controls.MaterialComboBox cbbVeiculos;
        private MaterialSkin.Controls.MaterialRadioButton rbtnCarros;
        private MaterialSkin.Controls.MaterialRadioButton rbtnMotos;
        private MaterialSkin.Controls.MaterialTextBox txtValorPorHora;
        private MaterialSkin.Controls.MaterialTextBox txtValorPorDia;
        private MaterialSkin.Controls.MaterialTextBox txtDataInicial;
        private MaterialSkin.Controls.MaterialTextBox txtDataDeEntrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox txtSeguro;
        private MaterialSkin.Controls.MaterialTextBox txtValorAvaria;
        private MaterialSkin.Controls.MaterialRadioButton rbtnAvariaSim;
        private MaterialSkin.Controls.MaterialRadioButton rbtnAvariaNao;
        private MaterialSkin.Controls.MaterialButton btnFinalizar;
    }
}

