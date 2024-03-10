/// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

Console.Clear();
int[]array = [1,2,5,0,10,34];
int size = array.Length;
void ArrayReverse (int[]array, int size)
{
    if (size==0)
    {
        return;
    }

Console.Write($"{array[size-1]} ");
ArrayReverse(array, size-1);
}
ArrayReverse(array,size);
