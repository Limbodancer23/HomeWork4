// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void FillRandom(int[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        arr[index] = new Random().Next(0, 100);
    }
}

void PrintArr(int[] stracture)
{
    int count = stracture.Length;
    for (int pos = 0; pos < count; pos++)
    {
        if ( pos == 0)
        {
             System.Console.Write("[" + stracture[pos]+ ", ");
        }
        else if(pos < count -1)
        {
        System.Console.Write(stracture[pos] + ", ");
        }
       else
        {
            System.Console.Write(stracture[pos] + "]");
        }
    }

}

int[] array = new int[8];

FillRandom(array);
PrintArr(array);

