namespace technical_challenge
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            name_client = new TextBox();
            label2 = new Label();
            email_client = new TextBox();
            label3 = new Label();
            tel_client = new MaskedTextBox();
            toolTip2 = new ToolTip(components);
            cbx_personal_type = new ComboBox();
            txt_document = new MaskedTextBox();
            txt_state_registry = new MaskedTextBox();
            cbx_gender = new ComboBox();
            date_of_birth = new MaskedTextBox();
            cbx_is_blocked = new CheckBox();
            label4 = new Label();
            date_registry = new MaskedTextBox();
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            toolTip5 = new ToolTip(components);
            groupBox1 = new GroupBox();
            lbl_date_of_birth = new Label();
            lbl_gender = new Label();
            cbx_free_state_registry = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            txt_confirmation_pass = new MaskedTextBox();
            label11 = new Label();
            txt_client_password = new MaskedTextBox();
            label10 = new Label();
            btn_add_client = new Button();
            btn_return = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 15);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 0;
            label1.Text = " Nome do Cliente/Razão Social:";
            // 
            // name_client
            // 
            name_client.Location = new Point(33, 33);
            name_client.MaxLength = 150;
            name_client.Name = "name_client";
            name_client.Size = new Size(280, 23);
            name_client.TabIndex = 1;
            toolTip2.SetToolTip(name_client, "Nome completo ou Razão Social do Cliente");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 71);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = " E-Mail:";
            // 
            // email_client
            // 
            email_client.Location = new Point(33, 89);
            email_client.MaxLength = 150;
            email_client.Name = "email_client";
            email_client.Size = new Size(280, 23);
            email_client.TabIndex = 3;
            toolTip2.SetToolTip(email_client, "E-mail do Cliente.");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 124);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = " Telefone:";
            // 
            // tel_client
            // 
            tel_client.Location = new Point(33, 142);
            tel_client.Mask = "(99) 00000-0000";
            tel_client.Name = "tel_client";
            tel_client.Size = new Size(100, 23);
            tel_client.TabIndex = 6;
            toolTip2.SetToolTip(tel_client, "Telefone do Cliente.");
            // 
            // toolTip2
            // 
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            // 
            // cbx_personal_type
            // 
            cbx_personal_type.FormattingEnabled = true;
            cbx_personal_type.Items.AddRange(new object[] { "Física", "Jurídica" });
            cbx_personal_type.Location = new Point(12, 39);
            cbx_personal_type.Name = "cbx_personal_type";
            cbx_personal_type.Size = new Size(121, 23);
            cbx_personal_type.TabIndex = 0;
            toolTip2.SetToolTip(cbx_personal_type, "Selecione o tipo de Pessoa");
            cbx_personal_type.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txt_document
            // 
            txt_document.Location = new Point(14, 93);
            txt_document.Name = "txt_document";
            txt_document.Size = new Size(100, 23);
            txt_document.TabIndex = 3;
            toolTip2.SetToolTip(txt_document, "CPF ou o CNPJ do Cliente.");
            txt_document.MaskInputRejected += maskedTextBox1_MaskInputRejected_1;
            // 
            // txt_state_registry
            // 
            txt_state_registry.Location = new Point(14, 150);
            txt_state_registry.Mask = " ###.###.###-###";
            txt_state_registry.Name = "txt_state_registry";
            txt_state_registry.Size = new Size(100, 23);
            txt_state_registry.TabIndex = 5;
            toolTip2.SetToolTip(txt_state_registry, " Inscrição Estadual do Cliente, selecionar Isento caso assim for.");
            // 
            // cbx_gender
            // 
            cbx_gender.FormattingEnabled = true;
            cbx_gender.Items.AddRange(new object[] { "Feminino", "Masculino", "Outro" });
            cbx_gender.Location = new Point(219, 39);
            cbx_gender.Name = "cbx_gender";
            cbx_gender.Size = new Size(121, 23);
            cbx_gender.TabIndex = 8;
            toolTip2.SetToolTip(cbx_gender, "Selecione o gênero do Cliente.");
            // 
            // date_of_birth
            // 
            date_of_birth.Location = new Point(219, 95);
            date_of_birth.Mask = "00/00/0000";
            date_of_birth.Name = "date_of_birth";
            date_of_birth.Size = new Size(100, 23);
            date_of_birth.TabIndex = 10;
            toolTip2.SetToolTip(date_of_birth, "Data de nascimento do Cliente.");
            date_of_birth.ValidatingType = typeof(DateTime);
            // 
            // cbx_is_blocked
            // 
            cbx_is_blocked.AutoSize = true;
            cbx_is_blocked.CheckAlign = ContentAlignment.MiddleRight;
            cbx_is_blocked.Location = new Point(32, 47);
            cbx_is_blocked.Name = "cbx_is_blocked";
            cbx_is_blocked.Size = new Size(89, 19);
            cbx_is_blocked.TabIndex = 0;
            cbx_is_blocked.Text = " Bloqueado:";
            toolTip2.SetToolTip(cbx_is_blocked, " Bloqueio o acesso do Cliente na sua Loja");
            cbx_is_blocked.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 180);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 8;
            label4.Text = "Data de Cadastro:";
            // 
            // date_registry
            // 
            date_registry.Enabled = false;
            date_registry.Location = new Point(33, 198);
            date_registry.Mask = "00/00/0000";
            date_registry.Name = "date_registry";
            date_registry.Size = new Size(100, 23);
            date_registry.TabIndex = 9;
            date_registry.ValidatingType = typeof(DateTime);
            date_registry.MaskInputRejected += date_MaskInputRejected;
            // 
            // toolTip3
            // 
            toolTip3.ToolTipIcon = ToolTipIcon.Info;
            // 
            // toolTip4
            // 
            toolTip4.ToolTipIcon = ToolTipIcon.Info;
            // 
            // toolTip5
            // 
            toolTip5.ToolTipIcon = ToolTipIcon.Info;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(date_of_birth);
            groupBox1.Controls.Add(lbl_date_of_birth);
            groupBox1.Controls.Add(cbx_gender);
            groupBox1.Controls.Add(lbl_gender);
            groupBox1.Controls.Add(cbx_free_state_registry);
            groupBox1.Controls.Add(txt_state_registry);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txt_document);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbx_personal_type);
            groupBox1.Location = new Point(33, 239);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 272);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações Pessoais";
            // 
            // lbl_date_of_birth
            // 
            lbl_date_of_birth.AutoSize = true;
            lbl_date_of_birth.Location = new Point(219, 77);
            lbl_date_of_birth.Name = "lbl_date_of_birth";
            lbl_date_of_birth.Size = new Size(117, 15);
            lbl_date_of_birth.TabIndex = 9;
            lbl_date_of_birth.Text = "Data de Nascimento:";
            // 
            // lbl_gender
            // 
            lbl_gender.AutoSize = true;
            lbl_gender.Location = new Point(219, 20);
            lbl_gender.Name = "lbl_gender";
            lbl_gender.Size = new Size(48, 15);
            lbl_gender.TabIndex = 7;
            lbl_gender.Text = "Gênero:";
            // 
            // cbx_free_state_registry
            // 
            cbx_free_state_registry.AutoSize = true;
            cbx_free_state_registry.CheckAlign = ContentAlignment.MiddleRight;
            cbx_free_state_registry.Location = new Point(17, 191);
            cbx_free_state_registry.Name = "cbx_free_state_registry";
            cbx_free_state_registry.Size = new Size(61, 19);
            cbx_free_state_registry.TabIndex = 6;
            cbx_free_state_registry.Text = "Isento:";
            cbx_free_state_registry.UseVisualStyleBackColor = true;
            cbx_free_state_registry.CheckedChanged += cbx_free_state_registry_CheckedChanged;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(cbx_is_blocked);
            groupBox2.Location = new Point(33, 517);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Situação do Cliente";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_confirmation_pass);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txt_client_password);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(271, 517);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 133);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Senha de Acesso";
            // 
            // txt_confirmation_pass
            // 
            txt_confirmation_pass.Location = new Point(21, 90);
            txt_confirmation_pass.Name = "txt_confirmation_pass";
            txt_confirmation_pass.Size = new Size(100, 23);
            txt_confirmation_pass.TabIndex = 3;
            txt_confirmation_pass.UseSystemPasswordChar = true;
            txt_confirmation_pass.Leave += txt_confirmation_pass_Leave;
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
            // txt_client_password
            // 
            txt_client_password.Location = new Point(21, 37);
            txt_client_password.Name = "txt_client_password";
            txt_client_password.Size = new Size(100, 23);
            txt_client_password.TabIndex = 1;
            txt_client_password.UseSystemPasswordChar = true;
            txt_client_password.MaskInputRejected += txt_client_password_MaskInputRejected;
            txt_client_password.Leave += txt_client_password_Leave;
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
            // btn_add_client
            // 
            btn_add_client.Location = new Point(352, 700);
            btn_add_client.Name = "btn_add_client";
            btn_add_client.Size = new Size(119, 23);
            btn_add_client.TabIndex = 13;
            btn_add_client.Text = "Adicionar Cliente";
            btn_add_client.UseVisualStyleBackColor = true;
            btn_add_client.Click += button1_Click;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(238, 700);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(75, 23);
            btn_return.TabIndex = 14;
            btn_return.Text = "Voltar";
            btn_return.UseVisualStyleBackColor = true;
            btn_return.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(511, 746);
            Controls.Add(btn_return);
            Controls.Add(btn_add_client);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(date_registry);
            Controls.Add(label4);
            Controls.Add(tel_client);
            Controls.Add(label3);
            Controls.Add(email_client);
            Controls.Add(label2);
            Controls.Add(name_client);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            Text = "Cadastrar Clientes";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name_client;
        private Label label2;
        private TextBox email_client;
        private Label label3;
        private MaskedTextBox tel_client;
        private ToolTip toolTip2;
        private Label label4;
        private MaskedTextBox date_registry;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private ToolTip toolTip5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btn_add_client;
        private Button btn_return;
        private Label label5;
        private ComboBox cbx_personal_type;
        private MaskedTextBox txt_document;
        private Label label6;
        private Label label7;
        private Label lbl_gender;
        private CheckBox cbx_free_state_registry;
        private MaskedTextBox txt_state_registry;
        private ComboBox cbx_gender;
        private MaskedTextBox date_of_birth;
        private Label lbl_date_of_birth;
        private CheckBox cbx_is_blocked;
        private MaskedTextBox txt_client_password;
        private Label label10;
        private MaskedTextBox txt_confirmation_pass;
        private Label label11;
    }
}