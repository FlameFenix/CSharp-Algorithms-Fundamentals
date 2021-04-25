using System;
using System.Collections.Generic;

namespace FindAllPathsInALabyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            char[,] matrix = new char[rows, cols];

            FillMatrix(matrix);

            List<char> directions = new List<char>();
            char direction = '\0';
            FindAllPathsInALabyrinth(matrix, 0, 0, directions, direction);
        }

        private static void FindAllPathsInALabyrinth(char[,] matrix, int row, int col, List<char> directions, char direction)
        {
            if(isOutside(matrix, row, col) ||
                isWall(matrix, row, col) || 
                isVisited(matrix, row,col))
            {
                return;
            }

            if(isEnd(matrix,row,col))
            {
                directions.Add(direction);
                Console.WriteLine(string.Join("", directions));
                directions.RemoveAt(directions.Count - 1);
                return;
            }

            matrix[row, col] = 'v';

            directions.Add(direction);

            FindAllPathsInALabyrinth(matrix, row - 1, col, directions, 'U'); // Up
            FindAllPathsInALabyrinth(matrix, row + 1, col, directions, 'D'); // Down
            FindAllPathsInALabyrinth(matrix, row, col - 1, directions, 'L'); // Left
            FindAllPathsInALabyrinth(matrix, row, col + 1, directions, 'R'); // Right
            directions.RemoveAt(directions.Count - 1);
            matrix[row, col] = '-';

        }

        private static bool isEnd(char[,] matrix, int row, int col)
        {
            return matrix[row, col] == 'e';
        }

        private static bool isVisited(char[,] matrix, int row, int col)
        {
            return matrix[row, col] == 'v';
        }

        private static bool isWall(char[,] matrix, int row, int col)
        {
            return matrix[row, col] == '*';
        }

        private static bool isOutside(char[,] matrix, int row, int col)
        {
            return row < 0 ||
                   row >= matrix.GetLength(0) ||
                   col < 0 ||
                   col >= matrix.GetLength(1);
        }

        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentLine = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentLine[col];
                }
            }
        }
    }
}
