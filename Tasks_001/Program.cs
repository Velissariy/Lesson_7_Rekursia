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

// Task_5.1
// int n = 1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//   if (length == word.Length)
//   {
//     Console.WriteLine($"{n++} {new String(word)}"); return;
//   }
//   for (int i = 0; i < alphabet.Length; i++)
//   {
//     word[length] = alphabet[i];
//     FindWords(alphabet, word, length+1);
//   }
// }

// FindWords("аисв", new char[2]);

// Task_6
//обход директорий

// string path = "D:/GeekBrains/7_С#/Projects_C#/C#_test";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//   System.Console.WriteLine(fi[i].Name);
// }

// Task_6.1
// void CatalogInfo(string path, string indent ="")
// {
//   DirectoryInfo catalog = new DirectoryInfo(path);
//   DirectoryInfo[] catalogs = catalog.GetDirectories();
//   for (int i = 0; i < catalogs.Length; i++)
//   {
//     Console.WriteLine($"{indent}{catalogs[i].Name}");
//     CatalogInfo(catalogs[i].FullName, indent +" ");
//   }

//   FileInfo[] files = catalog.GetFiles();
//   for (int i = 0; i < files.Length; i++)
//   {
//     Console.WriteLine($"{indent}{files[i].Name}");
//   }
// }
// string path = "D:/GeekBrains/7_С#/Projects_C#/C#_test";
// CatalogInfo(path);


//Tasks_7;

// void Towers(string with ="1", string on = "3", string some = "2", int count = 3)
// {
//   if (count>1) Towers(with, some, on, count -1);
//   Console.WriteLine($"{with} >> {on}");
//   if (count>1) Towers(some,on, with, count -1);
// }

// Towers();

//Tasks_8;
//Обход разных структур
// ((4-2)*(1+3))/10
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//                 0    1    2     3    4    5    6    7    8    9    10   11
void InOrderTraversal(int pos = 1)
{
  if (pos < tree.Length)
  {
    int left = 2 * pos;
    int right = 2 * pos + 1;
    if (left<tree.Length &&!String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
    Console.WriteLine(tree[pos]);
    if (right<tree.Length &&!String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
  }
}
InOrderTraversal();