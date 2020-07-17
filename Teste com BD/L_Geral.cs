using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Teste_com_BD
{
    public static class L_Geral
    {

        //=======================================================================================================================//
        // variaveis para ser usadas nos forms
        public static string texbox = "\ficheiro_contatos.txt";
        // variaveis para ser usadas nos forms
        //=======================================================================================================================//


        //=======================================================================================================================//
        // Craia uma lista chamada Lista Contatos
        public static List<L_Dados> LISTA_CONTATOS;
        //=======================================================================================================================//

        // funcão que monta a lista
        public static void ConstroiLista() /* deveria ser LendoArquivo pois ele ve se existe se caso existir ele pegas os dados do 
          arquivo e adiciona a lista do programa .*/
        {
            // verifica se o ficheiro existe

            /*string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
             seta o caminho no pc */
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
           

            /*string string nome_ficheiro = pasta_documentos + @"\ficheiro_contatos.txt";
            seta o caminho no pc + o nome de arquivo */
            string nome_ficheiro = pasta_documentos + @"\ficheiro_contatos.txt";

            LISTA_CONTATOS = new List<L_Dados>();
            
            //se o aquivo existir ele pega cada linha e adiciona a variavel do L_dados 
            if (File.Exists(nome_ficheiro)) // ve se o arquivo existe 
            {
                StreamReader ficheiro = new StreamReader(nome_ficheiro, Encoding.Default);
                //LISTA_CONTATOS = new List<L_Dados>();

                while (!ficheiro.EndOfStream)
                {
                    //obs criar um array na proxima vez
                    string nome = ficheiro.ReadLine(); // 
                    string numero = ficheiro.ReadLine();
                    string nome1 = ficheiro.ReadLine(); //
                    string numero1 = ficheiro.ReadLine();
                    string nome2 = ficheiro.ReadLine(); //
                    string numero2 = ficheiro.ReadLine();//

                    // passa os valores para variaveis da classe L_Dados
                    L_Dados novo_dado = new L_Dados();
                    novo_dado.nome = nome;
                    novo_dado.numero = numero;
                    novo_dado.nome1 = nome1;
                    novo_dado.numero1 = numero1;
                    novo_dado.nome2 = nome2;
                    novo_dado.numero2 = numero2;

                    // adiciona a lista de contatos os contatos carregados
                    LISTA_CONTATOS.Add(novo_dado);

                }
                ficheiro.Dispose();

            }
        }
        //=======================================================================================================================//
        // função para gravar dados 
        public static void GravarNovoRegistro(string _nome, string _numero, string _nome1, string _numero1, string _nome2, string _numero2)
        {
            LISTA_CONTATOS.Add(new L_Dados() { nome = _nome, numero = _numero, nome1 = _nome1, numero1 = _numero1, nome2 = _nome2, numero2 = _numero2 });

            GravarFicheiro();
        }
        //=======================================================================================================================//
        public static void GravarFicheiro()
        {
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\ficheiro_contatos.txt";

            StreamWriter ficheiro = new StreamWriter(nome_ficheiro, false, Encoding.Default);

            foreach (L_Dados l_dados in LISTA_CONTATOS)
            {
                ficheiro.WriteLine(l_dados.nome);
                ficheiro.WriteLine(l_dados.numero);
                ficheiro.WriteLine(l_dados.nome1);
                ficheiro.WriteLine(l_dados.numero1);
                ficheiro.WriteLine(l_dados.nome2);
                ficheiro.WriteLine(l_dados.numero2);
            }
            ficheiro.Dispose();

        }




    }
}


