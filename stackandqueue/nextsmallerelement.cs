public class NextSmall
{

    public static int[] utilfun(int[] arr, int n)
    {
        int[] result = new int[n];
        Stack<int> st = new();
        for(int i = n-1; i>=0; i--)
        {
            while(st.Count > 0 && st.Peek()>arr[i])
            {
                st.Pop();
            }

            result[i] = st.Count == 0 ? -1: st.Peek();

            st.Push(arr[i]);
        }

        return result;
    }
    public static int[] findsmallnext (int[] arr)
    {
        int n = arr.Length;

        return utilfun(arr,n);
    }

    public static void main()
    {
        int[] arr = [1, 3, 2, 4]; 

        foreach(int val in findsmallnext(arr))
        {
            Console.WriteLine(val);
        }
    }
}