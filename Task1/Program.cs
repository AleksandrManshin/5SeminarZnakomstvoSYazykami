//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна 
//-20.
void Zadacha31()
{
    int size = 12;
    int[] array = new int[size];
    FillArray(array, -5, 5);
    PrintArray(array);

    Console.WriteLine("Сумма положительных элементов массива: " + SumPositive(array));
    Console.WriteLine("Сумма отрицательных элементов массива: " + SumNegative(array));
}

int SumNegative(int [] array)
{ 
    int sumNegative = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array [i] <= 0) sumNegative += array[i];
    }
    return sumNegative;
}

int SumPositive(int [] array)
{ 
    int sumPositive = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array [i] > 0) sumPositive += array[i];
    }
    return sumPositive;
}

void FillArray(int[] array, int startNumber = 0, int finishNumber = 0)
{
    finishNumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

Zadacha31();