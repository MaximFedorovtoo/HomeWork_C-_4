//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

void ExponentiationNumb(int number, int expone)
{
    double result = Math.Pow(number,expone);
    Console.WriteLine($"{number} в степени {expone} = {result}");
}
int EnterNumb(string text)
{
    Console.Write(text);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int number = EnterNumb("Введите число ");
int expone = EnterNumb("Введите в какую степень необходимо возвести число ");
ExponentiationNumb(number,expone);
