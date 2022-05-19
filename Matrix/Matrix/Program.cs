using System;

namespace Matrix
{
    internal class Program
    {
        public class Matrixes
        {
            readonly int _x, _y;
            int[,] _matrix;

            public Matrixes(int x, int y)
            {
                _x = x; _y = y;
                _matrix = new int[x, y];
            }

            public int[,] GetMatrix() { return _matrix; }

            public void FillBySnake()
            {
                int counter = 1;
                for (int x = 0; x < _x; x++)
                {
                    if (x % 2 == 0)
                    {
                        for (int y = 0; y < _y; y++)
                            _matrix[x, y] = counter++;
                    }
                    else
                    {
                        for (int y = _y - 1; y >= 0; y--)
                            _matrix[x, y] = counter++;
                    }
                }
            }

            public void FillByStupid45Square()
            {
                if (_x != _y) { Console.WriteLine("Matrix is not square"); }

                int get = _x;
                int middle = get / 2;
                int stage = 0;
                for (int y = 0; y < middle; y++)
                {
                    for (int x = 0; x < middle - stage; x++)
                    {
                        _matrix[y, x] = 1;
                    }
                    stage++;
                }

                stage = 0;
                for (int y = middle + 1; y < get; y++)
                {
                    for (int x = 0; x <= stage; x++)
                    {
                        _matrix[y, x] = 2;
                    }
                    stage++;
                }

                stage = 0;
                for (int y = middle + 1; y < get; y++)
                {
                    for (int x = 0; x <= stage; x++)
                    {
                        _matrix[x, y] = 3;
                    }
                    stage++;
                }

                stage = 0;
                for (int y = middle + 1; y < get; y++)
                {
                    for (int x = _x - 1; x >= _x - 1 - stage; x--)
                    {
                        _matrix[y, x] = 4;
                    }
                    stage++;
                }

            }

            public void FillByDiagonalSnake()
            {
                if (_x != _y) { Console.WriteLine("Matrix is not square"); }
                int direction = 1; 
                int counter = 1;
                for (int stage = 0; stage < _y; stage++)
                {
                    if (stage % 2 == 0)
                    {
                        for (int y = 0; y <= stage; y++)
                            _matrix[y, stage - y] = counter++;
                    }
                    else
                    {
                        for (int x = stage; x >= 0; x--)
                            _matrix[x, stage - x] = counter++;
                    }
                }

                for (int stage = _y; stage <= (_y - 1) * 2; stage++)
                {
                    if (stage % 2 == 0)
                    {
                        for (int y = stage - _x + 1; y <= _y - 1; y++)
                            _matrix[y, stage - y] = counter++;
                    }
                    else
                    {
                        for (int y = _y - 1; y >= stage - _x + 1; y--)
                            _matrix[y, stage - y] = counter++;
                    }
                }

            }

            public void Show()
            {
                var pos = Console.GetCursorPosition();
                for (int x = 1; x <= _x; x++)
                {
                    for (int y = 1; y <= _y; y++)
                    {
                        Console.SetCursorPosition(pos.Left + x + (x - 1) * 4, pos.Top + y + (y - 1) * 2);
                        Console.Write(_matrix[x - 1, y - 1]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Matrixes matrixes = new Matrixes(9, 9);
            matrixes.Show();
        }
    }
}
