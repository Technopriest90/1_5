using System;


// class FindPrimes //выяснить, является ли число простым. Если оно непростое, вывести наибольший его множитель.
// {
//     static void Main()
//     {
//         int num;
//         int i;
//         int factor;
//         bool isprime;
// 
//         for (num = 2; num < 20; num++)
//         {
//             isprime = true;
//             factor = 0;
// 
//             //выяснить, делится ли значение переменной num нацело.
//             for (i = 2; i <= num / 2; i++)
//             {
//                 if ((num % i) == 0)
//                 {
//                     //значение переменной num делится нацело.
//                     //Следовательно, это непростое число.
//                     isprime = false;
//                     factor = i;
//                 }
//             }
//             if (isprime)
//                 Console.WriteLine(num + " - простое число.");
//             else
//                 Console.WriteLine("Наибольший множитель числа " + num + " равен " + factor);
// 
//             
//         }
//         Console.ReadKey();
//     }
// }
// class Comma //использовать запятые в операторе цикла for для выявления наименьшего и наибольшего множителя числа.
// {
//     static void Main()
//     {
//         int i, j;
//         int smallest, largest;
//         int num;
// 
//         num = 11;
// 
//         smallest = largest = 1;
// 
//         for (i = 2, j = num / 2; (i <= num / 2) & (j >= 2); i++, j--)
//         {
//             if ((smallest == 1) & ((num % i) == 0))
//                 smallest = i;
// 
//             if ((largest == 1) & ((num % j) == 0))
//                 largest = j;
//         }
//         Console.WriteLine("Наибольший множитель: " + largest);
//         Console.WriteLine("Наименьший множитель: " + smallest);
//         Console.ReadKey();
//     }
// }
// 
//     class Empty3 //тело цикла может быть пустым
// {
//     static void Main()
//     {
//         int i;
//         int sum = 0;
// 
//         //получить сумму чисел от 1 до 5
//         for (i = 1; i <= 5; sum += i++);
// 
//         Console.WriteLine("Сумма равна " + sum);
//         Console.ReadKey();
//     }
// }
// 
//     class ForVar
// {
//     static void Main() {
//         int sum = 0;
//         int fact = 1;
// 
//         //вычислить факториал чисел от 1 до 5
//         for(int i = 1; i <= 5; i++)
//         {
//             sum += i; //переменная i действует в цикле
//             fact *= i;
//         }
// 
//         //а здесь переменная i недоступна
//         Console.WriteLine("Сумма равна " + sum);
//         Console.WriteLine("Факториал равен " + fact);
//         Console.ReadKey();
//     }
// }
// 
//     class WhileDemo // ВЫчислить порядок величины целого числа
// {
//     static void Main()
//     {
//         int num;
//         int mag;
// 
//         num = 435679;
//         mag = 0;
// 
//         Console.WriteLine("Число: " + num);
// 
//         while(num > 0)
//         {
//             mag++;
//             num = num / 10;
//         }
// 
//         Console.WriteLine("Порядок величины: " + mag);
//         Console.ReadKey();
//     }
// }
// 
//     class Power // вычислить целые степени числа 2
// {
//     static void Main()
//     {
//         int e;
//         int result;
// 
//         for (int i=0; i < 10; i++)
//         {
//             result = i;
//             e = i;
// 
//             while (e > 0)
//             {
//                 result *= 2;
//                 e--;
//             }
// 
//             Console.WriteLine("2 в степени " + i + " равно " + result);
//             
//         }
//         Console.ReadKey();
//     }
// }

//     class DoWhileDemo //отобразить цифры целого числа в обратном порядке
// {
//     static void Main ()
//     {
//         int num;
//         int nextdigit;
// 
//         num = 198;
// 
//         Console.WriteLine("Число: " + num);
// 
//         Console.Write("Число в обратно порядке: ");
// 
//         do
//         {
//             nextdigit = num % 10;
//             Console.Write(nextdigit);
//             num = num / 10;
//         } while (num > 0);
// 
//         Console.WriteLine();
//         Console.ReadKey();
//     }
// }
    // 
    // class FindSmallestFactor //выявить наименьший множитель числа.
    // {
    //     static void Main()
    //     {
    //         int factor = 1;
    //         int num = 1000;
    // 
    //         for (int i = 2; i <= num / i; i++)
    //         {
    //             if ((num % i) == 0)
    //             {
    //                 factor = i;
    //                 break; //прервать цикл, как только будет выявлен наименьший множитель числа
    //             }
    //         }
    //         Console.WriteLine("Наименьший множитель равен " + factor);
    //         Console.ReadKey();
    //             }
    // }
    // 
    //     class Use_goto
    // {
    //     static void Main()
    //     {
    //         int i = 0, j = 0, k = 0;
    // 
    //         for(i=0; i < 10; i++)
    //         {
    //             for (j=0; j < 10; j++)
    //             {
    //                 for(k=0; k < 10; k++)
    //                 {
    //                     Console.WriteLine("i, j, k: " + i + " " + j + " " + k);
    //                     if (k == 3) goto stop;
    //                 }
    //             }
    //         }
    //     stop:
    //         Console.WriteLine("Остановлено! i, j, k: " + i + " " + j + " " + k);
    //         Console.ReadKey();
    //     }
    // }