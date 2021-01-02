namespace Day3
{
    public class PathMapper
    {
        private readonly AreaMap _map;
        public PathMapper(AreaMap map)
        {
            _map = map;
        }

        public int TreesHit(int x, int y)
        {
            int count = 0;
            for (int i = 0; i < _map.Map.GetLength(1); i += y)
            {
                for (int j = 0; j < _map.Map.GetLength(0); i += x)
                {
                    if (i > _map.Map.GetLength(1))
                    {
                        return count;
                    }
                    else if (j > _map.Map.GetLength(0))
                    {
                        return count;
                    }
                    else if (_map.Map[j, i] == '#')
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}