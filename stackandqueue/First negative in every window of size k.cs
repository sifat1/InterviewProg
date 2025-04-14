public class Fistneg
{
   public static int[] firstneg(int[] arr, int k)
    {
        int start = 0, end = 0, n = arr.Length;
        List<int> result = new();
        Queue<int> q = new();

        while (end < n)
        {
            // Only enqueue index if the element is negative
            if (arr[end] < 0)
                q.Enqueue(end);

            if ((end - start + 1) < k)
            {
                end++;
            }
            else if ((end - start + 1) == k)
            {
                // Add first negative number in window to result
                if (q.Count > 0)
                    result.Add(arr[q.Peek()]);
                else
                    result.Add(0);

                // Remove out-of-window negative index
                if (q.Count > 0 && q.Peek() == start)
                    q.Dequeue();

                start++;
                end++;
            }
        }

        return result.ToArray();
    }
}