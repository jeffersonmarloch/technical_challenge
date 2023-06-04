namespace technical_challenge
{
    partial class Form4
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
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            maskedTextBox5 = new MaskedTextBox();
            label11 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            label10 = new Label();
            groupBox2 = new GroupBox();
            checkBox2 = new CheckBox();
            groupBox1 = new GroupBox();
            maskedTextBox3 = new MaskedTextBox();
            label9 = new Label();
            comboBox2 = new ComboBox();
            label8 = new Label();
            checkBox1 = new CheckBox();
            maskedTextBox2 = new MaskedTextBox();
            label7 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label6 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            date = new MaskedTextBox();
            label4 = new Label();
            tel_client = new MaskedTextBox();
            label3 = new Label();
            email_client = new TextBox();
            label2 = new Label();
            name_client = new TextBox();
            label1 = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(240, 704);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 27;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(354, 704);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 26;
            button1.Text = "Adicionar Cliente";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(maskedTextBox5);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(maskedTextBox4);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(273, 521);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 133);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Senha de Acesso";
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(21, 90);
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(100, 23);
            maskedTextBox5.TabIndex = 3;
            maskedTextBox5.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 72);
            label11.Name = "label11";
            label11.Size = new Size(130, 15);
            label11.TabIndex = 2;
            label11.Text = "Confirmação de Senha:";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(21, 37);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(100, 23);
            maskedTextBox4.TabIndex = 1;
            maskedTextBox4.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 20);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 0;
            label10.Text = " Senha:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Location = new Point(35, 521);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Situação do Cliente";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            checkBox2.Location = new Point(32, 47);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(89, 19);
            checkBox2.TabIndex = 0;
            checkBox2.Text = " Bloqueado:";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(35, 243);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 272);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações Pessoais";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(219, 95);
            maskedTextBox3.Mask = "00/00/0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(100, 23);
            maskedTextBox3.TabIndex = 10;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(219, 77);
            label9.Name = "label9";
            label9.Size = new Size(117, 15);
            label9.TabIndex = 9;
            label9.Text = "Data de Nascimento:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Feminino", "Masculino", "Outro" });
            comboBox2.Location = new Point(219, 39);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(219, 20);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 7;
            label8.Text = "Gênero:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(17, 191);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(61, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Isento:";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(14, 150);
            maskedTextBox2.Mask = " ###.###.###-###";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 132);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 4;
            label7.Text = "Inscrição Estadual:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(14, 93);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 75);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 2;
            label6.Text = "CPF/CNPJ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 21);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 1;
            label5.Text = "Tipo de Pessoa:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Física", "Jurídica" });
            comboBox1.Location = new Point(12, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // date
            // 
            date.Location = new Point(35, 202);
            date.Mask = "00/00/0000";
            date.Name = "date";
            date.Size = new Size(100, 23);
            date.TabIndex = 22;
            date.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 184);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 21;
            label4.Text = "Data de Cadastro:";
            // 
            // tel_client
            // 
            tel_client.Location = new Point(35, 146);
            tel_client.Mask = "(99) 00000-0000";
            tel_client.Name = "tel_client";
            tel_client.Size = new Size(100, 23);
            tel_client.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 128);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 19;
            label3.Text = " Telefone:";
            // 
            // email_client
            // 
            email_client.Location = new Point(35, 93);
            email_client.MaxLength = 150;
            email_client.Name = "email_client";
            email_client.Size = new Size(280, 23);
            email_client.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 75);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 17;
            label2.Text = " E-Mail:";
            // 
            // name_client
            // 
            name_client.Location = new Point(35, 37);
            name_client.MaxLength = 150;
            name_client.Name = "name_client";
            name_client.Size = new Size(280, 23);
            name_client.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 19);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 15;
            label1.Text = " Nome do Cliente/Razão Social:";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 738);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(date);
            Controls.Add(label4);
            Controls.Add(tel_client);
            Controls.Add(label3);
            Controls.Add(email_client);
            Controls.Add(label2);
            Controls.Add(name_client);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Editar Cliente";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private MaskedTextBox maskedTextBox5;
        private Label label11;
        private MaskedTextBox maskedTextBox4;
        private Label label10;
        private GroupBox groupBox2;
        private CheckBox checkBox2;
        private GroupBox groupBox1;
        private MaskedTextBox maskedTextBox3;
        private Label label9;
        private ComboBox comboBox2;
        private Label label8;
        private CheckBox checkBox1;
        private MaskedTextBox maskedTextBox2;
        private Label label7;
        private MaskedTextBox maskedTextBox1;
        private Label label6;
        private Label label5;
        private ComboBox comboBox1;
        private MaskedTextBox date;
        private Label label4;
        private MaskedTextBox tel_client;
        private Label label3;
        private TextBox email_client;
        private Label label2;
        private TextBox name_client;
        private Label label1;
    }
}