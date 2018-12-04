using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SudokuWebApp.Models
{
    public class SudokuSolutionLoad
    {
        // string from top left row by row
        int[][] SudokuNumbers;
       
  
        public SudokuSolutionLoad(string SudokuSolution) {
            SudokuNumbers = new int[9][];
            for(int initialize = 0; initialize < 9; initialize++)
            {
                SudokuNumbers[initialize] = new int[9];
            }

            int i = 0;
            for (int j = 0; j < 9; j++)
            {
                for (int k = 0; k < 9; k++)
                {
                    SudokuNumbers[j][k] = SudokuSolution[i] - '0';
                    i++;
                }
            }
            }
        }


     
    }
}
