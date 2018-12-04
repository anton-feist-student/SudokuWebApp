using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SudokuWebApp.Models
{
    public class SudokuBoardInitialStates
    {
        

        SudokuBoardInitialStates()
        {
            bool[][] initialBoardVisable = new bool[9][];
            for (int initialize = 0; initialize < 9; initialize++)
            {
                initialBoardVisable[initialize] = new bool[9];
            }

            for (int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    if ((i + j) % 2 == 0) initialBoardVisable[i][j] = true;
                    else initialBoardVisable[i][j] = false;
                }
                
            }
        }
    }
}
