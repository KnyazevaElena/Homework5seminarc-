//Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000]. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2]-> 0
//[10, 11, 12, 13, 14]-> 5
Console.Clear();
int[] NewArray = GetArray (20,0,1000);
Console.WriteLine(String.Join(" ", NewArray));
Console.WriteLine($"Кол-во элементов в отрезке [10;99] = {GetCountElements(NewArray,10,99)}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int [size] ;
    for (int i =0; i<size; i++)
    {
        res [i] = new Random().Next(minValue,maxValue+1);
    }
    return res;
}
int GetCountElements(int[] array, int otrezok10, int otrezok99){

    int count = 0;
    foreach (var item in array)
    {
        if (item >= otrezok10 && item <= otrezok99) count++;
    }
     return count;
}
    