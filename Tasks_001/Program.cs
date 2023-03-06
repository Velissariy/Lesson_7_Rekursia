// Важно при описании рекурсии - описать условие выхода

// Собрать строку с числами от a до b, a<=b
// Task_1
// string NumbersFor(int a, int b)
// {
//    string result = String.Empty;
//    for (int i = a; i < b; i++)
//    {
//     result +=$"{i}";
//    }
//    return result;
// }
 
// string NumbersRec(int a, int b)
// {
//   if (a<=b) return NumbersRec(a+1, b) + $"{a}";//подкрутить условие и else переделать
//   else return string.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));


//Сумма чисел от 1 до N
// Task_2
// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i <=n; i++) result +=i;
//     return result;
// }
 
//  int SumRec(int n)
//  {
//   if (n==0) return 0;
//   else return n + SumRec(n-1);
//  }
// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));

// Факториал числа
// Task_3
// int FactorialFor(int n)
// {
//     int result = 1;
//     for (int i = 1; i <=n; i++) result *=i;
//     return result;
// }

//  int FactorialRec(int n)
//  {
//   if (n==1) return 1;
//   else return n * FactorialRec(n-1);
//  }
// Console.WriteLine(FactorialFor(10));
// Console.WriteLine(FactorialRec(10));

// Вычислить a в степени n
// Task_4
// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <=n; i++) result *=a;
//     return result;
// }

//  int PowerRec(int a, int n)
//  { //return n ==0 ? 1 : PowerRec(a, n-1)*a; тоже самое
//   if (n==0) return 1;
//   else return PowerRec(a, n-1)*a;
//  }

// int PowerRecMath(int a, int n)
//  { 
//   if (n==0) return 1;
//   else if (n%2 ==0) return PowerRecMath(a*a, n/2);
//   else return PowerRecMath(a, n-1)*a;
//  }

// Console.WriteLine(PowerFor(2, 10));
// Console.WriteLine(PowerRec(2, 10));
// Console.WriteLine(PowerRecMath(2, 10));

//Перебор слов
// Task_5
// В некотором машинном алфавите имеются четыре буквы "а", "и", "с" и "в". 
// Покажите все слова, состоящие из Т букв,
// которые можно построить из букв этого алфавита.

// char[] s ={'а', 'и', 'с', 'в',};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//   for (int j = 0; j < count; j++)
//   {
//     for (int k = 0; k < count; k++)
//     {
//       for (int l = 0; l < count; l++)
//       {
//         for (int m = 0; m < count; m++)
//         {
//           Console.WriteLine($"{n++, -5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
//         }
//       }
//     }
    
//   }
// }
