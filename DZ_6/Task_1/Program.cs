int num;
Console.Write("Введите количество элементов: ");
num = Convert.ToInt32(Console.ReadLine());
int [] array = new int [num]; // создаем массив 
int i = 0;
Console.WriteLine("Введите числа с клавиатуры (через Enter):");
while (i < num)
{
    array[i] = int.Parse(Console.ReadLine()); // dводим элементы массива с клавиатуры
    Console.WriteLine();
    i++;
}
int count = 0;
Console.Write(" Получен массив: [ ");
for (i = 0; i < num; i = i + 1)
{
    Console.Write(array[i]+ " "); // Вывод содержимого массива
    if (array[i] > 0)
    {
        count++; // счетчик для четных чисел
    }
}
Console.Write("]");
Console.WriteLine($" в котором {count} чисел (числа) > 0"); // вывод сколько положительных чисел
Console.ReadKey();
