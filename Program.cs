using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Игра \"Угадай число\"");
        Console.WriteLine("2. Таблица умножения");
        Console.WriteLine("3. Вывод делителей числа");
        Console.WriteLine("Введите номер игры, в которую хотите сыграть:");
        int gameChoice = Convert.ToInt32(Console.ReadLine());

        switch (gameChoice)
        {
            case 1:
                {
                    Random rand = new Random();
                    int secretNumber = rand.Next(1, 101);
                    int guess;

                    do
                    {
                        Console.WriteLine("Введите число от 1 до 100:");
                        guess = Convert.ToInt32(Console.ReadLine());

                        if (guess < secretNumber)
                        {
                            Console.WriteLine("Слишком маленькое число, попробуйте еще раз.");
                        }
                        else if (guess > secretNumber)
                        {
                            Console.WriteLine("Слишком большое число, попробуйте еще раз.");
                        }
                    } while (guess != secretNumber);

                    Console.WriteLine("Вы угадали число!");
                    Console.WriteLine("Хотите сыграть еще? (1 - да, 2 - нет)");
                    int playAgain = Convert.ToInt32(Console.ReadLine());

                    if (playAgain == 1)
                    {
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("Хорошо, спасибо за игру!");
                        Console.ReadKey();
                    }
                    break;
                }
            case 2:
                {
                    int[,] mass = new int[9, 9];

                    for (int i = 1; i < 10; i++)
                    {
                        mass[0, i - 1] = i;
                        mass[i - 1, 0] = i;
                    }

                    for (int i = 1; i < 9; i++)
                    {
                        for (int j = 1; j < 9; j++)
                        {
                            mass[i, j] = mass[i, 0] * mass[0, j];
                        }
                    }

                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            Console.Write("\t" + mass[i, j]);
                        }
                    Console.WriteLine();
               
                }
                    Console.WriteLine("Хотите сыграть еще? (1 - да, 2 - нет)");
                    int playAgain = Convert.ToInt32(Console.ReadLine());

                    if (playAgain == 1)
                    {
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("Хорошо, спасибо за игру!");
                        Console.ReadKey();
                    }
                    break;
                }
            case 3:
                {
                    int number;
                    Console.WriteLine("Введите число:");
                    number = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            Console.WriteLine($"{i} - делитель числа {number}");
                        }
                    }
                    Console.WriteLine("Хотите сыграть еще? (1 - да, 2 - нет)");
                    int playAgain = Convert.ToInt32(Console.ReadLine());

                    if (playAgain == 1)
                    {
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("Хорошо, спасибо за игру!");
                        Console.ReadKey();
                    }
                    break;
                }
            default:
                Console.WriteLine("Неверный выбор игры. Пожалуйста, выберите игру от 1 до 3.");
                Main();
                break;
        }
    }
}

