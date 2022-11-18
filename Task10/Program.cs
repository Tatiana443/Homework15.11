Console.WriteLine("Введите трехзначное число num:");
int num = Convert.ToInt32(Console.ReadLine());
int secondDigit = (num / 10) % 10;
if (num < 100 | num > 999) Console.WriteLine("Число не является трехзначным");
else Console.WriteLine(secondDigit);