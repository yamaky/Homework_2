using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rightEnter = false;
            //Number 1
            Console.WriteLine("Найти сумму чётных чисел.");
            Console.WriteLine("Введите число:");
            int a;

            string str = Console.ReadLine();
            rightEnter = int.TryParse(str, out a);

            while(!rightEnter)
            {
                Console.WriteLine("Вы ввели неправильное значение. Попробуйте снова!");
                str = Console.ReadLine();
                rightEnter = int.TryParse(str, out a);
            }

            //int a = Convert.ToInt32(str);
            int sum = 0;
            int b = a;

            while(a != 0)
            {
                int rest = a % 10;
                //Console.WriteLine(rest);
                if (rest % 2 == 0)
                    sum = sum + rest;
                a /= 10;
            }
            Console.WriteLine($"Сумма четных цифр числа {b} равна {sum}\n\n");

            //Number 2
            bool rightEnter1 = false;
            bool rightEnter2 = false;
            int number1, number2;

            Console.WriteLine("Сделать умножение чисел друг на друга через сумму.");
            Console.WriteLine("Введите первое число:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите второе число:");
            string str2 = Console.ReadLine();
            rightEnter1 = int.TryParse(str1, out number1);
            rightEnter2 = int.TryParse(str2, out number2);

            while (!rightEnter1)
            {
                Console.WriteLine("Вы ввели неправильное значение первого числа. Попробуйте снова!");
                Console.WriteLine("Введите первое число:");
                str1 = Console.ReadLine();
                rightEnter1 = int.TryParse(str1, out number1);
            }
            while (!rightEnter2)
            {
                Console.WriteLine("Вы ввели неправильное значение второго числа. Попробуйте снова!");
                Console.WriteLine("Введите второе число:");
                str2 = Console.ReadLine();
                rightEnter2 = int.TryParse(str2, out number2);
            }

            int prod = 0;
            if (number1 > number2)
                for(int i = 0; i < number2; i++)
                {
                    prod = prod + number1;
                }
            else
                for (int i = 0; i < number1; i++)
                {
                    prod = prod + number2;
                }
            Console.WriteLine($"{number1} * {number2} = {prod}\n\n");

            //Number 3 
            rightEnter = false;
            Console.WriteLine("Игра угадайка.");
            int from = -10;
            int to = 10;
            Random rnd = new Random();
            int randomNumber = rnd.Next(from, to + 1);
            //Console.WriteLine(randomNumber);

            int inputNumber;
            string userInput;
            int count = 1;

            Console.WriteLine($"Введите число от {from} до {to}: ");
            while (!rightEnter)
            {
                Console.WriteLine("Если Вы устрали и хотите выйти, то нажмите q.");
                userInput = Console.ReadLine();
                //string ex = userInput;
                rightEnter = int.TryParse(userInput, out inputNumber);

                if (userInput == "q")
                {
                    Console.WriteLine("Очень жаль :(\n\n");
                    break;
                }
                    
                if (randomNumber == inputNumber)
                {
                    Console.WriteLine($"Молодцы! Вы угадали число с {count} попытки!\n\n");
                }
                else
                {
                    Console.WriteLine("Вы не угадали, попробуйте снова!");
                    rightEnter = false;
                }
                count++;
            }

            //Number 4
            rightEnter = false;
            int number;
            Console.WriteLine("Определить из каких цифр состоит число.");
            Console.WriteLine("Введите число:");
            string str3 = Console.ReadLine();
            rightEnter = int.TryParse(str3, out number);

            while (!rightEnter)
            {
                Console.WriteLine("Вы ввели неправильное значение. Попробуйте снова!");
                Console.WriteLine("Введите число:");
                str3 = Console.ReadLine();
                rightEnter = int.TryParse(str3, out number);
            }

            int NumberCopy = number;
            int c = 0;

            while (NumberCopy != 0)
            {
                NumberCopy /= 10;
                c++;
            }

            int [] array = new int[c];
           for(int i = array.Length - 1; i >= 0; i--)
            {
                array[i] = number % 10;
                number /= 10;
            }
            Console.WriteLine("Ваше число состоит из цифр: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine("\n\n");

            //Number 5
            rightEnter = false;
            int abc;
            Console.WriteLine("Перевернуть число.");
            Console.Write("Ваше число: ");
            string str4 = Console.ReadLine();
            rightEnter = int.TryParse(str4, out abc);
            //int abc = Convert.ToInt32(str4);

            while (!rightEnter)
            {
                Console.WriteLine("Вы ввели неправильное значение. Попробуйте снова!");
                Console.WriteLine("Введите число:");
                str3 = Console.ReadLine();
                rightEnter = int.TryParse(str3, out abc);
            }

            int cba = 0;
            while(abc != 0)
            {
                cba = cba * 10 + abc % 10;
                abc /= 10;
            }
            Console.WriteLine($"Перевернутое число: {cba}");

            Console.Read();
        }

    }
}
