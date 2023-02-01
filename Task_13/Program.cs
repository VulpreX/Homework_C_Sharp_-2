Console.WriteLine("Enter your number");
long a = long.Parse(Console.ReadLine());
a = Math.Abs(a);
if (a > 99)
{
    while( a > 999)
    {
        a = a / 10;        
    }
    a = a % 10;
    Console.WriteLine(a);
}
else 
{
    Console.WriteLine("There is no third digit in this number");
    
}

