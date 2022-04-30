// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Collections.Generic;
Random rnd = new Random();
Console.WriteLine("Введите длинну массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[length];
List<string> neparni = new List<string>();

//заповнення масиву 
Console.WriteLine("Массив заполнен автоматически");
for (int i = 0; i < length; i++)
{
    numbers[i] = rnd.Next(1, 30);
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();
//пошук непарних елементів (Операторы запросов LINQ)
var queryNumber =
    from num in numbers
    where (num % 2) != 0
    select num;
//створення "строкових уявлень"
foreach (int num in queryNumber)
{
    Console.Write(num + " ");
    neparni.Add(num.ToString());
}

// розставлення у лексикографічному порядку
var LexicographiсOrder =
    from p in neparni
    orderby p
    select p;
Console.WriteLine();
// розставлення у лексикографічному порядку АЛЕ за допомогою лямбда виразів
//var query1 = nepar.OrderBy(x => x);
foreach (string x in LexicographiсOrder)
Console.Write(x + " ");