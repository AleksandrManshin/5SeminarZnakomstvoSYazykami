// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

void Zadacha33()
{ 
    int size = 5;
    int [] arr = new int [size];

    FillArray(arr);
    Console.WriteLine("Массив:");
    PrintArray(arr);
    Console.WriteLine();
    Find4(arr, 3);


}

void FillArray(int [] array)
{ 
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array [i] = random.Next(1,10);
    }
}

void PrintArray(int [] array)
{
   for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array [i] + "\t");
    } 
}

void Find4(int [] array, int numb)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        
        if(array [i] == numb)
        {
            count++;
        }
    }
    
    if(count == 1) Console.WriteLine($"Число {numb} встречается в массиве {count} раз");
    else if(count > 1) Console.WriteLine($"Число {numb} встречается в массиве {count} раза");
    else Console.WriteLine($"Числа {numb} нету в массиве");
}

Zadacha33();
