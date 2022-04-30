// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Diagnostics;
Stopwatch time = new Stopwatch();
time.Start();

Random rnd = new Random();
var PeopleNum = new List<int>();

Console.WriteLine("Введите число людей 'N'");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < N; i++)
    PeopleNum.Add(rnd.Next(0, 9));

LinkedList<int> list = new LinkedList<int>(PeopleNum);

foreach (object num in list)
    Console.Write(num);

Console.WriteLine();

Console.WriteLine(CircleDelete(list));

time.Stop();
Console.WriteLine(time.Elapsed);

T CircleDelete<T>(ICollection<T> source)
{
    int c = source.Count, n = 0;
    while (1 << n <= c) n++;
    {   
        return source.ElementAt(2 * c - (1 << n));
    }
}








//По сути ваша задача — "Считалка Иосифа Флавия"

//И если у нас на входе N элементов, то нужно найти такое максимальное целое A,
//чтобы N = 2A+L, где L ⩾ 0. Тогда результатом будет элемент под индексом 2L (индексы с 0).



//ArrayList следует использовать, когда в приоритете доступ по индексу,
//    так как эти операции выполняются за константное время. Добавление в
//    конец списка в среднем тоже выполняется за константное время. Кроме
//    того в ArrayList нет дополнительных расходов на хранение связки между элементами.
//    Минусы в скорости вставки/удаления элементов находящихся не в конце списка,
//    так как при этой операции все элементы правее добавляемого/удаляемого сдвигаются.

//LinkedList удобен когда важнее быстродействие операций вставки/удаления,
//которые в LinkedList выполняются за константное время. Операции доступа по
//индексу производятся перебором с начала или конца (смотря что ближе) до
//нужного элемента. Дополнительные затраты на хранение связки между элементами.



