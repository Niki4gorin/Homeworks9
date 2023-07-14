// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// int FindNumbers(int num)
// {
//     if(num >= 1)
//     {
//         System.Console.Write(num + " ,");
//         FindNumbers(num -1);
//     }
//     return num;
// }

// System.Console.WriteLine("Input num -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(FindNumbers(num));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int FindSum(int m, int n)
// {
//     if (m == 0) 
//     {
//         return (n * (n + 1)) / 2;
//     }            
//     else if (n == 0) 
//     {
//         return (m * (m + 1)) / 2;
//     }       
//     else if (m == n) 
//     {
//         return m;
//     }                       
//     else if (m < n) 
//     {
//         return n + FindSum(m, n - 1);
//     } 
//     else
//     {
//         return n + FindSum(m, n + 1);
//     }
// }
// Console.Write("Введите первое число ->");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ->");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма натуральных элементов равна -> {FindSum(m, n)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }

// void AkkermanFunction(int m, int n)
// {

//     System.Console.Write($"Функция Аккермана ({m},{n}) -> {Akkerman(m, n)}");
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Введите первое число -> ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число -> ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m, n);
