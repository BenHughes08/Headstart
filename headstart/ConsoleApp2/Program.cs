int decNum;
int bit;

Console.WriteLine("Enter a decimal integer to convert: ");
decNum = Convert.ToInt32(Console.ReadLine());

string binStr;
binStr = "";

while (decNum > 0)
{
    bit = decNum % 2;
    binStr = bit + binStr;
    decNum = decNum / 2;
}

Console.WriteLine("Binary representation: " + binStr);