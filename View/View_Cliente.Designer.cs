namespace ProjetoTCC.View
{
    partial class View_Cliente
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
            this.textBoxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonPF = new System.Windows.Forms.RadioButton();
            this.radioButtonPJ = new System.Windows.Forms.RadioButton();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
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
            // textBoxCNPJ
            // 
            this.textBoxCNPJ.Enabled = false;
            this.textBoxCNPJ.Location = new System.Drawing.Point(51, 360);
            this.textBoxCNPJ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCNPJ.Mask = "00.000.000/0000-00";
            this.textBoxCNPJ.Name = "textBoxCNPJ";
            this.textBoxCNPJ.Size = new System.Drawing.Size(295, 26);
            this.textBoxCNPJ.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 335);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "CNPJ";
            // 
            // textBoxDataNasc
            // 
            this.textBoxDataNasc.Location = new System.Drawing.Point(51, 240);
            this.textBoxDataNasc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDataNasc.Mask = "00/00/0000";
            this.textBoxDataNasc.Name = "textBoxDataNasc";
            this.textBoxDataNasc.Size = new System.Drawing.Size(295, 26);
            this.textBoxDataNasc.TabIndex = 9;
            this.textBoxDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "CPF";
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(51, 300);
            this.textBoxCPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCPF.Mask = "000.000.000-99";
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(295, 26);
            this.textBoxCPF.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data de nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo";
            // 
            // radioButtonPF
            // 
            this.radioButtonPF.AutoSize = true;
            this.radioButtonPF.Checked = true;
            this.radioButtonPF.Location = new System.Drawing.Point(51, 182);
            this.radioButtonPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonPF.Name = "radioButtonPF";
            this.radioButtonPF.Size = new System.Drawing.Size(127, 24);
            this.radioButtonPF.TabIndex = 4;
            this.radioButtonPF.TabStop = true;
            this.radioButtonPF.Text = "Pessoa física";
            this.radioButtonPF.UseVisualStyleBackColor = true;
            this.radioButtonPF.CheckedChanged += new System.EventHandler(this.radioButtonPF_CheckedChanged);
            // 
            // radioButtonPJ
            // 
            this.radioButtonPJ.AutoSize = true;
            this.radioButtonPJ.Location = new System.Drawing.Point(206, 182);
            this.radioButtonPJ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonPJ.Name = "radioButtonPJ";
            this.radioButtonPJ.Size = new System.Drawing.Size(140, 24);
            this.radioButtonPJ.TabIndex = 5;
            this.radioButtonPJ.Text = "Pessoa jurídica";
            this.radioButtonPJ.UseVisualStyleBackColor = true;
            this.radioButtonPJ.CheckedChanged += new System.EventHandler(this.radioButtonPJ_CheckedChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(51, 420);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(295, 26);
            this.textBoxEmail.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 395);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "E-mail";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(410, 240);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(295, 26);
            this.textBoxUser.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone";
            // 
            // textBoxFone
            // 
            this.textBoxFone.Location = new System.Drawing.Point(410, 180);
            this.textBoxFone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFone.Mask = "(00) 00000-0000";
            this.textBoxFone.Name = "textBoxFone";
            this.textBoxFone.Size = new System.Drawing.Size(295, 26);
            this.textBoxFone.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Usuário";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(51, 548);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(100, 40);
            this.buttonEnviar.TabIndex = 18;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(354, 548);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(100, 40);
            this.buttonExcluir.TabIndex = 19;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Visible = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(206, 548);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(100, 40);
            this.buttonAlterar.TabIndex = 22;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Visible = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(507, 548);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(100, 40);
            this.buttonLimpar.TabIndex = 23;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // View_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(755, 613);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.textBoxFone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButtonPJ);
            this.Controls.Add(this.radioButtonPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDataNasc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCNPJ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "View_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zezinho Transportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.MaskedTextBox textBoxCNPJ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox textBoxDataNasc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox textBoxCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonPF;
        private System.Windows.Forms.RadioButton radioButtonPJ;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox textBoxFone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonLimpar;
    }
}