namespace ProjetoTCC.View
{
    partial class View_Reserva
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
            this.textBoxCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxSaida = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxVeiculo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxMotorista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePartida = new System.Windows.Forms.DateTimePicker();
            this.dateTimeRetorno = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCPFCNPJ
            // 
            this.textBoxCPFCNPJ.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.textBoxCPFCNPJ.Location = new System.Drawing.Point(48, 137);
            this.textBoxCPFCNPJ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCPFCNPJ.Mask = "00000000000000";
            this.textBoxCPFCNPJ.Name = "textBoxCPFCNPJ";
            this.textBoxCPFCNPJ.Size = new System.Drawing.Size(197, 26);
            this.textBoxCPFCNPJ.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "CPF ou CNPJ do cliente (somente números)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 46);
            this.label1.TabIndex = 24;
            this.label1.Text = "Reserva";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 35);
            this.button1.TabIndex = 48;
            this.button1.Text = "Buscar cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 202);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 35);
            this.button2.TabIndex = 51;
            this.button2.Text = "Selecionar saída";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxSaida
            // 
            this.textBoxSaida.Enabled = false;
            this.textBoxSaida.Location = new System.Drawing.Point(48, 206);
            this.textBoxSaida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSaida.Name = "textBoxSaida";
            this.textBoxSaida.Size = new System.Drawing.Size(379, 26);
            this.textBoxSaida.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 180);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 49;
            this.label11.Text = "Local de saída";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(435, 273);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 35);
            this.button3.TabIndex = 54;
            this.button3.Text = "Selecionar destino";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Enabled = false;
            this.textBoxDestino.Location = new System.Drawing.Point(48, 277);
            this.textBoxDestino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(379, 26);
            this.textBoxDestino.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 251);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 20);
            this.label12.TabIndex = 52;
            this.label12.Text = "Local de destino";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(435, 344);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 35);
            this.button4.TabIndex = 57;
            this.button4.Text = "Selecionar veículo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxVeiculo
            // 
            this.textBoxVeiculo.Enabled = false;
            this.textBoxVeiculo.Location = new System.Drawing.Point(48, 348);
            this.textBoxVeiculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxVeiculo.Name = "textBoxVeiculo";
            this.textBoxVeiculo.Size = new System.Drawing.Size(379, 26);
            this.textBoxVeiculo.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 322);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 55;
            this.label13.Text = "Veículo";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(435, 416);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 35);
            this.button5.TabIndex = 60;
            this.button5.Text = "Selecionar motorista";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxMotorista
            // 
            this.textBoxMotorista.Enabled = false;
            this.textBoxMotorista.Location = new System.Drawing.Point(48, 420);
            this.textBoxMotorista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMotorista.Name = "textBoxMotorista";
            this.textBoxMotorista.Size = new System.Drawing.Size(379, 26);
            this.textBoxMotorista.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 394);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Motorista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 472);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Partida";
            // 
            // dateTimePartida
            // 
            this.dateTimePartida.CustomFormat = "HH:mm   dd/MM/yyyy";
            this.dateTimePartida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePartida.Location = new System.Drawing.Point(48, 496);
            this.dateTimePartida.Name = "dateTimePartida";
            this.dateTimePartida.Size = new System.Drawing.Size(220, 26);
            this.dateTimePartida.TabIndex = 62;
            // 
            // dateTimeRetorno
            // 
            this.dateTimeRetorno.CustomFormat = "HH:mm   dd/MM/yyyy";
            this.dateTimeRetorno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeRetorno.Location = new System.Drawing.Point(48, 575);
            this.dateTimeRetorno.Name = "dateTimeRetorno";
            this.dateTimeRetorno.Size = new System.Drawing.Size(220, 26);
            this.dateTimeRetorno.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 551);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Previsão de retorno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 472);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Valor:";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(281, 496);
            this.labelValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(180, 55);
            this.labelValor.TabIndex = 66;
            this.labelValor.Text = "R$0,00";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(614, 585);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(174, 35);
            this.button6.TabIndex = 67;
            this.button6.Text = "Prosseguir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 68;
            // 
            // View_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(819, 644);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimeRetorno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePartida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBoxMotorista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxVeiculo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxDestino);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxSaida);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCPFCNPJ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "View_Reserva";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox textBoxCPFCNPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxSaida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxDestino;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxVeiculo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxMotorista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePartida;
        private System.Windows.Forms.DateTimePicker dateTimeRetorno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
    }
}