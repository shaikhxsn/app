int[] arr = [1, 1, 1, 2, 2, 3, 3, 3, 3, 4, 4, 5, 5, 6, 6, 6, 7, 7, 7, 7, 8, 8, 9];
int length = ArrayUtils.RemoveDuplicates(arr);
Console.WriteLine(string.Join(", ", arr[..length]));
// Console.WriteLine("Hello from docker container!");
// Console.WriteLine(StringUtils.AreAnagramsFrequency("listen", "silent"));
// int[] arr = [1, 2, 3, 4, 5, 6, 7, 8];
// ArrayUtils.LeftRotateCyclicReplacement(arr, 4);
// Console.WriteLine(string.Join(", ", arr));
// Console.WriteLine("[1, 2, 3, 4, 5, 6, 7, 8], 3 = " + string.Join(", ", ArrayUtils.LeftRotate([1, 2, 3, 4, 5, 6, 7, 8], 5)));