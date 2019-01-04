using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            PermutationOfStrings permOfStrings = new PermutationOfStrings();
            permOfStrings.PermutationOfString(new char[] { 'A', 'B', 'C' }, new char[3], new int[] { 1, 1, 1 }, 0);
           


            char[,] board  = {{'G','I','Z' },
                                {'U','E','K' },
                                {'Q','S','E' }};
            bool[,] visited = {{false,false,false },
                                {false,false,false },
                                {false,false,false } };
            string word = string.Empty;
            List<string> englishDictionary = new List<string> { "GEEKS", "QUIZ", "FOR", "GO", "EUGE"};
            Boggle boggle = new Boggle();

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    visited[row,col] = true;
                    boggle.FindWord(board, visited, 0, 0, word+board[row,col],englishDictionary);
                    visited[row, col] = false;
                }
            }


            int[,] maze =  {{1,1,0,1 },
                            {0,1,1,1 },
                            {0,1,0,1 },
                            {0,1,1,1 } };
            int[,] visited1 =   {{0,0,0,0 },
                                {0,0,0,0 },
                                {0,0,0,0 },
                                {0,0,0,0 }};
            visited1[0, 0] = 1;
            RatInAMaze ratInAMaze = new RatInAMaze();
            ratInAMaze.FindPathInMaze(maze, visited1, 0, 0, 3, 3, 1);


            int[,] visited2 =   {{0,0,0,0,0,0,0,0 },
                                {0,0,0,0,0,0,0,0 },
                                {0,0,0,0,0,0,0,0 },
                                {0,0,0,0,0,0,0,0 },
                                {0,0,0,0,0,0,0,0 },
                                {0,0,0,0,0,0,0,0 },
                                {0,0,0,0,0,0,0,0 },
                                {0,0,0,0,0,0,0,0 }};
            visited2[0, 0] = 1;
            KnightTour knightTour = new KnightTour();
            knightTour.FindKnightTour(visited2, 0, 0, 1);


            bool[,] board1 = {{false,false,false,false,false,false,false,false },
                             {false,false,false,false,false,false,false,false },
                             {false,false,false,false,false,false,false,false },
                             {false,false,false,false,false,false,false,false },
                             {false,false,false,false,false,false,false,false },
                             {false,false,false,false,false,false,false,false },
                             {false,false,false,false,false,false,false,false },
                             {false,false,false,false,false,false,false,false } };
            NQueenProblem nQueen = new NQueenProblem();
            nQueen.NQueen(board1, 8, -1);
            Console.ReadLine();
        }
    }
}
