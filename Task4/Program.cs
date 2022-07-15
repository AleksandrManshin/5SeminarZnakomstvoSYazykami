// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void Zadacha35()
{
    int size = 123;
    int[] arr = new int[size];

    FillArray(arr);
    Console.WriteLine("Массив:");
    PrintArray(arr);
    Console.WriteLine();
    QuantityNumber(arr);


}

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
}

void QuantityNumber(int [] array)
{
    int count = 0;
    for(int i = 0; i< array.Length; i++)
    {
        if(array [i] >= 10 && array [i] <= 99) count++;
    }

    if(count != 0) Console.WriteLine($"Количество числе массива находящихся в интервале от 10 до 99 равно: {count}");
    else Console.WriteLine("В данном массиве чисел лежащих в интервале от 10 до 99 нет");
}

Zadacha35();