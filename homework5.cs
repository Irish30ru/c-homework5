// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
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
        
        
    

    }
    for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                count1= count1 + array[i];
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