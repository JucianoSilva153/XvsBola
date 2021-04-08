using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class nomeJogadores_XO : Form
    {
        public nomeJogadores_XO()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void doisJogadores_XO_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form menu = new XO_menu();
            menu.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" || textBox2.Text != "") {

                Settings1.Default.Jogador1 = textBox1.Text;
                Settings1.Default.Jogador2 = textBox2.Text;

                Form main = new XO_main();
            main.Show();

                this.Hide();
               

            }
            else
            {
                MessageBox.Show("Insira o nome dos Jogadores", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
            }

            
        }
    }
}
