// Задача 4: Найти максимальное из трёх чисел.
Console.Clear();

int a = 15;
int b = 87;
int c = 95;


int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;


Console.Write("Максимальное число = ");
Console.WriteLine(max);