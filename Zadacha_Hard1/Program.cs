
Num1:

Console.WriteLine("Введите количество строк в массиве: ");
int firstSize = int.Parse(Console.ReadLine()!);

if (firstSize < 1)
{
    Console.WriteLine($"Количество строк не может быть меньше 1, попробуйте еще раз");
    goto Num1;
}

Num2:

Console.WriteLine("Введите количество столбцов в массиве: ");
int secondSize = int.Parse(Console.ReadLine()!);

if (secondSize < 1)
{
    Console.WriteLine($"Количество столбцов не может быть меньше 1, попробуйте еще раз");
    goto Num2;
}

Console.WriteLine();

int[,] array = new int[firstSize, secondSize];

Console.WriteLine("Полученный массив: ");

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Массив после сортировки: ");

int[,] result = ArraySort(array);
PrintArray(result);
Console.WriteLine();





void PrintArray(int[,] array)
{
    int count_x = array.GetLength(0);
    int count_y = array.GetLength(1);

    for (int i = 0; i < count_x; i++)
    {
        for (int j = 0; j < count_y; j++)
            Console.Write(array[i, j] + "    ");
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

int[,] ArraySort(int[,] array) 
{
    int Count1 = array.GetLength(0); 
    int Count2 = array.GetLength(1);

    int[] tempArray = new int[Count1 * Count2]; 
    int tempIndex = 0;

    for (int i = 0; i < Count1; i++)  
    {
        for (int j = 0; j < Count2; j++)
        {
            tempArray[tempIndex] = array[i, j];
            tempIndex++;
        }
    }

    Array.Sort(tempArray); 

    int[,] result = new int[Count1, Count2]; 

    tempIndex = 0; 

    for (int i = 0; i < Count1; i++) 
    {
        for (int j = 0; j < Count2; j++)
        {
            result[i, j] = tempArray[tempIndex];
            tempIndex++;
        }
    }

    return result;
}



