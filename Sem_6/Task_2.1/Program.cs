Console.Write("Введите десятичное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int [100];
int remainder;
string result = string.Empty;
while (N > 0)
{
    remainder = N % 2;
    N = N / 2;
    result = remainder.ToString() + result;
    Console.WriteLine (result);
}
Console.WriteLine("Двоичное {0} ", result);