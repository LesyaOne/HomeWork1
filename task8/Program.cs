Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 1)
{
    int temp = 2;
    Console.Write("Even numbers: ");
    while(temp<=number)
    {
        Console.Write($"{temp}, ");
        temp = temp + 2;
    }
}
if(number < 1)
{
    int temp = 0;
    Console.Write("Even numbers: ");
    while(temp>=number)
    {
        Console.Write($"{temp}, ");
        temp = temp - 2;
    }
}
if(number==1) Console.Write("Your number is 1, ERROR!");
