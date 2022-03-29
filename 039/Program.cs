void ReverseArray(int[] arr)
{
    int lastIndex = arr.Length - 1;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[lastIndex - i];
    }
}