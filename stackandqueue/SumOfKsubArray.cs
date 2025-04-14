public class SumOfKsubArray
{
    public static int SumOfK(int[] arr, int k)
    {
        int sum = 0, n = arr.Length;
        LinkedList<int> max = new();
        LinkedList<int> min = new();

        for (int i = 0; i < n; i++)
        {
            // Remove out-of-window elements from the front
            while (max.Count > 0 && max.First.Value <= i - k)
                max.RemoveFirst();

            while (min.Count > 0 && min.First.Value <= i - k)
                min.RemoveFirst();

            // Maintain decreasing order in max deque
            while (max.Count > 0 && arr[max.Last.Value] <= arr[i])
                max.RemoveLast();
            max.AddLast(i);

            // Maintain increasing order in min deque
            while (min.Count > 0 && arr[min.Last.Value] >= arr[i])
                min.RemoveLast();
            min.AddLast(i);

            // ✅ Only add to sum when we have a full window
            if (i >= k - 1)
                sum += arr[max.First.Value] + arr[min.First.Value];
        }

        return sum;
    }
}
