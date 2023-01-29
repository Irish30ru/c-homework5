// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int Find_even_number(int count)
{
    int count1 = 0;

    

    int[] array = new int[count];
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);

    }


    foreach (int n in array)
    {

        Console.Write($"{n}, ");
        if (n % 2 == 0)
        {
            count1 += 1;
        }

    }
    Console.Write("] -> ");
    return count1;
    
    
}
// Console.WriteLine();
Console.Write("Введите колличество чисел массива: ");
int result = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine(Find_even_number(result));