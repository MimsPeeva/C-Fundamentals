double foodInKg = double.Parse(Console.ReadLine());
double hayInKg = double.Parse(Console.ReadLine());
double coverInKg = double.Parse(Console.ReadLine());
double weightInKg = double.Parse(Console.ReadLine());
foodInKg *= 1000;
hayInKg *= 1000;
coverInKg *= 1000;
weightInKg *= 1000;
for (int i = 1; i <= 30; i++)
{
    if (i % 1 == 0)
    {
        foodInKg -= 300;
        if (foodInKg <= 0) { break; }
    }
    if (i % 2 == 0)
    {
        hayInKg -= 0.05 * foodInKg;
        if (hayInKg <= 0) { break; }
    }
    if (i % 3 == 0)
    {
        coverInKg -= 0.3333333 * weightInKg;
        if (coverInKg <= 0) { break; }
    }
}
foodInKg /= 1000;
hayInKg /= 1000;
coverInKg /= 1000;
if (foodInKg > 0 && hayInKg > 0 && coverInKg > 0)
{
    Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodInKg:f2}, Hay: {hayInKg:f2}, Cover: {coverInKg:f2}.");
}
else Console.WriteLine($"Merry must go to the pet store!");
