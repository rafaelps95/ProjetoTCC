﻿namespace ProjetoTCC.View
{
    partial class View_Motorista
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCatCNH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxValidadeCNH = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCNH = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motorista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(51, 120);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(654, 26);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxCatCNH
            // 
            this.textBoxCatCNH.Location = new System.Drawing.Point(51, 240);
            this.textBoxCatCNH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCatCNH.Name = "textBoxCatCNH";
            this.textBoxCatCNH.Size = new System.Drawing.Size(295, 26);
            this.textBoxCatCNH.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "CPF";
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(51, 180);
            this.textBoxCPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCPF.Mask = "000.000.000-00";
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(295, 26);
            this.textBoxCPF.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Categoria CNH";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 20;
            // 
            // textBoxValidadeCNH
            // 
            this.textBoxValidadeCNH.Location = new System.Drawing.Point(410, 240);
            this.textBoxValidadeCNH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxValidadeCNH.Mask = "00/00/0000";
            this.textBoxValidadeCNH.Name = "textBoxValidadeCNH";
            this.textBoxValidadeCNH.Size = new System.Drawing.Size(295, 26);
            this.textBoxValidadeCNH.TabIndex = 10;
            this.textBoxValidadeCNH.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "CNH";
            // 
            // textBoxCNH
            // 
            this.textBoxCNH.Location = new System.Drawing.Point(410, 180);
            this.textBoxCNH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCNH.Mask = "000.000.000-00";
            this.textBoxCNH.Name = "textBoxCNH";
            this.textBoxCNH.Size = new System.Drawing.Size(295, 26);
            this.textBoxCNH.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Validade CNH";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(507, 311);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(100, 40);
            this.buttonLimpar.TabIndex = 31;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(206, 311);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(100, 40);
            this.buttonAlterar.TabIndex = 30;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Visible = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(354, 311);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(100, 40);
            this.buttonExcluir.TabIndex = 29;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Visible = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(51, 311);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(100, 40);
            this.buttonEnviar.TabIndex = 28;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // View_Motorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(757, 392);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.textBoxCNH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxValidadeCNH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCatCNH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "View_Motorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zezinho Transportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCatCNH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox textBoxCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox textBoxValidadeCNH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox textBoxCNH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonEnviar;
    }
}