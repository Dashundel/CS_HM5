//2)Показать числа Фибоначчи

Console.WriteLine("До какого числа показать числа Фибоначчи: ");
int num = int.Parse(Console.ReadLine());

int a1 = 0;
int a2 = 1;
int t = 0;

Console.WriteLine("Ряд Фибоначчи: ");
if(num > 0) Console.Write(a1 + " " + a2 + " ");
else Console.WriteLine("Такого числа в ряде Фибоначчи нет");	

while (a1 + a2 <= num)
{
	Console.Write((a1 + a2) + " ");
	t = a2;
	a2 = a1 + a2;
	a1 = t;
}

