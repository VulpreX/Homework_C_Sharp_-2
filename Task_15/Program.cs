string[] day = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
Console.WriteLine("enter number 1-7");
int a = int.Parse(Console.ReadLine());
a = a - 1;
if (a < 5 && a >= 0 )
{
    System.Console.WriteLine($"{day[a]} is not day of");
}
if(a >= 5 && a <= 6)
{
    System.Console.Write($"{day[a]} is day of");
}
if(a > 6)
{
    System.Console.WriteLine(" There is no such day of the week");
}