
public class StactSort
{
    public void SortStack(Stack<int> ints)
    {
        if(ints.Count > 0)
        {
            int val = ints.Pop();
            SortStack(ints);
            SortUtil(ints,val);

        }
    }

    private void SortUtil(Stack<int> ints, int val)
    {
        if(ints.Count == 0 || ints.Peek()>val)
        {
            ints.Push(val);
            return;
        }
        int valg = ints.Pop();
        SortUtil(ints,val);
        ints.Push(valg);
    }
}

public class Prog
{
    public static void main()
    {
        Stack<int> ints = new();
        ints.Push(3);
        ints.Push(0);
        ints.Push(1);

        StactSort sortstack = new();

        sortstack.SortStack(ints);


        while(ints.Count>0)
        {
            int temp = ints.Pop();
            Console.WriteLine(temp);
        }
    }
}