int[] array = new int[] { 1, 2, 3, 4, 5 }; // по идее должен создать массив с 5 элементами array [1, 2, 3, 4, 5]
for (int i = 0; i < array.Length / 2; i++)
{
    int tmp = array[i];
    array[i] = array[array.Length - (i + 1)];
    array[array.Length - (i + 1)] = tmp;
}
Console.WriteLine(" E_N_D ");