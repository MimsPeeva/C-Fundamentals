uint B = uint.Parse(Console.ReadLine());
int count = 0;
ushort n = ushort.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    uint number = uint.Parse(Console.ReadLine());
    while (number != 0)
    {
        if ((number & 1) == B)
            count++;
        number = number >> 1;
    }
    Console.WriteLine(count);
    count = 0;
}