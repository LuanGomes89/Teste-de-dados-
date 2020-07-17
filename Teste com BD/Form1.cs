using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_com_BD
{

    public partial class Form1 : Form
    {
        //=======================================================================================================================//
        public Form1()
        {
            InitializeComponent();

            // carrega contatos 
           L_Geral.ConstroiLista();
          
        

        }
        //=======================================================================================================================//
     
        //=======================================================================================================================//
        // botao de sair
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Application.Exit();
        }
        //=======================================================================================================================//
        private void ConstroiLista() // pega valores da lista que no caso pegou valores de um arquivo existente executado na inicialização do programa
        {
            string[] word = { "1", "2", "3", "4", "5", "6" };
            for (int i = 0; i < 6; i++)
            {
                groupBox1.Controls["textBox" + word[i]].Text = "";
            }
            foreach (L_Dados l_dados in L_Geral.LISTA_CONTATOS)
            {

                /*for (int i = 0; i < 6; i++)
                {
                    groupBox1.Controls["textBox" + word[i]].Text = l_dados.nome;
                }*/

                textBox7.Text = l_dados.nome;
                textBox8.Text = l_dados.numero;
                textBox9.Text = l_dados.nome1;
                textBox10.Text = l_dados.numero1;
                textBox11.Text = l_dados.nome2;
                textBox12.Text = l_dados.numero2;
            }

        }
        //=======================================================================================================================//
        
        // ta de forma equivocada mas ta funcionando ve se o arquivo ja existe se existir retorna um erro
        private void button1_Click(object sender, EventArgs e) //botao salvar
        {

           foreach (L_Dados l_dados in L_Geral.LISTA_CONTATOS)
            {
                string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string nome_ficheiro = pasta_documentos + @"\ficheiro_contatos.txt";

                if (File.Exists(nome_ficheiro))
                {
                    MessageBox.Show("ERRO! Esse registro já existe1."); // 
                    return;
                }

                /* 
                 //dessa forma nao diz se o arquivo existe e sim se no arquivo tem linhas repetidas 

                 if (l_dados.nome == textBox1.Text && l_dados.numero == textBox2.Text)
                 {

                     MessageBox.Show("ERRO! Esse registro já existe1.");
                     return;
                 }
                 if (l_dados.nome1 == textBox3.Text && l_dados.numero1 == textBox4.Text)
                 {

                     MessageBox.Show("ERRO! Esse registro já existe2.");
                     return;
                 }
                 if (l_dados.nome2 == textBox5.Text && l_dados.numero2 == textBox6.Text)
                 {

                     MessageBox.Show("ERRO! Esse registro já existe3.");
                     return;
                 }*/
            }


            L_Geral.GravarNovoRegistro(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);

            ConstroiLista();
        }

        /*private void timer1_Tick(object sender, EventArgs e)
        {
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + L_Geral.texbox ;

            if (File.Exists(nome_ficheiro))
            {
                comboBox1.Items.Add(nome_ficheiro);
                timer1.Enabled = false;
            }
        }*/

        private void button2_Click(object sender, EventArgs e) // imprimir
        {
          
            ConstroiLista();
          
        }                

      
    }
}

