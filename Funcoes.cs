
using BlackJackGame;

namespace FuncoesDoMenu
{
    //Essa classe deve armazenar as funcoes do menu

    public static class Funcoes
    {

        public static void Game()
        {
            //Essa classe sera chamada quando o jogador selecionar '1'

            Console.WriteLine("Estamos dentro de Game()... Vamos jogar BlackJack.");
            Console.WriteLine("88          88                       88        88                       88         ");
            Console.WriteLine("88          88                       88        \"\"                       88         ");
            Console.WriteLine("88          88                       88                                 88         ");
            Console.WriteLine("88,dPPYba,  88 ,adPPYYba,  ,adPPYba, 88   ,d8  88 ,adPPYYba,  ,adPPYba, 88   ,d8   ");
            Console.WriteLine("88P'    \"8a 88 \"\"     `Y8 a8\"     \"\" 88 ,a8\"   88 \"\"     `Y8 a8\"     \"\" 88 ,a8\"    ");
            Console.WriteLine("88       d8 88 ,adPPPPP88 8b         8888[     88 ,adPPPPP88 8b         8888[      ");
            Console.WriteLine("88b,   ,a8\" 88 88,    ,88 \"8a,   ,aa 88`\"Yba,  88 88,    ,88 \"8a,   ,aa 88`\"Yba,   ");
            Console.WriteLine("8Y\"Ybbd8\"'  88 `\"8bbdP\"Y8  `\"Ybbd8\"' 88   `Y8a 88 `\"8bbdP\"Y8  `\"Ybbd8\"' 88   `Y8a  ");
            Console.WriteLine("                                              ,88                                  ");
            Console.WriteLine("                                            888P\"                                  ");


            BlackJack.PlayBlackJack();
        }

        public static void Configuracoes()
        {
            //Essa classe sera chamada quando o jogador selecionar ''

            Console.WriteLine("Estamos dentro de Game()...");

        }


    }



}