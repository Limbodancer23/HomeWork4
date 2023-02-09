// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
System.Console.WriteLine("Enter Number: ");
int num = int.Parse(Console.ReadLine());

    int result = CutMethod(num);
System.Console.WriteLine($"The sum of numbers of your number = {result}");

int CutMethod(int number)
{
    int sum = 0;
    int cutNumber = 0;
    while ( num!= 0)
    {
        cutNumber = num % 10;
        sum+= cutNumber;
        num/=10;
    }
    return sum;
}