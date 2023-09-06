// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];

Console.WriteLine("Введите строки массива:");

for (int i = 0; i < size; i++)
{
    Console.Write($"Строка {i + 1}: ");
    array[i] = Console.ReadLine();
}

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Строка {i + 1}: {array[i]}");
}

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) count++;
}
string[] newarray = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newarray[j] = array[i];
        j++;
    }
}
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", newarray)}]");
Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", newarray)}]");
