// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.Clear();
int[] startArray = GetArray(10, 20, 50);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Разница = {GetDifference(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue +1) ;
    }
    return res;
}

int GetDifference(int[] array)
{
    int min = array[0];
    int max = array[0];
    
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    Console.WriteLine($"{min}, {max}");
    return max - min;
}