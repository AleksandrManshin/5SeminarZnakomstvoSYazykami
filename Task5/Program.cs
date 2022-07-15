// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10

void Zadacha37()
{
     Random random = new Random();
    int size = random.Next(4, 12);
    int[] arr = new int[size];

    FillArray(arr);
    Console.WriteLine("Массив:");
    PrintArray(arr);
    
    Console.WriteLine();
    int maxIndex = arr.Length - 1;
    for(int i = 0; i < arr.Length/2; i++)
    {
        Console.WriteLine($"{arr [i]} * {arr[maxIndex - i]} = {arr [i] * arr[maxIndex - i]}");
    }

    if(arr.Length % 2 == 1) Console.WriteLine(arr[arr.Length / 2]);
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
}

Zadacha37();