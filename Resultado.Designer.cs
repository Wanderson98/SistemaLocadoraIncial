namespace Aula62Exe2
{
    partial class Resultado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente: ";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(109, 18);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 24);
            this.lblCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Veiculo: ";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Location = new System.Drawing.Point(115, 88);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(49, 24);
            this.lblVeiculo.TabIndex = 3;
            this.lblVeiculo.Text = "teste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duração:";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(117, 154);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(49, 24);
            this.lblDuracao.TabIndex = 3;
            this.lblDuracao.Text = "teste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor total: ";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(133, 231);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(49, 24);
            this.lblValorTotal.TabIndex = 3;
            this.lblValorTotal.Text = "teste";
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 425);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.lblVeiculo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Resultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.Resultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValorTotal;
    }
}