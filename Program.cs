/*  
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Пример:
["hello","2","world",":-)"] -> ["2",":-)"]
["1234","1567","-2","computer science"]->["-2"]
["Russia","Denmark","Kazan"]->[]
*/
Console.Clear();
Console.WriteLine("Введите число для сортировки массива");
int sort = Convert.ToInt32(Console.ReadLine());
string[] array = { "hello", "Russia", "Denmark", "-2", "computer science", "2", "world", ":-)", "GeekBrains","robo","home"};
Console.Write($"[{String.Join(" , ", array)}] -> ");
Console.Write("[ ");
ModifyArray(sort,array);
Console.WriteLine();

void ModifyArray(int sort,string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= sort) Console.Write($"{arr[i]}" + ",");
    }
    Console.Write("\b ]");
}