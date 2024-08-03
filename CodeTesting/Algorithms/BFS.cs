using System;
using System.Collections;
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

            int numIslands = 0;

            Queue<int[,]> nodeQueue = new Queue<int[,]>();

            //Enqueue 1 as a root, changing to 0 to note it's been visited
            for(int gridRow = 0; gridRow<rows; gridRow++)
            {
                for(int gridCol = 0; gridCol<cols; gridCol++)
                {
                    if (grid[gridRow,gridCol]=='1')
                    {
                        int[,] node = new int[1, 2];
                        node[0, 0] = gridRow;
                        node[0, 1] = gridCol;

                        nodeQueue.Enqueue(node);
                        grid[gridRow, gridCol] = '0';

                        numIslands++;

                        while(nodeQueue.Count>0)
                        {
                            int[,] curNode = nodeQueue.Dequeue();

                            int curRow = curNode[0, 0];
                            int curCol = curNode[0, 1];

                            //Left
                            if (curRow>0 && grid[curRow-1,curCol]=='1')
                            {
                                int[,] newNode = new int[1, 2];
                                newNode[0, 0] = curRow - 1;
                                newNode[0, 1] = curCol;
                                //Add node to queue and mark as visited
                                nodeQueue.Enqueue(newNode);
                                grid[curRow - 1, curCol] = '0';
                            }

                            //Right
                            if(curRow<rows-1 && grid[curRow + 1, curCol] == '1')
                            {
                                int[,] newNode = new int[1, 2];
                                newNode[0, 0] = curRow + 1;
                                newNode[0, 1] = curCol;
                                //Add node to queue and mark as visited
                                nodeQueue.Enqueue(newNode);
                                grid[curRow + 1, curCol] = '0';
                            }

                            //Up
                            if (curCol>1 && grid[curRow, curCol-1] == '1')
                            {
                                int[,] newNode = new int[1, 2];
                                newNode[0, 0] = curRow;
                                newNode[0, 1] = curCol-1;
                                //Add node to queue and mark as visited
                                nodeQueue.Enqueue(newNode);
                                grid[curRow - 1, curCol-1] = '0';
                            }

                            //Down
                            if(curCol<cols-1 &&  grid[curRow, curCol+1] == '1')
                            {
                                int[,] newNode = new int[1, 2];
                                newNode[0, 0] = curRow;
                                newNode[0, 1] = curCol+1;
                                //Add node to queue and mark as visited
                                nodeQueue.Enqueue(newNode);
                                grid[curRow, curCol+1] = '0';
                            }
                        }
                    }
                }
            }

            return numIslands;
        }
    }
}
