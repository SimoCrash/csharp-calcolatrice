using csharp_calcolatrice;

Console.WriteLine($"Somma di due numeri interi: {IntNum()} + {IntNum()} = {CalcoliHelper.Somma(IntNum(), IntNum())}");
Console.WriteLine($"Somma di due numeri interi: 2 + 3 = {CalcoliHelper.Somma(2, 3)}");

static int IntNum()
{
    Random random = new();
    return random.Next(1, 4);
}


