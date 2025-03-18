internal class ArrayUtils
{
    public static int[] LeftRotate(int[] arr, int k)
    {
        int n = arr.Length;
        k = k % n;

        Reverse(arr, 0, k - 1);
        Reverse(arr, k, n - 1);
        Reverse(arr, 0, n - 1);

        return arr;
    }

    public static void LeftRotateCyclicReplacement(int[] arr, int k)
    {
        int n = arr.Length;
        k = k % n;
        int count = 0;

        for (int start = 0; count < n; start++)
        {
            int current = start;
            int prevValue = arr[start];

            do
            {
                int next = (current + k) % n;
                (arr[next], prevValue) = (prevValue, arr[next]);
                current = next;
                count++;
            }
            while (start != current);
        }
    }

    public static void Reverse(int[] arr, int start, int end)
    {
        while (start < end)
        {
            (arr[start], arr[end]) = (arr[end], arr[start]);
            start++;
            end--;
        }
    }
}