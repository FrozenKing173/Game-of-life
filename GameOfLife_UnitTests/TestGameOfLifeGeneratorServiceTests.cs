using GameOfLife.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
using Xunit;
using System.Threading;

namespace GameOfLife_UnitTests
{
    public class TestGameOfLifeGeneratorServiceTests
    {
        private GameOfLifeGeneratorService _sut;

        /// <summary>
        /// a Test for GameOfLifeGeneratorService constructor
        ///</summary>
        [Fact]
        public void GameOfLifeGeneratorService_GivenThis_NewInstance_ShouldBe_InitializedWithZeroCurrentGeneration()
        {
            const int ROWS = 6;
            const int COLUMNS = 6;
            const int MAX_GENERATIONS = 12;

            _sut = new GameOfLifeGeneratorService(ROWS, COLUMNS, MAX_GENERATIONS);

            Assert.False(_sut.CurrentGeneration > 0);
        }

        /// <summary>
        /// a Test for GameOfLifeGeneratorService constructor
        ///</summary>
        [Fact]
        public void NewGameOfLifeGeneratorService_GivenWith_RowsAndColumnsAndMaxGenerations_ShouldBe_InitializedWithMaxNumberOfGenerations()
        {
            const int ROWS = 6;
            const int COLUMNS = 6;
            const int MAX_GENERATIONS = 12;

            _sut = new GameOfLifeGeneratorService(ROWS, COLUMNS, MAX_GENERATIONS);

            Assert.False(_sut.MaxGenerations == 2);
        }


        /// <summary>
        /// a Test for GameOfLifeGeneratorService mutation process with no life.
        ///</summary>
        [Fact]
        public void Mutate_GivenWith_DeadMap_ShouldBe_MutatedCurrentBoardWithZeroLifeCounts()
        {
            const int ROWS = 6;
            const int COLUMNS = 6;
            const int MAX_GENERATIONS = 12;

            _sut = new GameOfLifeGeneratorService(ROWS, COLUMNS, MAX_GENERATIONS);

            _sut.Mutate();

            for (int r = 0; r < _sut.CurrentBoard.Map.GetLength(0); r++)
            {
                for (int c = 0; c < _sut.CurrentBoard.Map.GetLength(1); c++)
                {
                    Assert.False(_sut.CurrentBoard.Map[r, c]);
                }
            }
        }

        /// <summary>
        /// a Test for GameOfLifeGeneratorService mutation process with some life.
        ///</summary>
        [Fact]
        public void Mutate_GivenWith_PopulatedCell_ShouldBeCurrentBoardMutatedWithNewGeneration_ReturnsDeadCells()
        {
            const int ROWS = 6;
            const int COLUMNS = 6;
            const int MAX_GENERATIONS = 12;

            _sut = new GameOfLifeGeneratorService(ROWS, COLUMNS, MAX_GENERATIONS);

            _sut.ToggleCell(0, 0);
            _sut.Mutate();

            int countLivePopulation = 0;
            for (int r = 0; r < _sut.CurrentBoard.Map.GetLength(0); r++)
            {

                for (int c = 0; c < _sut.CurrentBoard.Map.GetLength(1); c++)
                {
                    if (_sut.CurrentBoard.Map[r, c] == true)
                        countLivePopulation++;
                }
            }

            Assert.False(countLivePopulation > 0);
        }

        /// <summary>
        /// a Test for GameOfLifeGeneratorService mutation process with some population.
        ///</summary>
        [Fact]
        public void Mutate_GivenWith_CellWithNearPopulation_ShouldBe_CurrentBoardMutatedWithNewGeneration_ReturnsAliveCells()
        {
            const int ROWS = 6;
            const int COLUMNS = 6;
            const int MAX_GENERATIONS = 12;

            _sut = new GameOfLifeGeneratorService(ROWS, COLUMNS, MAX_GENERATIONS);

            _sut.ToggleCell(0, 0);
            _sut.ToggleCell(0, 1);
            _sut.ToggleCell(0, 2);
            _sut.Mutate();

            int countLivePopulation = 0;
            for (int r = 0; r < _sut.CurrentBoard.Map.GetLength(0); r++)
            {
                for (int c = 0; c < _sut.CurrentBoard.Map.GetLength(1); c++)
                {
                    if (_sut.CurrentBoard.Map[r, c] == true)
                        countLivePopulation++;
                }
            }
            Assert.True(countLivePopulation > 1);
        }

        /// <summary>
        /// a Test for GameOfLifeGeneratorService with some population mutating to a new board.
        ///</summary>
        [Fact]
        public void Mutate_GivenPopulation_ShouldBe_NewMutatedBoard_Returns_NewInstanceOfBoard()
        {
            const int ROWS = 4;
            const int COLUMNS = 4;
            const int MAX_GENERATIONS = 2;

            _sut = new GameOfLifeGeneratorService(ROWS, COLUMNS, MAX_GENERATIONS);
            _sut.ToggleCell(2, 1);
            _sut.ToggleCell(2, 2);
            _sut.ToggleCell(2, 3);

            bool[,] map = _sut.CurrentBoard.Map;
            _sut.Mutate();

            Assert.False(Object.ReferenceEquals(map, _sut.CurrentBoard.Map));
        }

        /// <summary>
        /// a Test for GameOfLifeGeneratorService with blinker pattern.
        ///</summary>
        [Fact]
        public void Mutate_GivenWithBlinkerPattern_ShouldBe_BoardWithBlinkerPattern()
        {
            const int ROWS = 4;
            const int COLUMNS = 4;
            const int MAX_GENERATIONS = 2;

            _sut = new GameOfLifeGeneratorService(ROWS, COLUMNS, MAX_GENERATIONS);
            _sut.ToggleCell(2, 1);
            _sut.ToggleCell(2, 2);
            _sut.ToggleCell(2, 3);

            _sut.Mutate();

            Assert.True(_sut.CurrentBoard.Map[1, 2]);
            Assert.True(_sut.CurrentBoard.Map[2, 2]);
            Assert.True(_sut.CurrentBoard.Map[3, 2]);
        }

    }
}
