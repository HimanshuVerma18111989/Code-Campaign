using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class NQueenProblem
    {
        public bool NQueen(bool[,] board, int size, int row)
        {
            if (row == size - 1)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write($"{board[i, j]}, ");
                    }
                    Console.WriteLine();
                }
                return true;
            }
            else
            {
                for (int col = 0; col < size; col++)
                {
                    int rowNew = row + 1;
                    if (IFValidCell(board, rowNew, col, size))
                    {
                        board[rowNew, col] = true;
                        if (NQueen(board, size, rowNew))
                        {
                            return true;
                        }
                        board[rowNew, col] = false;
                    }
                }
                return false;
            }
        }

        bool IFValidCell(bool[,] board, int rowNew, int colNew, int size)
        {
            bool valid = true;
            for (int i = 0; i < size; i++)
            {
                if (board[i, colNew])
                {
                    valid = false;
                }
            }
            for (int i = rowNew, j = colNew; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j])
                {
                    valid = false;
                }
            }
            for (int i = rowNew, j = colNew; i >= 0 && j < size; i--, j++)
            {
                if (board[i, j])
                {
                    valid = false;
                }
            }
            return valid;
        }
    }
}
