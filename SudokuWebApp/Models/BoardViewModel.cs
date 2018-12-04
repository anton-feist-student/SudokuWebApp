using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SudokuWebApp.Models
{
    public class BoardViewModel
    {
        public bool[][] Visibility { get; set; }
        public int[][] Numbers { get; set; }
    }
}
