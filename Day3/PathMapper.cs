using System;

namespace Day3
{
    public class PathMapper
    {
        private readonly AreaMap _map;
        public PathMapper(AreaMap map)
        {
            _map = map;
        }

        public int TreesHit(int increaseXBy, int increaseYBy)
        {
            int count = 0;
            int y = 0;

            int xLength = _map.Map.GetLength(0);
            int yLength = _map.Map.GetLength(1);

            for (int x = 0; x < xLength; x += increaseXBy)
            {
                if (_map.Map[x, y] == '#')
                {

                    count++;
                }
                y = CalculateYValue(y, increaseYBy);
            }

            return count;
        }

        private int CalculateYValue(int currentY, int increaseYBy)
        {
            for (int i = 0; i < increaseYBy; i++)
            {
                currentY++;
                if (currentY >= _map.Map.GetLength(1))
                {
                    currentY = 0;
                }
            }

            return currentY;
        }
    }
}