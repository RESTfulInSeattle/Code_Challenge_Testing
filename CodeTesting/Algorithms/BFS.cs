using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Challenges.Algorithms
{
    public class BFS
    {
        /*Given an m x n 2D binary grid which represents a map of '1's (land) and '0's (water), return the number of islands.
          An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. 
          You may assume all four edges of the grid are all surrounded by water.
        */
        public static int NumIslandsBFS(char[,] grid)
        {
            int rows = grid.GetLength(0);
            if (rows == 0) return -1;
            int cols = grid.GetLength(1);

            Queue<int[,]> queue = new Queue<int[,]>();

            int numIslands = 0;

            //Enqueue 1 as a root, changing to 0 to note it's been visited
            for(int row=0; row<rows; row++)
            {
                for(int col=0; col<cols; col++)
                {
                    if(grid[row,col]=='1')
                    {
                        int[,] node = new int[1,2];
                        node[0, 0] = row;
                        node[0, 1] = col;

                        queue.Enqueue(node);
                        grid[row,col] = '0';

                        numIslands++;

                        //walk the surrounding nodes (brute force method, doesn't look that good)
                        while (queue.Count > 0)
                        {
                            int[,] curNode = queue.Dequeue();
                            int r = curNode[0, 0];
                            int c = curNode[0, 1];

                            if (r > 0 && grid[r - 1, c] == '1')
                            {
                                int[,] n = new int[1, 2];
                                n[0, 0] = r - 1;
                                n[0, 1] = c;
                                queue.Enqueue(n);
                                grid[r - 1, c] = '0';
                            }
                            if (r < rows - 1 && grid[r + 1, c] == '1')
                            {
                                int[,] n = new int[1, 2];
                                n[0, 0] = r + 1;
                                n[0, 1] = c;
                                queue.Enqueue(n);
                                grid[r + 1, c] = '0';
                            }
                            if (c > 0 && grid[c - 1, r] == '1')
                            {
                                int[,] n = new int[1, 2];
                                n[0, 0] = r;
                                n[0, 1] = c-1;
                                queue.Enqueue(n);
                                grid[r, c - 1] = '0';
                            }
                            if (c < cols - 1 && grid[r, c + 1] == '1')
                            {
                                int[,] n = new int[1, 2];
                                n[0, 0] = r;
                                n[0, 1] = c+1;
                                queue.Enqueue(n);
                                grid[r, c + 1] = '0';
                            }
                        }
                    }
                }
                
            }

            return numIslands;
        }
    }
}
