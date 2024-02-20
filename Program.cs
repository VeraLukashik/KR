// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


using System.Globalization;

string[] people = {"Tom", "Sam", "Vera"};
Console.WriteLine($"[{string.Join(", ", people)}]");

int count = 0 ;

for (int i = 0; i < people.Length; i++)
{
    if (people[i].Length <=3)
    {
       count++;
    }
}
string[] people2 = new string[count];
Console.WriteLine(count);

for (int i = 0; i < people.Length; i++)
{
    if (people[i].Length <=3)
    {
       people2[i] = people[i];
    }
}
Console.WriteLine($"[{string.Join(", ", people2)}]");









// char[] ConvertStringToCharArray(string str)
// {
//     char[] chars = new char[str.Length];
//     for (int i=0; i<str.Length; i++)
//     {
//         chars[i] = str[i];
//     }
//     return chars;
// }

//  char[] chars = ConvertStringToCharArray(people[0]);
//  Console.WriteLine($"[{string.Join(" ;", chars)}]");

//  char[] chars1 = ConvertStringToCharArray(people[1]);
//  Console.WriteLine($"[{string.Join(" ;", chars1)}]");

//  char[] chars2 = ConvertStringToCharArray(people[2]);
//  Console.WriteLine($"[{string.Join(" ;", chars2)}]");

//  string GetStringFromCharArray(char[] array)
//  {
//     string result = string.Empty;
//     foreach (char symbol in array)
//     {
//         result += symbol;
//     }
//     return result;
//  }
//  if (chars.Length <= 3 )
//  {
//     string res = GetStringFromCharArray(chars);
//     Console.WriteLine($"{res}");
//  }
//  if (chars1.Length <= 3 )
//  {
//     string res = GetStringFromCharArray(chars1);
//     Console.WriteLine($"{res}");
//  }
//  if (chars2.Length <= 3 )
//  {
//     string res = GetStringFromCharArray(chars2);
//     Console.WriteLine($"{res}");
//  }



 



