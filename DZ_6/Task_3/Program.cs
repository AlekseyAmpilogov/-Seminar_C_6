Console.Write("Задайте размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine()); // задаем размер массива
int[] array = new int[size]; // создаем массив
Console.Write("Получен массив: ");
FillArray(array);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($" {array[i]} "); // вывод полученного массива на экран
    }
}
int productArray = 0;
int sumArray= 0;

for (int i = 0; i < size/2; i++)
{
    productArray = array[i] * array[size-(i+1)];
    sumArray = sumArray + productArray;
}    
Console.WriteLine($"\nСумма произведений пар чисел массива = {sumArray}\n");