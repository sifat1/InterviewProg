public class sortstack 
{
    public void sorts(Stack<int> s)
    {
        
        if(s.Count >0)
        {
            int item = s.Pop();
            sorts(s);
            sortedInsert(s, item);
        }
    }

    public void sortedInsert(Stack<int> s, int item)
    {
        if(s.Count == 0|| s.Peek()<item)
        {
            s.Push(item);
            return;
        }
        int p = s.Pop();
        sortedInsert(s,item);
        s.Push(p);

    }


}

public class Mainprog
{
    public static void main()
    {
        Stack<int> ints = new();
        ints.Push(3);
        ints.Push(0);
        ints.Push(1);

        sortstack sortstack = new();

        sortstack.sorts(ints);


        while(ints.Count>0)
        {
            int temp = ints.Pop();
            Console.WriteLine(temp);
        }
    }
}