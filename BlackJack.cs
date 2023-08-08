namespace BlackJackGame
{
    public static class BlackJack
    {
        //Essa classe devera ser usada para controlar o jogo BlackJack.


        public static void PlayBlackJack()
        {
            bool executando = true, executandoComprarCartas = true;
            int carta1PlayerDois, carta2PlayerDois, somaPlayerDois;
            int carta1PlayerUm, carta2PlayerUm, somaPlayerUm, newCardPlayerUm;
            Random random = new Random();



            Console.WriteLine("Bem vindo ao BlackJack");
            Console.WriteLine("");
            Console.WriteLine("Voce sera o jogador 1 e seu oponente sera o jogador 2.");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("");

            while(executando)
            {
                carta1PlayerDois = random.Next(1,11);
                carta2PlayerDois = random.Next(1,11);
                somaPlayerDois = (carta1PlayerDois + carta2PlayerDois);

                carta1PlayerUm = random.Next(1,11);
                carta2PlayerUm = random.Next(1,11);
                somaPlayerUm = (carta1PlayerUm + carta2PlayerUm);
                
                string decisaoPlayerUm = "";

                Console.WriteLine("");
                Console.WriteLine("Iniciando um novo jogo...");
                Console.WriteLine("");
                Console.WriteLine("Jogador 2 | Carta um: " + carta1PlayerDois + " | Carta dois: ? | Total: " + carta1PlayerDois);
                Console.WriteLine("Aperte qualquer tecla para continuar");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("Jogador 1 | Carta um: " + carta1PlayerUm + " | Carta dois: " + carta2PlayerUm + " | Total: " + somaPlayerUm);
                Console.WriteLine("Aperte qualquer tecla para continuar");
                Console.ReadKey();
                


                while(executandoComprarCartas == true)
                {
                    mostrarMenuDeAcoes();
                    //O player vai decidir o que fazer
                    decisaoPlayerUm = Console.ReadLine();

                    switch(decisaoPlayerUm)
                    {
                        case "1":
                                //Vai comprar cartas
                                newCardPlayerUm = random.Next(1,11);//Vai gerar a nova carta da rodada
                                somaPlayerUm = (somaPlayerUm + newCardPlayerUm);//Vai armanezar todas as cartas anteriores
                                Console.WriteLine("Jogador 1 | Carta um: " + carta1PlayerUm + " | Carta dois: " + carta2PlayerUm + " | Nova carta: " + newCardPlayerUm + " | Total: " + somaPlayerUm);

                                    
                                    if(somaPlayerUm > 21)
                                    {
                                        Console.WriteLine("O deck estourou. Vc perdeu.");
                                        Console.WriteLine("Jogador 2 | Carta um: " + carta1PlayerDois + " | Carta dois: " + carta2PlayerDois +" | Total: " + somaPlayerDois);


                                        Console.WriteLine("Finalizando o jogo.");
                                        executandoComprarCartas = false;
                                        executando = false;
                                        //Vai finalizar o game

                                    }else if(somaPlayerUm == 21)
                                    {
                                        Console.WriteLine("Vc tem 21. Temos que calcular se ganhou ou perdeu");
                                        executandoComprarCartas = false;
                                        executando = false;
                                        
                                    } else if (somaPlayerUm < 21)
                                    {
                                        Console.WriteLine("Vc tem menos de 21.");
                                        Console.WriteLine("Precione qualquer tecla para continuar");
                                        Console.ReadKey();
                                    }


                        break;
                        case "2":
                            //Vc vai passar a rodada, deixando o player 2 decidir.
                            //Aqui devera ficar um robô que entende apenas a primeira carta do player 1
                            //E tenta criar o melhor deck possível.
                            Console.WriteLine("Estamos em 2");

                        break;
                        case "3":
                            Console.WriteLine("Estamos em 3");
                        break;
                        default:
                            Console.WriteLine("Valor nao encontrado.");
                        break;
                    }
                    
                }
                
                    
                



                
            }



        }


        public static void mostrarMenuDeAcoes()
        {
            Console.WriteLine("");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Comprar mais uma carta");
            Console.WriteLine("2 - Desistir");
            Console.WriteLine("3 - Dobrar aposta e comprar última carta");
            Console.WriteLine("Aperte alguma das teclas para continuar");
            Console.WriteLine("");
        }
        

    }
}