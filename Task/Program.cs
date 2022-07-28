// Задание - Напишите программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меьнше либо равна 3 символам.
// Первоначальный массив можно задать с клавиатуры или вессти на старте выполнения алгоритма.

Console.Write("Введите размер массива - ");
int x = Convert.ToInt32(Console.ReadLine());
string[] mas1 = new string[x];
string[] mas2 = new string[mas1.Length];
Console.WriteLine("Заполните массив: ");

for (int i = 0; i < x; i++)
{
    Console.Write($"Введите {i+1} элемент массива - ");
    mas1[i] = Convert.ToString(Console.ReadLine());
}


void FillingArray(string[] array1, string[] array2)
{
    int count = 0;

    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("Новый массив из строк, длинна которых меьнше либо равна 3 символам - ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

FillingArray (mas1, mas2);
PrintArray (mas2);