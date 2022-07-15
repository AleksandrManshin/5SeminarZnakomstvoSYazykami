// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


void Zadacha33()
{
    Random random = new Random();
    int size = random.Next(4, 12);
    int[] arr = new int[size];

    FillArray(arr);
    Console.WriteLine("Массив:");
    PrintArray(arr);
    Console.WriteLine();
    Console.WriteLine("Введите искомое число:");
    int number = Convert.ToInt32(Console.ReadLine());
    string part = "не";
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == number) part = "";
    }

    Console.WriteLine("искомое число" + part + " содержится в массиве");
}


// void Zadacha33()
// {
//     int size = 5;
//     int[] arr = new int[size];

//     FillArray(arr);
//     Console.WriteLine("Массив:");
//     PrintArray(arr);
//     Console.WriteLine();
//     Find4(arr, 3);


// }

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

// void Find4(int[] array, int numb)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {

//         if (array[i] == numb)
//         {
//             count++;
//         }
//     }

//     if (count == 1) Console.WriteLine($"Число {numb} встречается в массиве {count} раз");
//     else if (count > 1) Console.WriteLine($"Число {numb} встречается в массиве {count} раза");
//     else Console.WriteLine($"Числа {numb} нету в массиве");
// }

Zadacha33();


// void Find4(int[] array, int numb)
// {
//     bool flag = false;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == numb)
//         {
//             flag = true;
//             break;
//         }
//     }

//     if(flag) Console.WriteLine($"Число {numb} есть в массиве");
//     else Console.WriteLine($"Числа {numb} в массиве нету");
// }