using System;

namespace Unique_Paths
{
  class Program
  {
    static void Main(string[] args)
    {
      Solution s = new Solution();
      var result = s.UniquePaths(3, 7);
      Console.WriteLine(result);
    }
  }

  public class Solution
  {
    public int UniquePaths(int m, int n)
    {
      if (m == 0 || n == 0) return 1;
      int[][] arr = new int[m][];
      for (int i = m - 1; i >= 0; i--)
      {
        arr[i] = new int[n];
        for (int j = n - 1; j >= 0; j--)
        {
          // We are setting the last row and last column as 1
          // Because for the boundary position we can not go either to right(when at last column) or down(when at last row), so only one way is possible
          if (i == m - 1 || j == n - 1)
          {
            arr[i][j] = 1;
          }
          else
          {
            // If not boundary position, we can go right OR down
            // so at any position the possibility would be, sum of next right + down 
            arr[i][j] = arr[i][j + 1] + arr[i + 1][j];
          }
        }
      }

      // finally we have the answer at 0,0
      return arr[0][0];
    }
  }
}
