//{ Driver Code Starts
// Initial Template for C#
using System;
using System.Collections.Generic;

// Position this line where user code will be pasted.

class ProgQ
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());

        for (int t = 0; t < testCases; t++)
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[,] matrix = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                string[] rowValues = Console.ReadLine().Split();
                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = int.Parse(rowValues[j]);
                }
            }

            Solution obj = new Solution();
            Console.WriteLine(obj.OrangesRotting(matrix));
            Console.WriteLine("~");
        }
    }
}
// } Driver Code Ends


class Solution
{
public int OrangesRotting(int[,] mat)
{
    Queue<(int row, int col, int time)> q = new Queue<(int, int, int)>();

    int row = mat.GetLength(0), col = mat.GetLength(1), fresh = 0, maxtime = 0;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (mat[i, j] == 2)
                q.Enqueue((i, j, 0));
            else if (mat[i, j] == 1)
                fresh++;
        }
    }

    int[][] directions = new int[4][] {
        new int[] {-1, 0}, new int[] {1, 0},
        new int[] {0, -1}, new int[] {0, 1}
    };

    int total = 0;

    while (q.Count > 0)
    {
        var (i, j, t) = q.Dequeue();
        maxtime = Math.Max(t, maxtime);

        foreach (var dir in directions)
        {
            int newRow = i + dir[0];
            int newCol = j + dir[1];

            if (newRow >= 0 && newRow < row && newCol >= 0 && newCol < col && mat[newRow, newCol] == 1)
            {
                mat[newRow, newCol] = 2;
                q.Enqueue((newRow, newCol, t + 1));
                total++;
            }
        }
    }

    return total == fresh ? maxtime : -1;
}

}

