using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_com_BD
{
    public static class L_Geral
    {
       public static List<L_Dados> LISTA_CONTATOS;

       public static void ConstroiLista()
        {
           // verifica se o ficheiro existe

            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\ficheiro_contatos.txt";

            LISTA_CONTATOS = new List<L_Dados>();

            if (File.Exists(nome_ficheiro))
            {
                 StreamReader ficheiro = new StreamReader(nome_ficheiro, Encoding.Default);
               // LISTA_CONTATOS = new List<L_Dados>();

                while (!ficheiro.EndOfStream)
                {
                    string nome = ficheiro.ReadLine(); // carrega nome 
                    string numero = ficheiro.ReadLine();
                    string nome1 = ficheiro.ReadLine(); // carrega nome 
                    string numero1 = ficheiro.ReadLine();
                    string nome2 = ficheiro.ReadLine(); // carrega nome 
                    string numero2 = ficheiro.ReadLine();// carrega numero

                    // adiciona a lista de contatos o contato carregado
                    L_Dados novo_dado = new L_Dados();
                    novo_dado.nome = nome;
                    novo_dado.numero = numero;
                    novo_dado.nome1 = nome1;
                    novo_dado.numero1 = numero1;
                    novo_dado.nome2 = nome2;
                    novo_dado.numero2 = numero2;

                    LISTA_CONTATOS.Add(novo_dado);

                }
                ficheiro.Dispose();

            }
        }

    }

    
}
