namespace technical_challenge;
using MySql.Data.MySqlClient;
using System.Xml.Linq;

public partial class Form1 : Form
{
    private MySqlConnection Connection;
    private string data_source = "datasource=localhost;username=root;password=123456;database=technical_challenge_db";

    public Form1()
    {
        InitializeComponent();

        list_clients.View = View.Details;
        list_clients.LabelEdit = true;
        list_clients.AllowColumnReorder = true;
        list_clients.FullRowSelect = true;
        list_clients.GridLines = true;

        list_clients.Columns.Add("ID", 30, HorizontalAlignment.Left);
        list_clients.Columns.Add("Nome", 150, HorizontalAlignment.Left);
        list_clients.Columns.Add("E-mail", 150, HorizontalAlignment.Left);
        list_clients.Columns.Add("Telefone", 15, HorizontalAlignment.Left);
        list_clients.Columns.Add("Data de Cadastro", 10, HorizontalAlignment.Left);
        list_clients.Columns.Add("Tipo de Pessoa", 10, HorizontalAlignment.Left);
        list_clients.Columns.Add("CPF/CNPJ", 14, HorizontalAlignment.Left);
        list_clients.Columns.Add("Inscri��o Estadual", 16, HorizontalAlignment.Left);
        list_clients.Columns.Add("Isento", 3, HorizontalAlignment.Left);
        list_clients.Columns.Add("G�nero", 9, HorizontalAlignment.Left);
        list_clients.Columns.Add("Data de Nascimento", 10, HorizontalAlignment.Left);
        list_clients.Columns.Add("Bloqueado", 3, HorizontalAlignment.Left);
        list_clients.Columns.Add("Senha", 15, HorizontalAlignment.Left);

        loading_clients();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        Form2 form2 = new Form2();
        form2.ShowDialog();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        gb_filter.Visible = true;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        try
        {
            Connection = new MySqlConnection(data_source);
            Connection.Open();

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = Connection;

            cmd.CommandText = "SELECT * FROM client WHERE name LIKE @t_name";

            cmd.Parameters.AddWithValue("@t_name", "%" + txt_name.Text + "%");

            cmd.Prepare();

            MySqlDataReader reader = cmd.ExecuteReader();

            list_clients.Items.Clear();

            while (reader.Read())
            {
                string[] row = {
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6),
                    reader.GetString(7),
                    reader.GetString(8),
                    reader.GetString(9),
                    reader.GetString(10),
                    reader.GetString(11),
                    reader.GetString(12),
                };
                list_clients.Items.Add(new ListViewItem(row));
            };

            gb_filter.Visible = false;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Erro " + ex.Number + "Ocorreu:" + ex.Message,
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            Connection.Close();
        }
    }

    private void loading_clients()
    {
        try
        {
            Connection = new MySqlConnection(data_source);
            Connection.Open();

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = Connection;

            cmd.CommandText = "SELECT * FROM client ORDER BY id ASC";

            cmd.Prepare();

            MySqlDataReader reader = cmd.ExecuteReader();

            list_clients.Items.Clear();

            while (reader.Read())
            {
                string[] row = {
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6),
                    reader.GetString(7),
                    reader.GetString(8),
                    reader.GetString(9),
                    reader.GetString(10),
                    reader.GetString(11),
                    reader.GetString(12),
                };
                list_clients.Items.Add(new ListViewItem(row));
            };

            gb_filter.Visible = false;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Erro " + ex.Number + "Ocorreu:" + ex.Message,
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            Connection.Close();
        }
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        gb_filter.Visible = false;

        txt_name.Text = string.Empty;
        txt_email.Text = string.Empty;
        txt_phone.Text = string.Empty;
        cbx_blocked.Text = string.Empty;
        dateTimePicker1.Text = string.Empty;


        loading_clients();
    }
}
