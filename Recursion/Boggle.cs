using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Boggle
    {
        int[] pathRow = { 0, 0, 1, 1, -1, 1, -1, -1 };
        int[] pathCol = { 1, -1, -1, 1, 1, 0, 0, -1 };

        public void FindWord(char[,] board, bool[,] visited, int row, int col, string word, List<string> englishDic)
        {
            //Console.WriteLine(word);
            if (englishDic.Contains(word))
            {
                Console.WriteLine(word);
            }
            if (board.Length == word.Length)
            {
                return;
            }
            for (int i = 0; i < pathRow.Length; i++)
            {
                int rowNew = row + pathRow[i];
                int colNew = col + pathCol[i];
                if (IFValid(rowNew, colNew, visited))
                {
                    visited[rowNew, colNew] = true;
                    FindWord(board, visited, rowNew, colNew, word + board[rowNew, colNew], englishDic);
                    visited[rowNew, colNew] = false;
                }
            }
        }

        private static bool IFValid(int rowNew, int colNew, bool[,] visited)
        {
            if ((rowNew >= 0) && (colNew >= 0) && (rowNew < 3) && (colNew < 3) && (!visited[rowNew, colNew]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
