using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Challenges.Algorithms
{
    public class DFS
    {
        /*Given an m x n 2D binary grid which represents a map of '1's (land) and '0's (water), return the number of islands.
         An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. 
         You may assume all four edges of the grid are all surrounded by water.
       */
        public static int NumIslandsDFS(char[,] grid)
        {
            int rows = grid.GetLength(0);
            if (rows == 0) return -1;
            int cols = grid.GetLength(1);
            int numIslands = 0;

            for(int row = 0; row<rows;row++)
            {
                for(int col=0;col<cols;col++)
                {
                    if(grid[row,col]=='1')
                    {
                        numIslands++;
                        DFS_Recursive(ref grid, row, col);
                    }
                }
            }

            return numIslands;
        }

        private static void DFS_Recursive(ref char[,] grid, int row, int col)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            if (row < 0 || col < 0 || row >= rows || col >= cols || grid[row, col] == '0') return;

            grid[row, col] = '0';
            DFS_Recursive(ref grid, row - 1, col);
            DFS_Recursive(ref grid, row + 1, col);
            DFS_Recursive(ref grid, row, col-1);
            DFS_Recursive(ref grid, row, col+1);
        }
    }
}
