using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SudokuWebApp.Models
{
    public class SudokuLogicModel
    {
        public static bool checkSolutionFunction(int[][] answer)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    //quick check for valid
                    if (!checkValidEntry(answer[i][j]))
                    {
                        Console.WriteLine("entry invalid " + i + " " + j);
                        return false;
                    }
                    //check column
                    for (int k = 1; k < 9 - i; k++)
                    {
                        if (answer[i][j] == answer[i + k][j]) return false;
                    }

                    //check row
                    for (int k = 1; k < 9 - j; k++)
                    {
                        if (answer[i][j] == answer[i][j + k]) return false;
                    }

                    //check square
                    if ((i == 0 || i == 3 || i == 6) & (j == 0 || j == 3 || j == 6))
                    {
                        int[] squareToLine = new int[9];
                        int itr = 0;
                        for (int k1 = 0; k1 < 3; k1++)
                        {
                            for (int k2 = 0; k1 < 3; k1++)
                            {
                                squareToLine[itr] = answer[i + k1][j + k2];
                                itr++;

                            }
                        }
                        for (itr = 0; itr < 9; itr++)
                        {
                            for (int itr2 = 1; itr2 < 9 - itr; itr2++)
                            {
                                if (squareToLine[itr] == squareToLine[itr + itr2]) return false;
                            }
                        }

                    }

                }
            }

            return true;
        }

        //set the initial visability
        public static bool[][] SudokuBoardInitialStatesFunction()
        {
            bool[][] initialBoardVisable = new bool[9][];
            for (int initialize = 0; initialize < 9; initialize++)
            {
                initialBoardVisable[initialize] = new bool[9];
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if ((i + j) % 2 == 0) initialBoardVisable[i][j] = true;
                    else initialBoardVisable[i][j] = false;
                }

            }
            return initialBoardVisable;
        }

        public static int[][] SudokuSolutionLoadFunction(string SudokuSolution)
        {
            int[][] SudokuNumbers;
            SudokuNumbers = new int[9][];
            for (int initialize = 0; initialize < 9; initialize++)
            {
                SudokuNumbers[initialize] = new int[9];
            }

            int i = 0;

            //convert each char to int value
            for (int j = 0; j < 9; j++)
            {
                for (int k = 0; k < 9; k++)
                {
                    SudokuNumbers[j][k] = SudokuSolution[i] - '0';
                    if (!checkValidEntry(SudokuNumbers[j][k])) Console.WriteLine("string reading problem");
                    i++;
                }
            }

            return SudokuNumbers;
        }

        //returns false if not a valid number for sudoku
        public static bool checkValidEntry(int value)
        {
            if (value < 1 || value > 9) return false;
            return true;
        }

       
    }
}
