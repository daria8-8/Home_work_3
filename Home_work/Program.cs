
void Ex19()
{
Console.WriteLine("Введите число : ");
int NumberOne(int num, int NumberOfFirstNumber)
{
    while (num / Math.Pow(10, NumberOfFirstNumber) > 1)
    {
        num/=10;
    }
    return num;
}
int number = int.Parse(Console.ReadLine());
if(number < 0) number *=-1;
if(number > 99)
{
int x = number % 100;
int y = NumberOne(number,2);
if(x/10 == y%10 && x%10 == y/10)
{
   Console.WriteLine("Это палиндром"); 
} else
{
    Console.WriteLine("Это не палиндром");
}
} else if (number > 9)
{
    int x = number % 10;
    int y  = NumberOne(number,1);
} else
{
    Console.WriteLine("Введите число больше 9");
}
}

void Ex21()
{
Console.WriteLine("Введите координату X первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки: ");
int z2 = int.Parse(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine("{0: 0.00}", length);
}

void Ex23()
{
    Console.WriteLine("Введите число N: ");
    int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{ 
    int result = i*i*i;
    Console.Write("{0} ", result);
}
}
Ex19();
Ex21();
Ex23();