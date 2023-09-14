
int choice;
do
 {
    Console.WriteLine("Выберите действие :");
    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");
    choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Введите первое число :");
                string x = Console.ReadLine();
                int a = Convert.ToInt32(x);

                Console.WriteLine("Введите второе число :");
                string r = Console.ReadLine();
                int b = Convert.ToInt32(r);

                int sum = a + b;
            Console.WriteLine($"Сумма чисел {a} и {b} равна {sum}");
                break;
            case 2:
                Console.WriteLine("Введите первое число :");
            string h = Console.ReadLine();
            int g = Convert.ToInt32(h);
                Console.WriteLine("Введите второе число :");
            string l = Console.ReadLine();
            int o = Convert.ToInt32(l);

            int c = g - o;
            Console.WriteLine($"Разность чисел {g} и {o} равна {c}");
                break;
            case 3:
                Console.WriteLine("Введите первое число :");
            string ab = Console.ReadLine();
            int oa = Convert.ToInt32(ab);
                Console.WriteLine("Введите второе число :");
            string hg = Console.ReadLine();
            int yu = Convert.ToInt32(hg);

            int yt = oa * yu;
            Console.WriteLine($"Произведение чисел {oa} и {yu} равно {yt}");
            break;
            case 4:
                Console.WriteLine("Введите первое число :");
            string kl = Console.ReadLine();
            int it = Convert.ToInt32(kl);
                Console.WriteLine("Введите второе число :");
            string gk = Console.ReadLine();
            int pl = Convert.ToInt32(gk);

            int nm = it / pl;
            Console.WriteLine(nm);
            Console.WriteLine($"Частное будет равно {nm}");
            break;
            case 5:
                Console.WriteLine("Введите первое число:");
            string input1 = Console.ReadLine();
            double number1 = Convert.ToDouble(input1);

                    Console.WriteLine("Введите степень:");
            string input2 = Console.ReadLine();
            int exponent = Convert.ToInt32(input2);

            double result = Math.Pow(number1, exponent);
            Console.WriteLine($"Степень от числа {number1} равна {result}");
            break;
            case 6:
                Console.WriteLine("Введите число:");
            string input = Console.ReadLine();
            double hfds = double.Parse(input);
            double squareRoot = Math.Sqrt(hfds);
            Console.WriteLine(squareRoot);
            Console.WriteLine($"Квадратный корень {hfds} равен {squareRoot}");
            break;
            case 7:
            Console.WriteLine("Введите число");
            string input3 = Console.ReadLine();
            double kjg = double.Parse(input3);
            double onePercent = kjg / 100;
            Console.WriteLine($"1% от числа {kjg} равно {onePercent}");
            break;
            case 8:
            Console.WriteLine("Введите число:");
            string input6 = Console.ReadLine();
            int number5 = int.Parse(input6);
            static int Factorial(int ajfjn)
            {
                int factorial = 1;
                for (int fdakfl = 2; fdakfl <= ajfjn; fdakfl++)
                {
                    factorial *= fdakfl;
                }
                return factorial;
            }
            Console.WriteLine(Factorial(number5));
            break;
            case 9:
            break;
        default:
                Console.WriteLine("Некорректный выбор.");
                break;
        }

        Console.WriteLine();
    } while (choice != 9);