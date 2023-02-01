Console.WriteLine("enter your three digit number");
int a = int.Parse(Console.ReadLine());
if (a < 100 || a > 1000)
{
   while (a < 100 || a > 999)
   {
    System.Console.WriteLine("you entered a wrong number, please enter another");
    a = int.Parse(Console.ReadLine());
   } 
   if (a > 99 && a < 1000)
   {
    a = a / 10;
    a = a % 10;
    Console.WriteLine(a);
   } 
}
else
{
    a = a / 10;
    a = a % 10;
    Console.WriteLine(a);
}