Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[100];
int i = 0;
while (N > 0)
{
    arr[i] = N % 2;
    Console.Write(arr[i]);
    N = N / 2;
    i++;
}
Console.WriteLine();
Console.WriteLine("i = " + i);

N = arr[i];
Console.WriteLine("-N- = " + N);
Console.WriteLine("arr[i] = " + arr[i]);
while (i > -1)
{
    N = N * 10 + arr[i];
    Console.WriteLine("N = " + N);
    i--;
}
Console.WriteLine(N);