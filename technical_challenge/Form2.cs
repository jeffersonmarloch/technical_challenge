using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;

namespace technical_challenge
{
    public partial class Form2 : Form
    {
        private MySqlConnection Connection;
        private string data_source = "datasource=localhost;username=root;password=123456;database=technical_challenge_db";

        public Form2()
        {
            InitializeComponent();

            date_registry.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now.Date);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void personal_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void date_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form2();
            f.Closed += (s, args) => this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_personal_type.Text == "Jurídica")
            {
                txt_document.Mask = @"00\.000\.000\/0000\-00";

                lbl_gender.Visible = false;
                lbl_date_of_birth.Visible = false;

                cbx_gender.Visible = false;
                date_of_birth.Visible = false;

            }
            else
            {
                txt_document.Mask = @"000\.000\.000\-00";

                lbl_gender.Visible = true;
                lbl_date_of_birth.Visible = true;

                cbx_gender.Visible = true;
                date_of_birth.Visible = true;
            }
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection = new MySqlConnection(data_source);
                Connection.Open();

                MySqlCommand cmd = new MySqlCommand();

                int free_state_registry = cbx_free_state_registry.Checked ? 1 : 0;

                int is_blocked = cbx_is_blocked.Checked ? 1 : 0;

                cmd.Connection = Connection;

                cmd.CommandText = "INSERT INTO client(name, email, " +
                    "telephone, register_date, personal_type, document, state_registry," +
                    " free_state_registry, gender, date_of_birth, is_blocked, client_password) " +
                    "VALUES(@name, @email, @telephone, @register_date, @personal_type, @document, @state_registry, " +
                    "@free_state_registry, @gender, @date_of_birth, @is_blocked, @client_password) ";

                cmd.Parameters.AddWithValue("@name", name_client.Text);
                cmd.Parameters.AddWithValue("@email", email_client.Text);
                cmd.Parameters.AddWithValue("@telephone", tel_client.Text);
                cmd.Parameters.AddWithValue("@register_date", date_registry.Text);
                cmd.Parameters.AddWithValue("@personal_type", cbx_personal_type.Text);
                cmd.Parameters.AddWithValue("@document", txt_document.Text);
                cmd.Parameters.AddWithValue("@state_registry", txt_state_registry.Text);
                cmd.Parameters.AddWithValue("@free_state_registry", free_state_registry);
                cmd.Parameters.AddWithValue("@gender", cbx_gender.Text);
                cmd.Parameters.AddWithValue("@date_of_birth", date_of_birth.Text);
                cmd.Parameters.AddWithValue("@is_blocked", is_blocked);
                cmd.Parameters.AddWithValue("@client_password", txt_client_password.Text);

                cmd.Prepare();


                cmd.ExecuteNonQuery();

                this.Hide();
                Form f = new Form2();
                f.Closed += (s, args) => this.Close();

                MessageBox.Show("Cliente adicionado com sucesso!",
                                "Sucesso!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
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

        private void cbx_free_state_registry_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_free_state_registry.Checked == true)
            {
                txt_state_registry.Enabled = false;
            }
            else
            {
                txt_state_registry.Enabled = true;
            }
        }

        private void txt_client_password_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_client_password_Leave(object sender, EventArgs e)
        {
            if (txt_client_password.TextLength < 8 || txt_client_password.TextLength > 15)
            {
                btn_add_client.Enabled = false;

                MessageBox.Show("A senha não pode ser inferior a 8 e maior do que 15 caracteres!");
            }
            else
            {
                btn_add_client.Enabled = true;
            }
        }

        private void txt_confirmation_pass_Leave(object sender, EventArgs e)
        {
            if (txt_client_password.Text != txt_confirmation_pass.Text)
            {
                btn_add_client.Enabled = false;

                MessageBox.Show("As senhas não conferem!");
            }
            else
            {
                btn_add_client.Enabled = true;
            }
        }
    }
}
