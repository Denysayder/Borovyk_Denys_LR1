using System.Collections;
using System.Diagnostics;
Stopwatch time = new Stopwatch();
time.Start();

ArrayList list = new ArrayList();
Random rnd = new Random();
Console.WriteLine("Введите число людей 'N'");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < N; i++)
    list.Add(rnd.Next(0, 9));

foreach (object num in list)
Console.Write(num);

int j = 0;  
int size = 0;

while (list.Count > 1)
{       
  
    if (list.Count % 2 != 0)
    {     //якщо довжина непарна

        j = 0;
        size = list.Count / 2;                // кількість елементів, що видаляться 

        for (int k = 0; k < size; k++)
        {
            list.RemoveAt(j + 1);
            j++;
        }
        list.RemoveAt(0);                      // Видаляємо перший

    }
    else if (list.Count % 2 == 0)
    {        // якщо довжина парна
        j = 0;                            
        size = list.Count / 2;

        for (int k = 0; k < size; k++)
        {
            list.RemoveAt(j + 1);
            j++;

        }
    }
}
Console.WriteLine();

foreach (object num in list)
    Console.Write(num);

Console.WriteLine();
time.Stop();
Console.WriteLine(time.Elapsed);





//using System.Collections;
//using System.Diagnostics;
//Stopwatch time = new Stopwatch();
//time.Start();

//ArrayList list = new ArrayList();
//Random rnd = new Random();
//Console.WriteLine("Введите число людей 'N'");
//int N = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < N; i++)
//    list.Add(rnd.Next(0, 9));

//foreach (object num in list)
//    Console.Write(num);

//bool b = false;
//while (!b)
//{
//    for (int i = list.Count / 2 * 2 - 1; i >= 0; i -= 2)
//    {
//        list.RemoveAt(i);
//    }
//    Console.WriteLine();
//    foreach (object num in list)
//        Console.Write(num);
//    if (list.Count==1)
//    {
//        b = true;
//    }
//}

//time.Stop();
//Console.WriteLine();
//Console.WriteLine(time.Elapsed);



//Scanner in = new Scanner(System.in);
//long n = in.nextLong();                     // Задаю длину списка

//ArrayList<Integer> num = new ArrayList<>(); // Создаю пустой список

//for (int i = 1; i < n + 1; i++)
//{              // Заполняю его заданным
//    num.add(i);                             // количеством чисел
//}
