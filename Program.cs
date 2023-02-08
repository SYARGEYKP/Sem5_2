// Задайте одномерный массив, заполненный случайными числами. Найдите
//  сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] GenerateArray(int len = 4)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
    return array;
}
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item} ");
    }
}
int SumNeChet (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        sum= sum+array[i];
    }
    return sum;
}
int[] array = GenerateArray();
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма чисел, стоящих на нечетнх позициях равна {SumNeChet(array)}");
