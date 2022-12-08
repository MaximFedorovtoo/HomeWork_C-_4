//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
void WriteArray (int [] array)
{
    for( int i =0; i < array.Length; i++ )
    {
        Console.Write($"{array[i]}, ");
    }
}
int [] AddArray(int [] array)
{
    for( int i =0; i < array.Length; i++ )
    {
        Console.WriteLine($"Введите {i}-й элемент массива: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}
int [] array = new int [8];
array = AddArray(array);
WriteArray(array);