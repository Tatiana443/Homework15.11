Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int ThirdDigit(int num)
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    return num % 10;
}
if (num < 100) Console.WriteLine("Третьей цифры в числе нет");
else Console.WriteLine(ThirdDigit(num));