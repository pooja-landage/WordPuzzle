using System;
using System.Linq;
using System.Collections;

namespace WordPuzzle


{

    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\t            ====================Welcome to the game of WORD PUZZLE====================");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\t            =================================Instructions=============================");
                Console.WriteLine("\t            i.Please enter the words in uppercase");
                Console.WriteLine("\t            ii.Every correct word will add 1 point to your score");
                Console.WriteLine("\t            iii.In order to quit from game , type ‘QUIT’.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.DarkBlue;

                Console.WriteLine("\t             Create words of three or more letters from the word: MASTER");

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

                string[] word = new string[] {"MAT","SAT","RAT","ARE","ARM","ARS","ART","ATE","EAR","EAT","ERA","ERS","ETA","EMS","MAE","MAR","MAS","MET","RAM","RES","RET","SEA","SER","SET","TEA","TAM","TAR",
            "ARES","ARMS","ARTS","EARS","EAST","EATS","ERAS","ERST","ETAS","ETAS","MARE","MARS","MART","MAST","MATE","MATS","MEAT","META","RAMS","RATE","RATS","REST","SAME","SEARS","SEAT","SETA","STAR","TAME","TARE","TEAM","TEAR","TEAM","TRAM","TSAR",
            "ARMET","ASTER","MARTS","MASER","MATER","MATTER","MEATS","STRESS","RATES","RESTART","START","STEM","RESAT","SMART","STARE","STEAM","TAMER","TEARS","TEAMS","TERMS"};
                //decalring the points for user

                int count = 0;

                foreach (string p in word)
                {
                    Console.Write("Please Enter The Word: ");
                    string i = Console.ReadLine();
                    if (i.Any(char.IsLower))
                    {
                        Console.WriteLine("Your Answer Should be In Upper Case");
                    }
                    else if (word.Contains(i) == true)
                    {
                        Console.WriteLine("Correct Answer....");
                        count++;
                        Console.WriteLine(" 1 Point \t Total Points: {0}", count);

                    }
                    else if (i == "QUIT")
                    {
                        Console.WriteLine("Thank You for playing this Game \n Your Score is {0}:", count);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Answer....");
                    }
                }






            }

        }
    }
}

