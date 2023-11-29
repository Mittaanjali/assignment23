using System;

namespace Assignment23
{
    public delegate string WinnerCondition(int energyLevel, int winningProbability);

    internal class Program
    {
        public static string CheckWinner(int energyLevel, int winningProbability)
        {
            if (energyLevel >= 4 && winningProbability > 60)
            {
                return "Congratulations! You are the Winner!";
            }
            else if (energyLevel >= 1 && winningProbability > 50)
            {
                return "You're the Runner Up!";
            }
            else
            {
                return "Sorry, Better luck next time. You're a Loser!";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name:");
            string playerName = Console.ReadLine();

            Console.WriteLine("Enter Your Lucky Number from 1 to 10:");
            int luckyNumber = int.Parse(Console.ReadLine());

            int energyLevel = 1;
            int winningProbability = 100;
            int noOfSpins = 10;

            WinnerCondition winnerCondition = CheckWinner;

            for (int spin = 1; spin <= noOfSpins; spin++)
            {
                Console.WriteLine($"Spin {spin}: Energy Level {energyLevel}, Winning Probability {winningProbability}");

                switch (spin)
                {
                    case 1:
                        energyLevel += 1;
                        winningProbability += 10;
                        break;
                    case 2:
                        energyLevel += 2;
                        winningProbability += 20;
                        break;
                    case 3:
                        energyLevel -= 3;
                        winningProbability -= 30;
                        break;
                    case 4:
                        energyLevel += 4;
                        winningProbability += 40;
                        break;
                    case 5:
                        energyLevel += 5;
                        winningProbability += 50;
                        break;
                    case 6:
                        energyLevel -= 1;
                        winningProbability -= 60;
                        break;
                    case 7:
                        energyLevel += 1;
                        winningProbability += 70;
                        break;
                    case 8:
                        energyLevel -= 2;
                        winningProbability -= 20;
                        break;
                    case 9:
                        energyLevel -= 3;
                        winningProbability -= 30;
                        break;
                    case 10:
                        energyLevel += 10;
                        winningProbability += 100;
                        break;
                    default:
                        break;
                }
            }

            string result = winnerCondition(energyLevel, winningProbability);
            Console.WriteLine("\nWinner: " + result);

            Console.ReadKey();
        }
    }
}


