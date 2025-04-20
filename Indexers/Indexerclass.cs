namespace Indexerclass 
{
    public class Employee
    {
        int i, j;
        public Employee(int a, int b)
        {
            i = a;
            j = b;
        }

        public object this[int index]
        {
            get{
                if(index == 0) return i;
                else if(index == 1) return j;
                else return null;
            }

            set{
                if(index == 0) i = Convert.ToInt32(value);
                else if(index == 1) j = Convert.ToInt32(value);
            }
        }
    }
}