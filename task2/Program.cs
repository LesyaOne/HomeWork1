Console.Write("Enter first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2)
{
    Console.Write($"First number is bigger than second number, max = {num1}, min = {num2}");
}
if(num2 > num1)
{
    Console.Write($"Second number is bigger than first number, max = {num2}, min = {num1}");
}
else Console.Write("Numbers are equals");

