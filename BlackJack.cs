namespace BlackJackGame
{
    public static class BlackJack
    {
        //Essa classe devera ser usada para controlar o jogo BlackJack.


        public static void PlayBlackJack()
        {
            bool executando = true, player1Comprando = true;
            int carta1PlayerDois, carta2PlayerDois, somaPlayerDois, newCardPlayerDois = 0;
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
                


                while(player1Comprando == true)
                {
                    
                    
                    bool player2Comprando = true;//define se o player 2 esta comprando cartas no momento

                    if(player2Comprando == false)
                    {
                        mostrarMenuDeAcoesTermino();//Vai mostrar as opcoes de fim de jogo
                    }else
                    {
                        mostrarMenuDeAcoes();//Vai mostrar as opcoes a cada rodada
                    }

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
                                        player1Comprando = false;
                                        executando = false;
                                        //Vai finalizar o game

                                    }else if(somaPlayerUm == 21)
                                    {
                                        if(somaPlayerDois < somaPlayerUm)
                                        {
                                            Console.WriteLine("Blackjack! Vc tem 21. Vc ganhou!");
                                            
                                        }
                                        
                                        Console.WriteLine("Finalizando o jogo.");
                                        player1Comprando = false;
                                        executando = false;
                                        //Vai finalizar o game
                                        
                                    } else if (somaPlayerUm < 21)
                                    {
                                        Console.WriteLine("Vc tem menos de 21.");
                                        Console.WriteLine("Precione qualquer tecla para continuar");
                                        Console.ReadKey();
                                    }


                        break;
                        case "2":
                            //Vc vai passar a rodada, deixando o player 2 decidir.
                            //Esse robô vai entender quanto no total o player 2 tem e deve tentar estar
                            //com mais pontos do que ele e tmb nao ultrapassar o 21.
                            //ou seja somaPlayerUm <= 21 && somaPlayerDois <= 21
                            //E tenta criar o melhor deck possível.

                            Console.WriteLine("Voce desistiu. Agora é a vez do player 2.");
                            Console.WriteLine("");
                            

                            
                            while(somaPlayerDois <= 21 && player2Comprando == true)
                            {
                                    //vai comprar mais uma carta
                                    newCardPlayerDois = random.Next(1,11);//Vai gerar a nova carta da rodada
                                    somaPlayerDois = (somaPlayerDois + newCardPlayerDois);//Vai armanezar todas as cartas anteriores
                                    Console.WriteLine("Jogador 2 | Carta um: " + carta1PlayerDois + " | Carta dois: " + carta2PlayerDois + " | Nova carta: " + newCardPlayerDois + " | Total: " + somaPlayerDois);
                                    Console.WriteLine("");
                                    
                                    if(somaPlayerDois >= 20 && somaPlayerDois <= 21)//Vai parar de comprar cartas quando se chegar nesse limite
                                    {
                                        //vai parar de comprar cartas
                                        Console.WriteLine("");
                                        Console.WriteLine("Finalizando o jogo.");
                                        player2Comprando = false;
                                        player1Comprando = false;
                                        executando = false;
                                        //Vai finalizar o game

                                    }else if(somaPlayerDois > 21)//Vai parar de comprar cartas caso estrapole o limite de 21
                                    {
     
                                        //vai parar de comprar cartas
                                        Console.WriteLine("");
                                        Console.WriteLine("Finalizando o jogo.");
                                        player2Comprando = false;
                                        player1Comprando = false;
                                        executando = false;
                                        //Vai finalizar o game
                                    }

                                    if(somaPlayerDois > somaPlayerUm && somaPlayerDois < 22)//Vai definir se o player 2 ganhou do player 1 se ele for maior do que o player 1 e menor ou igual a 21
                                    {
                                        Console.WriteLine("Player 2 ganhou.");
                                        //vai parar de comprar cartas
                                        Console.WriteLine("");
                                        Console.WriteLine("Finalizando o jogo.");
                                        player2Comprando = false;
                                        player1Comprando = false;
                                        executando = false;
                                        //Vai finalizar o game
                                    }else if(somaPlayerDois < somaPlayerUm && somaPlayerUm <= 21) //Vai dizer se o player 1 ganhou ou nao
                                    {
                                        Console.WriteLine("Vc ganhou.");
                                        //vai parar de comprar cartas
                                        Console.WriteLine("");
                                        Console.WriteLine("Finalizando o jogo.");
                                        player2Comprando = false;
                                        player1Comprando = false;
                                        executando = false;
                                        //Vai finalizar o game
                                    }else if(somaPlayerDois == somaPlayerUm)//Vai definir quando ha empate
                                    {
                                        Console.WriteLine("Empate");
                                        //vai parar de comprar cartas
                                        Console.WriteLine("");
                                        Console.WriteLine("Finalizando o jogo.");
                                        player2Comprando = false;
                                        player1Comprando = false;
                                        executando = false;
                                        //Vai finalizar o game
                                    }

                                    /*
                                    else if(somaPlayerDois >=12 && somaPlayerDois <=16)
                                    {
                                        if(somaPlayerUm > somaPlayerDois)
                                        {
                                            newCardPlayerDois = random.Next(1,11);//Vai gerar a nova carta da rodada
                                            somaPlayerDois = (somaPlayerDois + newCardPlayerDois);//Vai armanezar todas as cartas anteriores
                                            Console.WriteLine("Jogador 2 | Carta um: " + carta1PlayerDois + " | Carta dois: " + carta2PlayerDois + " | Nova carta: " + newCardPlayerDois + " | Total: " + somaPlayerDois);
                                            Console.WriteLine("");
                                        }else
                                        {
                                            //provavelmente estamos ganhando, entao paramos por aqui.
                                            player2Comprando = false;
                                        }

                                    }else if(somaPlayerDois >=17 && somaPlayerDois <=20)
                                    {
                                        //So vai comprar cartas novas se o player 1 estiver com mais pontos
                                        //Entao o sistema vai tentar entender quanto o jogador 1 tem e vai tentar comprar
                                        //novas cartas ate conseguir superar o jogador 1
                                        if(somaPlayerUm > somaPlayerDois)
                                        {
                                            newCardPlayerDois = random.Next(1,11);//Vai gerar a nova carta da rodada
                                            somaPlayerDois = (somaPlayerDois + newCardPlayerDois);//Vai armanezar todas as cartas anteriores
                                            Console.WriteLine("Jogador 2 | Carta um: " + carta1PlayerDois + " | Carta dois: " + carta2PlayerDois + " | Nova carta: " + newCardPlayerDois + " | Total: " + somaPlayerDois);
                                            Console.WriteLine("");
                                        }else
                                        {
                                            //provavelmente estamos ganhando, entao paramos por aqui.
                                            player2Comprando = false;
                                        }


                                    //ate aqui vai controlar a compra de cartas
                                    //A partir daqui vai calcular o que fazer de acordo com os pontos
                                    }
                                    
                                    if(somaPlayerDois > 21 && somaPlayerUm <= 21){

                                        Console.WriteLine("O jogador 2 estourou o deck. Voce ganhou.");
                                        player2Comprando = false;
                                        Console.WriteLine("Finalizando o jogo.");
                                        player1Comprando = false;
                                        executando = false;
                                        //Vai finalizar o game
                                    }
                                    else if(somaPlayerDois == 21)
                                    {
                                        if(somaPlayerDois == somaPlayerUm)
                                        {
                                            Console.WriteLine("Empate!");
                                            player2Comprando = false;
                                            Console.WriteLine("Finalizando o jogo.");
                                            player1Comprando = false;
                                            executando = false;
                                            //Vai finalizar o game
                                        } 
                                        
                                    }else if(somaPlayerDois > somaPlayerUm)
                                    {
                                        Console.WriteLine("Player 2 ganhou!");
                                        Console.WriteLine("Jogador 2 | Carta um: " + carta1PlayerDois + " | Carta dois: " + carta2PlayerDois + " | Nova carta: " + newCardPlayerDois + " | Total: " + somaPlayerDois);

                                        
                                        player2Comprando = false;
                                        Console.WriteLine("Finalizando o jogo.");
                                        player1Comprando = false;
                                        executando = false;
                                        //Vai finalizar o game

                                    }else if(somaPlayerUm > somaPlayerDois)
                                    {
                                        Console.WriteLine("Player 1 ganhou!");
                                        player2Comprando = false;
                                        Console.WriteLine("Finalizando o jogo.");
                                        player1Comprando = false;
                                        executando = false;
                                        //Vai finalizar o game
                                    }
                                        */

                                    
                            }


                        break;
                        case "3":
                            Console.WriteLine("Estamos em 3");
                            Console.WriteLine("Esta opcao esta em construcao");
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

        public static void mostrarMenuDeAcoesTermino()
        {
            Console.WriteLine("");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("4 - Sair do jogo");
            Console.WriteLine("2 - Recomeçar outro jogo");
            Console.WriteLine("Aperte alguma das teclas para continuar");
            Console.WriteLine("");
        }
        
        public static void DecideJogoPlayer2(int somaPlayer1, int somaPlayer2, bool decisaoPlayerDoisV2)
        {
            //Calculara a jogada do player 2.    

            


        }

    }
}