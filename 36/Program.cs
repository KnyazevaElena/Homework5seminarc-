﻿//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//3, 7, 23, 12] -> 19   //[-4, -6, 89, 6] -> 0

Console.Clear();
int[] array = GetArray(4, 1, 10);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine ($"Сумма элеиентов на нечетных позициях = {GetSum(array)}");
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int GetSum (int []array){
    int Sumposition = 0;
    for (int i =0; i< array.Length; i++)
    {
        int elements = array [i];
        if (i %2 ==0) {
            Sumposition = elements+Sumposition;
        }  
    }
     return Sumposition;  
}