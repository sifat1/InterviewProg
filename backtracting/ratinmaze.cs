using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

public class ProgRat
{
    public void findpath(int[][] mat)
    {
        // we will use dfs with stact

        Stack<(int row,int col) > stack = new();
        int row = mat.Length, col = mat[0].Length ;
        int[][] direction = new int[4][]
        {
            new int[] {-1,0}, new[] {1,0},
            new int[] {0,-1}, new[] {0, 1}
        };
        stack.Push((0,0));

        while(stack.Count >0)
        {
            var (i,j) = stack.Pop();
            if (i == row-1 && j == col-1)
            {
                Console.WriteLine(" Path Found");
                return;
            }
            foreach(var d in direction)
            {
                int trow = i, tcol = j;
                trow += d[0];
                tcol += d[1];

                if(trow>=0 && trow < row && tcol>=0 && tcol < col && mat[trow][tcol] == 1)
                {
                        mat[trow][tcol] = 0;
                        stack.Push((trow,tcol));
                }
            }
        }


        
    }
}

public class ProgramMat
{
    public static void Main()
    {
        int[][] mat = new int[][]
        {
            new int[] {1, 0, 0, 0},
            new int[] {1, 1, 0, 1},
            new int[] {0, 1, 0, 0},
            new int[] {1, 1, 1, 1}
        };

        ProgRat prog = new ProgRat();
        prog.findpath(mat);
    }
}
