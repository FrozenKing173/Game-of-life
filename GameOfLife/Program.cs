using GameOfLife.Services;
using System;
using System.Net.Http;
using System.Windows;

namespace GameOfLife
{
    class Program
    {
        private static GameOfLifeGeneratorService _gameOfLifeGeneratorService;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! ");
            Console.WriteLine();

            // Simple Pattern
            /*_gameOfLifeGeneratorService = new GameOfLifeGeneratorService(4, 4, 8);
            _gameOfLifeGeneratorService.ToggleCell(1, 1);
            _gameOfLifeGeneratorService.ToggleCell(1, 2);
            _gameOfLifeGeneratorService.ToggleCell(2, 1);
            _gameOfLifeGeneratorService.ToggleCell(2, 2);
            _gameOfLifeGeneratorService.ToggleCell(2, 3);
            _gameOfLifeGeneratorService.ToggleCell(3, 3);
            _gameOfLifeGeneratorService.StartGame(); */

            // The Period 3 Oscillator pattern
            /*_gameOfLifeGeneratorService = new GameOfLifeGeneratorService(10, 6, 50);
            _gameOfLifeGeneratorService.ToggleCell(0, 1);
            _gameOfLifeGeneratorService.ToggleCell(1, 0);
            _gameOfLifeGeneratorService.ToggleCell(1, 1);
            _gameOfLifeGeneratorService.ToggleCell(1, 2);
            _gameOfLifeGeneratorService.ToggleCell(2, 0);
            _gameOfLifeGeneratorService.ToggleCell(2, 2);
            _gameOfLifeGeneratorService.ToggleCell(3, 0);
            _gameOfLifeGeneratorService.ToggleCell(3, 1);
            _gameOfLifeGeneratorService.ToggleCell(3, 2);
            _gameOfLifeGeneratorService.ToggleCell(4, 1);
            _gameOfLifeGeneratorService.StartGame();*/

            // The Period 3 Oscillator pattern
            /*_gameOfLifeGeneratorService = new GameOfLifeGeneratorService(1, 10, 100);
            _gameOfLifeGeneratorService.ToggleCell(0, 0);
            _gameOfLifeGeneratorService.ToggleCell(0, 1);
            _gameOfLifeGeneratorService.ToggleCell(0, 2);
            _gameOfLifeGeneratorService.ToggleCell(0, 3);
            _gameOfLifeGeneratorService.ToggleCell(0, 4);
            _gameOfLifeGeneratorService.ToggleCell(0, 5);
            _gameOfLifeGeneratorService.ToggleCell(0, 6);
            _gameOfLifeGeneratorService.ToggleCell(0, 7);
            _gameOfLifeGeneratorService.ToggleCell(0, 8);
            _gameOfLifeGeneratorService.ToggleCell(0, 9);
            _gameOfLifeGeneratorService.StartGame();*/

            // The Queen Bee Shuttle pattern
            /*_gameOfLifeGeneratorService = new GameOfLifeGeneratorService(5, 15, 8);
            _gameOfLifeGeneratorService.ToggleCell(0, 0);
            _gameOfLifeGeneratorService.ToggleCell(0, 1);
            _gameOfLifeGeneratorService.ToggleCell(1, 2);
            _gameOfLifeGeneratorService.ToggleCell(2, 3);
            _gameOfLifeGeneratorService.ToggleCell(3, 3);
            _gameOfLifeGeneratorService.ToggleCell(4, 3);
            _gameOfLifeGeneratorService.ToggleCell(5, 2);
            _gameOfLifeGeneratorService.ToggleCell(6, 0);
            _gameOfLifeGeneratorService.ToggleCell(6, 1);*/
            //_gameOfLifeGeneratorService.StartGame();

            // Toad Pattern 1
            /*_gameOfLifeGeneratorService = new GameOfLifeGeneratorService(15, 15, 50);
           _gameOfLifeGeneratorService.ToggleCell(5, 6);
           _gameOfLifeGeneratorService.ToggleCell(5, 7);
           _gameOfLifeGeneratorService.ToggleCell(5, 8);
           _gameOfLifeGeneratorService.ToggleCell(6, 5);
           _gameOfLifeGeneratorService.ToggleCell(6, 6);
           _gameOfLifeGeneratorService.ToggleCell(6, 7);
           _gameOfLifeGeneratorService.StartGame();*/


            // Blinker Pattern
            //_gameOfLifeGeneratorService = new GameOfLifeGeneratorService(5, 5, 20);
            //_gameOfLifeGeneratorService.ToggleCell(1, 2);
            //_gameOfLifeGeneratorService.ToggleCell(2, 2);
            //_gameOfLifeGeneratorService.ToggleCell(3, 2);
            //_gameOfLifeGeneratorService.StartGame();


            // Vertical Line Pattern
            /*_gameOfLifeGeneratorService = new GameOfLifeGeneratorService(20, 20, 1000);
            _gameOfLifeGeneratorService.ToggleCell(5, 5);
            _gameOfLifeGeneratorService.ToggleCell(5, 6);
            _gameOfLifeGeneratorService.ToggleCell(5, 7);
            _gameOfLifeGeneratorService.ToggleCell(5, 8);
            _gameOfLifeGeneratorService.ToggleCell(5, 9);
            _gameOfLifeGeneratorService.ToggleCell(5, 10);
            _gameOfLifeGeneratorService.ToggleCell(5, 11);
            _gameOfLifeGeneratorService.ToggleCell(5, 12);
            _gameOfLifeGeneratorService.ToggleCell(5, 13);
            _gameOfLifeGeneratorService.ToggleCell(5, 14);
            _gameOfLifeGeneratorService.ToggleCell(5, 15);
            _gameOfLifeGeneratorService.StartGame();*/

