using csharp_calcolatrice;

Console.WriteLine($"Somma di due numeri interi: 2 + 3 = {CalcoliHelper.Somma(2, 3)}");
Console.WriteLine($"Somma di due numeri decimali: 2.5 + 3.7 = {CalcoliHelper.Somma(2.5, 3.7)}");
Console.WriteLine($"Differenza di due numeri interi: 7 - 4 = {CalcoliHelper.Differenza(7, 4)}");
Console.WriteLine($"Differenza di due numeri decimali: 7.7 - 2.3 = {CalcoliHelper.Differenza(7.7, 2.3)}");
Console.WriteLine($"Moltiplicazione di due numeri interi: 2 x 3 = {CalcoliHelper.Moltiplicazione(2, 3)}");
Console.WriteLine($"Moltiplicazione di due numeri decimali: 2.5 x 3.7 = {CalcoliHelper.Moltiplicazione(2.5, 3.7)}");
Console.WriteLine($"Il valore assoluto di -10 è {CalcoliHelper.ValoreAssoluto(-10)}");
Console.WriteLine($"Il valore assoluto di -10.7 è {CalcoliHelper.ValoreAssoluto(-10.7)}");
Console.WriteLine($"Il numero intero minore tra 4 e 5 è {CalcoliHelper.NumMin(5, 5)}");
Console.WriteLine($"Il numero decimale minore tra 8.2 e 6.4 è {CalcoliHelper.NumMin(8.2, 6.4)}");
Console.WriteLine($"Il numero intero maggiore tra 4 e 5 è {CalcoliHelper.NumMax(4, 5)}");
Console.WriteLine($"Il numero decimale maggiore tra 8.2 e 6.4 è {CalcoliHelper.NumMax(8.2, 6.4)}");



//a^-x = 1 / a^x
//potenza(a,-x) = 1 / potenza(a, x)
//potenza(a, x) = 1 / potenza(a, -x)[quando x < 0]
//potenza(2, -2) = ....1 / potenza(2, -(-2))


