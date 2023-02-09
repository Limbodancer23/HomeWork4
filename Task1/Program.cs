// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
System.Console.WriteLine("Enter Number A: ");
int numA = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter Number B: ");
int numB = int.Parse(Console.ReadLine());

int Expo(int someNumber)
{
    int result = numA;
    for (int i = 1; i < numB; i++)
    {
        result = result * numA;
    }
    return result;
}
int exp = Expo(numA);
System.Console.WriteLine($"(numA ^ numB) ={exp}");