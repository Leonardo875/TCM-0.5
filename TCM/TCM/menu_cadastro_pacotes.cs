using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCM
{
    public partial class menu_cadastro_pacotes : Form
    {
        public menu_cadastro_pacotes()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm2 = new Form2();
            fm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        DialogResult result = MessageBox.Show("Têm Certeza que quer Cancelar?","???",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes) {

                this.Hide();
                menu_cadastro mncada = new menu_cadastro();
                mncada.Show();
            }

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mn = new menu();
            mn.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            consulta fm4 = new consulta();
            fm4.Show();

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if(textBox4.Text == "Nº do Passaporte")
            {
                textBox4.Text = "";
            }

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Nº do Passaporte";
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Origem";
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Destino da viagem";
            }

        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                textBox11.Text = "Pacotes";
            }


        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Reserva";
            }

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Hotel";
            }

        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                textBox10.Text = "Quartos";
            }

        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Passeio";
            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Ída";
            }

        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Volta";
            }

        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Origem")
            {
                textBox2.Text = "";
            }

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Destino da viagem")
            {
                textBox1.Text = "";
            }
        }

        private void textBox11_Enter(object sender, EventArgs e)
        {
            if (textBox11.Text == "Pacotes")
            {
                textBox11.Text = "";
            }

        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Reserva")
            {
                textBox5.Text = "";
            }

        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Hotel")
            {
                textBox6.Text = "";
            }

        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "Quartos")
            {
                textBox10.Text = "";
            }

        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Passeio")
            {
                textBox8.Text = "";
            }

        }

        private void textBox12_Enter(object sender, EventArgs e)
        {
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Ída")
            {
                textBox3.Text = "";
            }

        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Volta")
            {
                textBox9.Text = "";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {

            textBox1.Text = "Destino da viagem";
            textBox2.Text = "Origem";
            textBox3.Text = "Ída";
            textBox4.Text = "Nº do Passaporte";
            textBox5.Text = "Reserva";
            textBox6.Text = "Hotel";
            textBox8.Text = "Passeio";
            textBox9.Text = "Volta";
            textBox10.Text = "Quartos";
            textBox11.Text = "Pacotes";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            agendamento fm5 = new agendamento();
            fm5.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_cadastro mncada = new menu_cadastro();
            mncada.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            pagamento mnpaga = new pagamento();
            mnpaga.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
