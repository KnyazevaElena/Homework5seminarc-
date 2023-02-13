// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных 
//чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
int[] array = GetRandomArray(4, 100, 1000);
Console.WriteLine(String.Join(", ", array));
 Console.WriteLine($"Количество четных чисел = {EvenArray(array)}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }

    return result;
}
int EvenArray(int[] array){
    int count =0;
    for (int i = 0; i < array.Length; i++)
    if (array [i]%2 == 0)
    {
        count++;
    }
    return count;
    }
    
    























// Console.Clear();
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] size = new int[size];
// FillArrayRandomNumbers(size);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(size);
// int count = 0;

// for (int z = 0; z < size.Length; z++)
// if (size[z] % 2 == 0)
// count++;

// Console.WriteLine($"всего {size.Length} чисел, {count} из них чётные");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }