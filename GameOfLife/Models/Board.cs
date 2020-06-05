using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace GameOfLife.Models
{
    public class Board
    {
        public bool[,] Map { get; set; }
        public Board(int rows, int columns)
        {
            Map = new bool[rows, columns];
        }

        public void ToggleCell(int row, int column)
        {
            Map[row, column] = !Map[row, column];
        }

        public void SetCell (int row, int column, bool state)
        {
            Map[row, column] = state;
        }

        public void CloneMapping(Board currentMap)
        {
            this.Map = (bool[,])currentMap.Map.Clone();
        }

        public void CopyMapping(Board CurrentBoard)
        {
            for (int r = 0; r < CurrentBoard.Map.GetLength(0); r++)
            {
                for (int c = 0; c < CurrentBoard.Map.GetLength(1); c++)
                {
                    Map[r, c] = CurrentBoard.Map[r, c];
                }
            }
        }
    }
}
