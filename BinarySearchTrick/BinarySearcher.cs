using System;

namespace YonatanMankovich.BinarySearchTrick
{
    public struct BinarySearcher
    {
        public long LowerBound { get; private set; }
        public long UpperBound { get; private set; }
        public long CurrentNumber { get; private set; }

        public BinarySearcher(long lowerBound, long upperBound)
        {
            LowerBound = 0;
            UpperBound = 0;
            CurrentNumber = 0;
            ShrinkRange(lowerBound, upperBound);
        }

        public void GoLeft()
        {
            ShrinkRange(LowerBound, CurrentNumber);
        }

        public void GoRight()
        {
            ShrinkRange(CurrentNumber, UpperBound);
        }

        private void ShrinkRange(long from, long to)
        {
            CurrentNumber = (from + to) / 2;
            LowerBound = from;
            UpperBound = to;
        }

        public int GetMaxNumberOfGuesses()
        {
            return GetMaxNumberOfGuessesForRange(LowerBound, UpperBound);
        }

        public static int GetMaxNumberOfGuessesForRange(long from, long to)
        {
            if (to - from == 0)
                return 0;
            return (int)Math.Ceiling(Math.Log(Math.Abs(to - from), 2)) + 1;
        }
    }
}