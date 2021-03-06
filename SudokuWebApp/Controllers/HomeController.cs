﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SudokuWebApp.Models;

namespace SudokuWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            BoardViewModel board = new BoardViewModel
            {
                Visibility = SudokuLogicModel.SudokuBoardInitialStatesFunction(),
                Numbers = SudokuLogicModel.SudokuSolutionLoadFunction(SudokuTestNumbers.SudokuSolution)
            };
            return View(board);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
