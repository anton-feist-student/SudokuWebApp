using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SudokuWebApp.Models
{
    public class checkSolution
    {
        static bool checkSolutionFunction(int[][] answer)
        {
            for(int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    //check column
                    for(int k = 1; k < 9 - i; k++)
                    {
                        if (answer[i][j] == answer[i + k][j]) return false;
                    }

                    //check row
                    for (int k = 1; k < 9 - j; k++)
                    {
                        if (answer[i][j] == answer[i ][j + k]) return false;
                    }

                    //check square
                    if ((i == 0 || i == 3 || i == 6) & (j == 0 || j==3 || j==6))
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
                        for(itr = 0; itr < 9; itr++)
                        {
                            for(int itr2 = 1; itr2 < 9 - itr; itr2++)
                            {
                                if (squareToLine[itr] == squareToLine[itr + itr2]) return false;
                            }
                        }

                    }
                    
                }
             }

            return true;
        }
    }
}
