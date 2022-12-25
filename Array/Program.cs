/*
Написать программу, которая из имеющегося массива строк формирует массив
из строк, длина которых меньше либо равна 3 символа. Первоначальный
массив можно ввести с клавиатуры, либо задать на старте выполнения
алгоритма.
["hello","2","world",":)"]->["2",":-)"]
["1234","1567","-2","computer science"]->["-2"]
*/
void InPutArray(string[] yourArray, uint amount)
{
    for (int i = 0; i < yourArray.Length; i++)
    {
        Console.Write($"\nВведите элемент массива под индексом {i}:\t");
        yourArray[i] = Console.ReadLine() ??"no data";
    }// проверка на null и вывод нужного текста

    Console.WriteLine(($"Исходный массив: [{string.Join(", ", yourArray)}]"));
}

void SortArray(ref string[] anyArray)
{
    string[] newArray = new string[anyArray.Length];
    for (int i = 0; i < anyArray.Length; i++)
        if (anyArray[i].Length <= 3)
            newArray[i] = anyArray[i];
    anyArray = newArray;
}

void PrintArray(string[] yourArray)
{
    for (int i = 0; i < yourArray.Length; i++)
        Console.WriteLine(yourArray[i]);
}

Console.Write("\nВведите количество элементов массива:\t");
uint amount = Convert.ToUInt32(Console.ReadLine());
string[] yourArray = new string[amount];
InPutArray(yourArray, amount);
Console.WriteLine("------------------------------------");
SortArray(ref yourArray);
PrintArray(yourArray);