            // Horizontal Line Pattern
            /*_gameOfLifeGeneratorService = new GameOfLifeGeneratorService(30, 30, 100);
            _gameOfLifeGeneratorService.ToggleCell(11, 15);
            _gameOfLifeGeneratorService.ToggleCell(12, 15);
            _gameOfLifeGeneratorService.ToggleCell(12, 15);
            _gameOfLifeGeneratorService.ToggleCell(13, 15);
            _gameOfLifeGeneratorService.ToggleCell(14, 15);
            _gameOfLifeGeneratorService.ToggleCell(15, 15);
            _gameOfLifeGeneratorService.ToggleCell(16, 15);
            _gameOfLifeGeneratorService.ToggleCell(17, 15);
            _gameOfLifeGeneratorService.ToggleCell(18, 15);
            _gameOfLifeGeneratorService.ToggleCell(19, 15);
            _gameOfLifeGeneratorService.ToggleCell(20, 15);
            _gameOfLifeGeneratorService.StartGame();*/


            //Pulsar
            /*_gameOfLifeGeneratorService = new GameOfLifeGeneratorService(17, 17, 100);
            _gameOfLifeGeneratorService.ToggleCell(2, 4);
            _gameOfLifeGeneratorService.ToggleCell(2, 5);
            _gameOfLifeGeneratorService.ToggleCell(2, 6);

            _gameOfLifeGeneratorService.ToggleCell(2, 10);
            _gameOfLifeGeneratorService.ToggleCell(2, 11);
            _gameOfLifeGeneratorService.ToggleCell(2, 12);

            _gameOfLifeGeneratorService.ToggleCell(4, 2);
            _gameOfLifeGeneratorService.ToggleCell(4, 7);
            _gameOfLifeGeneratorService.ToggleCell(4, 9);
            _gameOfLifeGeneratorService.ToggleCell(4, 14);

            _gameOfLifeGeneratorService.ToggleCell(5, 2);
            _gameOfLifeGeneratorService.ToggleCell(5, 7);
            _gameOfLifeGeneratorService.ToggleCell(4, 9);
            _gameOfLifeGeneratorService.ToggleCell(5, 14);


            _gameOfLifeGeneratorService.ToggleCell(6, 2);
            _gameOfLifeGeneratorService.ToggleCell(6, 7);
            _gameOfLifeGeneratorService.ToggleCell(6, 9);
            _gameOfLifeGeneratorService.ToggleCell(6, 14);

            _gameOfLifeGeneratorService.ToggleCell(7, 4);
            _gameOfLifeGeneratorService.ToggleCell(7, 5);
            _gameOfLifeGeneratorService.ToggleCell(7, 6);
            _gameOfLifeGeneratorService.ToggleCell(7, 10);
            _gameOfLifeGeneratorService.ToggleCell(7, 11);
            _gameOfLifeGeneratorService.ToggleCell(7, 12);

            _gameOfLifeGeneratorService.ToggleCell(9, 4);
            _gameOfLifeGeneratorService.ToggleCell(9, 5);
            _gameOfLifeGeneratorService.ToggleCell(9, 6);
            _gameOfLifeGeneratorService.ToggleCell(9, 10);
            _gameOfLifeGeneratorService.ToggleCell(9, 11);
            _gameOfLifeGeneratorService.ToggleCell(9, 12);

            _gameOfLifeGeneratorService.ToggleCell(10, 2);
            _gameOfLifeGeneratorService.ToggleCell(10, 7);
            _gameOfLifeGeneratorService.ToggleCell(10, 9);
            _gameOfLifeGeneratorService.ToggleCell(10, 14);

            _gameOfLifeGeneratorService.ToggleCell(11, 2);
            _gameOfLifeGeneratorService.ToggleCell(11, 7);
            _gameOfLifeGeneratorService.ToggleCell(11, 9);
            _gameOfLifeGeneratorService.ToggleCell(11, 14);

            _gameOfLifeGeneratorService.ToggleCell(12, 2);
            _gameOfLifeGeneratorService.ToggleCell(12, 7);
            _gameOfLifeGeneratorService.ToggleCell(12, 9);
            _gameOfLifeGeneratorService.ToggleCell(12, 14);

            _gameOfLifeGeneratorService.ToggleCell(14, 4);
            _gameOfLifeGeneratorService.ToggleCell(14, 5);
            _gameOfLifeGeneratorService.ToggleCell(14, 6);
            _gameOfLifeGeneratorService.ToggleCell(14, 10);
            _gameOfLifeGeneratorService.ToggleCell(14, 11);
            _gameOfLifeGeneratorService.ToggleCell(14, 12);

            _gameOfLifeGeneratorService.StartGame();*/

            try
            {
                Console.Write("Please input number of rows on the board: ");
                int rows = int.Parse(Console.ReadLine());

                Console.Write("Please input number of columns on the board: ");
                int columns = int.Parse(Console.ReadLine());

                Console.Write("Please input number of generations on the board: ");
                int generations = int.Parse(Console.ReadLine());

                _gameOfLifeGeneratorService = new GameOfLifeGeneratorService(rows, columns, generations);
                bool doRandomizing = true; 
                _gameOfLifeGeneratorService.StartGame(doRandomizing);
            }
            catch (Exception e) 
            {
                // Dont make the board too big.
                string message = "Please type in a number." + e.Message.ToString();
                throw new Exception(message);
            }

            Console.ReadLine();

        }
    }
}
