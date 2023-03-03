using System;

namespace tic_tac_toe
{
    internal class Program
    {
        static char[,] playField =

        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };

        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;

            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO('O', input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO('X', input);
                }

                SetField();

                char[] playerChars = { 'X', 'O' };

                foreach (char playerChar in playerChars)
                {
                    if (((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar))
                         || ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar))
                         || ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))
                         || ((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar))
                         || ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 1] == playerChar))
                         || ((playField[0, 2] == playerChar) && (playField[1, 2] == playerChar) && (playField[2, 2] == playerChar))
                         || ((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar))
                         || ((playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar))
                         )
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\nTebrikler. 2.Oyuncu kazandı!");
                        }
                        else
                        {
                            Console.WriteLine("\nTebrikler. 1.Oyuncu kazandı!");
                        }

                        Console.Write("Lütfen oyunu sıfırlamak için herhangi bir tuşa basınız.");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("Berabere.");
                        Console.WriteLine("Lütfen oyunu sıfırlamak için herhangi bir tuşa basınız.");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                }

                do
                {
                    Console.Write("\nOyuncu {0} lütfen işaretlemek istediğin kareyi seçiniz: ", player);
                    try
                    {
                        input = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Yanlış değer girildi. Lütfen bir sayı giriniz: ");
                    }

                    if ((input == 1) && (playField[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playField[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\nDolu bir yer seçildi. Lütfen başka bir kutu seçiniz: ");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);

            } while (true);
        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine(" ------- Tic Tac Toe ------- ");
            Console.WriteLine("         |         |           ");
            Console.WriteLine("    {0}    |    {1}    |    {2}    ", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_________|_________|_________");
            Console.WriteLine("         |         |           ");
            Console.WriteLine("    {0}    |    {1}    |    {2}    ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_________|_________|_________");
            Console.WriteLine("         |         |           ");
            Console.WriteLine("    {0}    |    {1}    |    {2}    ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("         |         |          ");
            Console.WriteLine(" --------------------------- ");
            turns++;
        }

        public static void ResetField()
        {
            char[,] playFieldInitial =
            {
                {'1','2','3'},
                {'4','5','6'},
                {'7','8','9'}
            };

            playField = playFieldInitial;
            SetField();
            turns = 0;
        }

        public static void EnterXorO(char playerSign, int input)
        {
            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;
            }
        }
    }
}