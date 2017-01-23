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