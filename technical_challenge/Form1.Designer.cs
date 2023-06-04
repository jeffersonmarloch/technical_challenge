namespace technical_challenge;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        bt_add_client = new Button();
        label1 = new Label();
        button2 = new Button();
        fontDialog1 = new FontDialog();
        fontDialog2 = new FontDialog();
        gb_filter = new GroupBox();
        button3 = new Button();
        button1 = new Button();
        comboBox1 = new ComboBox();
        label6 = new Label();
        dateTimePicker1 = new DateTimePicker();
        label5 = new Label();
        label4 = new Label();
        textBox3 = new TextBox();
        textBox2 = new TextBox();
        label3 = new Label();
        txt_name = new TextBox();
        label2 = new Label();
        list_clients = new ListView();
        gb_filter.SuspendLayout();
        SuspendLayout();
        // 
        // bt_add_client
        // 
        bt_add_client.Location = new Point(502, 23);
        bt_add_client.Name = "bt_add_client";
        bt_add_client.Size = new Size(124, 23);
        bt_add_client.TabIndex = 0;
        bt_add_client.Text = "Adicionar Cliente";
        bt_add_client.UseVisualStyleBackColor = true;
        bt_add_client.Click += button1_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(21, 25);
        label1.Name = "label1";
        label1.Size = new Size(475, 15);
        label1.TabIndex = 1;
        label1.Text = "Consulte os seus Clientes cadastrados na sua Loja ou realize o cadastro de novos Clientes";
        // 
        // button2
        // 
        button2.Location = new Point(21, 164);
        button2.Name = "button2";
        button2.Size = new Size(75, 23);
        button2.TabIndex = 2;
        button2.Text = "Filtrar";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // gb_filter
        // 
        gb_filter.Controls.Add(button3);
        gb_filter.Controls.Add(button1);
        gb_filter.Controls.Add(comboBox1);
        gb_filter.Controls.Add(label6);
        gb_filter.Controls.Add(dateTimePicker1);
        gb_filter.Controls.Add(label5);
        gb_filter.Controls.Add(label4);
        gb_filter.Controls.Add(textBox3);
        gb_filter.Controls.Add(textBox2);
        gb_filter.Controls.Add(label3);
        gb_filter.Controls.Add(txt_name);
        gb_filter.Controls.Add(label2);
        gb_filter.Location = new Point(125, 52);
        gb_filter.Name = "gb_filter";
        gb_filter.Size = new Size(593, 135);
        gb_filter.TabIndex = 5;
        gb_filter.TabStop = false;
        gb_filter.Text = "Realizar filtro";
        gb_filter.Visible = false;
        // 
        // button3
        // 
        button3.Location = new Point(457, 92);
        button3.Name = "button3";
        button3.Size = new Size(89, 23);
        button3.TabIndex = 13;
        button3.Text = "Aplicar filtros";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button1
        // 
        button1.Location = new Point(342, 92);
        button1.Name = "button1";
        button1.Size = new Size(91, 23);
        button1.TabIndex = 12;
        button1.Text = "Limpar filtros";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click_1;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Sim", "Não" });
        comboBox1.Location = new Point(360, 40);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(54, 23);
        comboBox1.TabIndex = 11;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(360, 22);
        label6.Name = "label6";
        label6.Size = new Size(107, 15);
        label6.TabIndex = 10;
        label6.Text = "Cliente bloqueado:";
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Format = DateTimePickerFormat.Short;
        dateTimePicker1.Location = new Point(226, 90);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(100, 23);
        dateTimePicker1.TabIndex = 9;
        dateTimePicker1.Value = new DateTime(2023, 6, 3, 0, 0, 0, 0);
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(226, 72);
        label5.Name = "label5";
        label5.Size = new Size(100, 15);
        label5.TabIndex = 8;
        label5.Text = "Data de Cadastro:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(226, 22);
        label4.Name = "label4";
        label4.Size = new Size(54, 15);
        label4.TabIndex = 7;
        label4.Text = "Telefone:";
        // 
        // textBox3
        // 
        textBox3.Location = new Point(226, 40);
        textBox3.Name = "textBox3";
        textBox3.PlaceholderText = "Telefone do Cliente";
        textBox3.Size = new Size(111, 23);
        textBox3.TabIndex = 6;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(9, 90);
        textBox2.Name = "textBox2";
        textBox2.PlaceholderText = "E-mail do Cliente";
        textBox2.Size = new Size(199, 23);
        textBox2.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(9, 72);
        label3.Name = "label3";
        label3.Size = new Size(44, 15);
        label3.TabIndex = 4;
        label3.Text = "E-mail:";
        // 
        // txt_name
        // 
        txt_name.Location = new Point(8, 40);
        txt_name.Name = "txt_name";
        txt_name.PlaceholderText = "Nome ou Razão Social do Cliente";
        txt_name.Size = new Size(200, 23);
        txt_name.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(6, 19);
        label2.Name = "label2";
        label2.Size = new Size(113, 15);
        label2.TabIndex = 2;
        label2.Text = "Nome/Razão Social:";
        // 
        // list_clients
        // 
        list_clients.Location = new Point(21, 206);
        list_clients.Name = "list_clients";
        list_clients.Size = new Size(788, 332);
        list_clients.TabIndex = 6;
        list_clients.UseCompatibleStateImageBehavior = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(850, 565);
        Controls.Add(list_clients);
        Controls.Add(gb_filter);
        Controls.Add(button2);
        Controls.Add(label1);
        Controls.Add(bt_add_client);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "Form1";
        Text = "Clientes";
        Load += Form1_Load;
        gb_filter.ResumeLayout(false);
        gb_filter.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button bt_add_client;
    private Label label1;
    private Button button2;
    private FontDialog fontDialog1;
    private FontDialog fontDialog2;
    private GroupBox gb_filter;
    private TextBox txt_name;
    private Label label2;
    private TextBox textBox2;
    private Label label3;
    private Label label4;
    private TextBox textBox3;
    private DateTimePicker dateTimePicker1;
    private Label label5;
    private ComboBox comboBox1;
    private Label label6;
    private Button button1;
    private Button button3;
    private ListView list_clients;
}
