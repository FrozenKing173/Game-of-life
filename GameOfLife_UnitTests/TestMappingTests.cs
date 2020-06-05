using GameOfLife.Models;
using System;
using Xunit;

namespace GameOfLife_UnitTests
{
    public class TestCurrentBoardTests
    {
        Board _sut;

        [Fact]
        public void InitializeCurrentBoard_MapSize_ShouldBeNewMap()
        {
            const int ROWS = 2;
            const int COLUMNS = 2;
            _sut = new Board(2, 2);

            Assert.Equal(_sut.Map.GetLength(0), ROWS);
            Assert.Equal(_sut.Map.GetLength(1), COLUMNS);

        }

        [Fact]
        public void InitializeCurrentBoard_MapSize_ShouldBeMapWithDeadCells()
        {
            const int ROWS = 2;
            const int COLUMNS = 2;
            _sut = new Board(2, 2);

            for (int r = 0; r < ROWS; r++)
            {
                for (int c = 0; c < COLUMNS; c++)
                {
                    Assert.Equal(_sut.Map[r, c], false);
                }
            }

        }

        [Fact]
        public void CopyMapping_GivenCurrentBoard_ShouldBe_CopiedMapWithSameCells()
        {
            const int ROWS = 2;
            const int COLUMNS = 2;

            _sut = new Board(2, 2);
            _sut.ToggleCell(1, 1);
            var clone = new Board(2, 2);
            clone.CopyMapping(_sut);

            for (int r = 0; r < ROWS; r++)
            {
                for (int c = 0; c < COLUMNS; c++)
                {
                    Assert.Equal(_sut.Map[r, c], clone.Map[r, c]);
                }
            }

        }

    }
}
