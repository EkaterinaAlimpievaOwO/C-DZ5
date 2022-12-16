// -------------------------------------------------------------------->
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Random var = new Random();
// int[] array = new int[var.Next(1, 10)];

// FillArray(array, 100, 1000);
// PrintArray(array);

// int evenNumbers = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         evenNumbers++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Количество чётных чисел в массиве: " + evenNumbers);



// -------------------------------------------------------------------->
// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Random var = new Random();
// int[] array = new int[var.Next(1, 10)];
// FillArray(array, -100, 100);
// PrintArray(array);
// int sum = 0;
// for(int i = 1; i < array.Length; i += 2)
// {
//     sum += array[i];
// }
// Console.WriteLine();
// Console.WriteLine("Сумма элементов на нечётных позициях: " + sum);


// -------------------------------------------------------------------->
// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// Random var = new Random();
// float[] array = new float[var.Next(1, 10)];
// FillArrayFloat(array, -100, 100);
// PrintArrayFloat(array);
// float min = array[0];
// float max = array[0];

// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] > max)
//     {
//         max = array[i];
//     }
//     else if(array[i]< min)
//     {
//         min = array[i];
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Максимальное значение: " + max);
// Console.WriteLine("Минимальное значение: " + min);
// Console.WriteLine("Разница между максимальным и минимальным значением: " + (max - min));





// -------------------------------------------------------------------->




void FillArray(int[] array, int min, int max)
{
    Random var = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = var.Next(min, max);
    }
}


void FillArrayFloat(float[] array, int min, int max)
{
    Random var = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = var.Next(min, max);
    }
}



void PrintArray(int[] collection)
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(collection[position] + " ");
        position++;
    }
}


void PrintArrayFloat(float[] collection)
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(collection[position] + " ");
        position++;
    }
}