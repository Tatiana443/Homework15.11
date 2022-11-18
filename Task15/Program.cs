Console.WriteLine("Введите цифру дня недели: ");
int daynum = Convert.ToInt32(Console.ReadLine());
void CheckDay (int daynum) 
{
  if (daynum == 6 || daynum == 7) 
  {
  Console.WriteLine("Этот день выходной");
  }
  else if (daynum < 1 || daynum > 7) 
  {
    Console.WriteLine("введены неправильные данные");
  }
  else Console.WriteLine("Этот день рабочий");
}
CheckDay (daynum);





