float PervoeChislo, VtoroeChislo;
int stop = 1;

Console.WriteLine("Какую операцию вы хотите произвести над числами из: ");

while (stop != 0)
{




    Console.WriteLine("1.Сложить два числа");

    Console.WriteLine("2.Вычесть два числа");

    Console.WriteLine("3.Умножить два числа");

    Console.WriteLine("4.Поделить два числа");

    Console.WriteLine("5.Возвести первое число в степень равную второму числу");

    Console.WriteLine("6.Найти корень из числа");

    Console.WriteLine("7.Найти 1% из числа");

    Console.WriteLine("8.Найти факториал числа");

    Console.WriteLine("0. Выйти из программы");


    Console.Write("Выбирите действие: ");
    int deystvie = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");

    switch (deystvie)
    {
        case 1:

            Console.Write("Задайте первое число: ");
            PervoeChislo = float.Parse(Console.ReadLine());

            Console.Write("Задайте второе число: ");
            VtoroeChislo = float.Parse(Console.ReadLine());

            Console.WriteLine($"Результат: {PervoeChislo + VtoroeChislo}");
            Console.WriteLine(" ");
            Console.WriteLine("Ещё разок?");

            break;

        case 2:

            Console.Write("Задайте первое число: ");
            PervoeChislo = float.Parse(Console.ReadLine());

            Console.Write("Задайте второе число: ");
            VtoroeChislo = float.Parse(Console.ReadLine());

            Console.WriteLine($"Результат: {PervoeChislo - VtoroeChislo}");
            Console.WriteLine(" ");
            Console.WriteLine("Ещё разок?");
            break;

        case 3:

            Console.Write("Задайте первое число: ");
            PervoeChislo = float.Parse(Console.ReadLine());

            Console.Write("Задайте второе число: ");
            VtoroeChislo = float.Parse(Console.ReadLine());

            Console.WriteLine($"Результат: {PervoeChislo * VtoroeChislo}");
            Console.WriteLine(" ");
            Console.WriteLine("Ещё разок?");
            break;

        case 4:

            Console.Write("Задайте первое число: ");
            PervoeChislo = float.Parse(Console.ReadLine());

            Console.Write("Задайте второе число: ");
            VtoroeChislo = float.Parse(Console.ReadLine());

            if (VtoroeChislo == 0)
                Console.WriteLine("На ноль делить нельзя >:(");

            else



                Console.WriteLine($"Результат: {PervoeChislo / VtoroeChislo}");
            Console.WriteLine(" ");
            Console.WriteLine("Ещё разок?");
            break;

        case 5:

            Console.Write("Задайте второе число: ");
            PervoeChislo = float.Parse(Console.ReadLine());

            Console.Write("Задайте второе число: ");
            VtoroeChislo = float.Parse(Console.ReadLine());

            if (VtoroeChislo < 0)

                Console.WriteLine("Введите положительное число или 0");
            else
                Console.WriteLine($"Результат: {Math.Pow(PervoeChislo, VtoroeChislo)}");
            Console.WriteLine(" ");
            Console.WriteLine("Ещё разок?");
            break;

        case 6:

            Console.Write("Задайте второе число: ");
            PervoeChislo = float.Parse(Console.ReadLine());

            if (PervoeChislo < 0)

                Console.WriteLine("Введите положительное число или 0");

            else

                Console.WriteLine($"Результат: {Math.Sqrt(PervoeChislo)}");
            Console.WriteLine(" ");
            Console.WriteLine("Ещё разок?");
            break;

        case 7:

            Console.Write("Задайте второе число: ");
            PervoeChislo = float.Parse(Console.ReadLine());

            Console.WriteLine($"Результат: {PervoeChislo / 100}");
            Console.WriteLine(" ");
            Console.WriteLine("Ещё разок?");
            break;

        case 8:
            int Factorial = 1;

            Console.Write("Введите число, факториал которого хотите найти: ");
            PervoeChislo = float.Parse(Console.ReadLine());

            if (PervoeChislo < 0)

                Console.WriteLine("Введите положительное число или 0");

            else
                for (int i = 1; i <= PervoeChislo; i++)

                {
                    Factorial = i * Factorial;
                }

            Console.WriteLine($"Результат: {Factorial}");
            Console.WriteLine(" ");
            Console.WriteLine("Ещё разок?");

            break;

        case 0:
            Console.WriteLine("Вы вышли из моего калькулятора >:(");
            stop = stop - 1;
            break;

        default:
            Console.WriteLine("Такого действия нет >:(");
            Console.WriteLine(" ");

            break;
    }
}

