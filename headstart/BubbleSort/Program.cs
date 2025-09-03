int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };
int Pass;
int Temp;
for (Pass = 1; Pass < 6; Pass++)
{
    for (int i = 0; i < 6; i++)
    {
        if (numbers[i] > numbers[i + 1])
        {
            Temp = numbers[i];
            numbers[i] = numbers[i + 1];
            numbers[i + 1] = Temp;
        }
    }
}

Console.WriteLine("Sorted array:");
foreach (int number in numbers)
{
    Console.Write(number + " ");
}