//Hey, hoje quero começar a registrar um pouco do meu progresso estudando C# .NET framework.
//Hoje vou construir uma coisa que eu sempre quis fazer que é um menuzinho por linha de comando 

//So pra registrar, já estudo o C# tem 1 ano. Mas eu sempre foquei em games, pra Unity.
//Como já estou no 5º período da faculdade de games e ainda não consegui trampo, vou migrar para ADS
//E aproveitar que já manjo um pouco da linguagem e tentar fazer um portfolio e tentar conseguir um trampo pq ta foda kkkkkk

//Ok, bora começar a codar.

using System;
using FuncoesDoMenu;

namespace HelloWorldV2
{
    public class ProgramMenu
    {
        
        public static void Main(string[] args)
        {
            //MostrarMenu();

            bool executando = true;
            string entrada = "teste";
            
            Console.WriteLine("Estamos entrando no looping While...");
            MostrarMenu();
            while(executando)
            
            {

               
                entrada = Console.ReadLine();

                switch(entrada)
                {
                    case "1":
                        Console.WriteLine("Entrada 1 valida");
                        Console.WriteLine(".");
                        Console.WriteLine(".");
                        Console.WriteLine(".");
                        Funcoes.Game();
                        Console.WriteLine("Jogo executado com sucesso.");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey();
                        MostrarMenu();

                    break;
                    case "2":
                        Console.WriteLine("Entrada 2 valida");
                        Console.WriteLine(".");
                        Console.WriteLine(".");
                        Console.WriteLine(".");
                        Funcoes.Configuracoes();
                        Console.WriteLine("Jogo configurado com sucesso.");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                        Console.ReadKey();
                        MostrarMenu();
                    break;
                    case "3":
                        Console.WriteLine("Entrada 3 valida");
                        Console.WriteLine(".");
                        Console.WriteLine(".");
                        Console.WriteLine(".");
                        Console.WriteLine("Jogo finalizado com sucesso.");
                        
                        executando = false;

                    break;
                    default:
                        Console.WriteLine("Nenhuma entrada valida. Por favor verifique a entrada.");
                        Console.WriteLine("Algum valor entre 1 e 3 deve ser inserido.");
                        MostrarMenu();

                    break;
                }

            }


        }

        public static void MostrarMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--Menu Principal--");
            Console.WriteLine("--Escolha uma das opcoes abaixo--");
            Console.WriteLine("1 - Jogar jogo");
            Console.WriteLine("2 - Configuracoes");
            Console.WriteLine("3 - Sair do jogo");
            Console.WriteLine("Escolha um numero valido a seguir:");
           

        }


    }

   
}

//Agora vou tentar aumentar a complexidade desse codigo...
//Vou tentar criar outros scripts que fazem as funcoes desse menu separadamente
//Vou tentar criar alguma especie de joguinho para praticar

//Deu certo! Temos que importar o namespace para conseguir dar certo.