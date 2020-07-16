using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_com_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // carrega contatos 
            L_Geral.ConstroiLista();
            ConstroiLista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Application.Exit();
        }

        private void ConstroiLista()
        {
            string[] word = { "1", "2", "3", "4", "5", "6" };
            for(int i = 0; i < 6; i++)
            {
                groupBox1.Controls["textBox" + word[i]].Text = "";
            }
            foreach(L_Dados l_dados in L_Geral.LISTA_CONTATOS)
            {

                /*for (int i = 0; i < 6; i++)
                {
                    groupBox1.Controls["textBox" + word[i]].Text = l_dados.nome;
                }*/

                textBox1.Text = l_dados.nome;
                textBox2.Text = l_dados.numero;
                textBox3.Text = l_dados.nome1;
                textBox4.Text = l_dados.numero1;
                textBox5.Text = l_dados.nome2;
                textBox6.Text = l_dados.numero2;
            }
            
        }
    }
}
