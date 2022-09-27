/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12  */

Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
int SummaNum(int Num)
{
    int counter = Convert.ToString(Num).Length;
    int advance = 0;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
        advance = Num - Num % 10;
        result = result + (Num - advance);
        Num = Num / 10;
    }
    return result;
}
int summNum = SummaNum(Num);
Console.WriteLine("Сумма цифр в числе =  " + summNum);
