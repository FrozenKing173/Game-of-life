using GameOfLife.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;

namespace GameOfLife.Services
{
    public class GameOfLifeGeneratorService
    {
        // RUN-TIME Properties FOR DISPLAY
        private const int DELAY = 100;
        private const char DEAD_CELL = ' ';
        private const char ALIVE_CELL = '\u2588';

        // THE BOARD
        public Board CurrentBoard { get; private set; }
        public int CurrentGeneration { get; private set; }
        public int MaxGenerations { get; private set; }
        private int BoardHeight;
        private int BoardWidth;

        // IF True THEN loops around edges WHEN Mutates
        private static bool LoopEdges = true;

        public GameOfLifeGeneratorService(int boardRows, int boardColumns, int numOfMaxGenerations)
        {
            CurrentBoard = new Board(boardRows, boardColumns);

            CurrentGeneration = 0;
            MaxGenerations = numOfMaxGenerations;

            BoardHeight = boardRows;
            BoardWidth = boardColumns;
        }

        public void ToggleCell(int r, int c)
        {
            CurrentBoard.Map[r, c] = !CurrentBoard.Map[r, c];
        }

        public void ToggleAllCells()
        {
            for (int r = 0; r < CurrentBoard.Map.GetLength(0); r++)
            {
                for (int c = 0; c < CurrentBoard.Map.GetLength(1); c++)
                {
                    CurrentBoard.Map[r, c] = !CurrentBoard.Map[r, c];
                }

            }
        }

        public void SetRandomCells()
        {
            Random random = new Random();

            for (var r = 0; r < BoardHeight; r++)
            {
                for (var c = 0; c < BoardWidth; c++)
                {
                    CurrentBoard.Map[r, c] = random.Next(2) == 0;
                }
            }
        }

        public void Initialize()
        {
            Console.Clear();
            Console.CursorVisible = false;

            int width = Math.Max(BoardWidth, 8) * 2 + 1;
            int height = Math.Max(BoardHeight, 8) + 1;

            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);

        }

        public void StartGame(bool randomize = false)
        {
            if (randomize)
                SetRandomCells();
            Initialize();

            while ( CurrentGeneration++ < MaxGenerations )
            {
                Display();
                Mutate();

                Thread.Sleep(DELAY);
            }
        }

        public void Mutate()
        {
            bool[,] newMap = new bool[BoardWidth, BoardHeight];

            for (var r = 0; r < BoardHeight; r++)
            {
                for (var c = 0; c < BoardWidth; c++)
                {
                    int population = GetCurrentBoardMapNeighbors(r, c);
                    bool state = CurrentBoard.Map[r, c];

                    newMap[r, c] = state && (population == 2 || population == 3) || !state && population == 3;
                }
            }

            CurrentBoard.Map = newMap;
        }

        private int GetCurrentBoardMapNeighbors(int row, int column)
        {
            int numOfAliveNeighbors = 0;

            for (var x = -1; x <= 1; x++)
            {
                if (!LoopEdges && column + x < 0 || column + x >= BoardHeight)
                {
                    continue;
                }

                int posK = (column + x + BoardHeight) % BoardHeight;

                for (var y = -1; y <= 1; y++)
                {
                    if (!LoopEdges && row + y < 0 || row + y >= BoardWidth)
                    {
                        continue;
                    }

                    int posH = (row + y + BoardWidth) % BoardWidth;
                    numOfAliveNeighbors += CurrentBoard.Map[posH, posK] ? 1 : 0;
                }
            }
            return numOfAliveNeighbors - (CurrentBoard.Map[row, column] ? 1 : 0);
        }

        private  void Display()
        {
            var builder = new StringBuilder();

            for (var r = 0; r < BoardHeight; r++)
            {
                for (var c = 0; c < BoardWidth; c++)
                {
                    char ch = CurrentBoard.Map[c, r] ? ALIVE_CELL : DEAD_CELL;

                    builder.Append(ch);
                    builder.Append(ch);
                }
                builder.Append('\n');
            }

            Console.SetCursorPosition(0, 0);
            Console.Write(builder.ToString());
        }
    }
}
