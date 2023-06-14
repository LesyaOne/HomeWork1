Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
{
    Console.Write($"Number {number} is even");
}
else Console.WriteLine($"Number {number} is odd");
