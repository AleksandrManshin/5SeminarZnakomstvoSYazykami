// Задача 32: Напишите программу замены элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void Zadacha32()
{
    int size = 4;
    int [] arr = new int [size];
   
    Console.WriteLine("Массив:");
    FillArray(arr);
    PrintArray(arr);
    Console.WriteLine();
    Console.WriteLine("Инверсия массива:");
    Inversion(arr);
    PrintArray(arr);
}

void FillArray(int [] array)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array [i] = random.Next(-9, 10);
    }
}

void PrintArray(int [] array)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array [i] + "\t");
    }
}

void Inversion(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array [i] *= -1;
    }
}

Zadacha32();