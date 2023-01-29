// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int Find_even_number(int count)
{
    
    

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
    int max = array.Max();
    int min = array.Min();
    int difference_num = max - min;

    Console.Write("] -> ");
    return difference_num;
    

    
}
// Console.WriteLine();
Console.Write("Введите колличество чисел массива: ");
int result = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine(Find_even_number(result));