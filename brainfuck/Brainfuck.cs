namespace brainfuck
{
    internal class Brainfuck
    {
        private readonly int _position;
        private readonly List<int> _list = new List<int> { 0 };
        private readonly List<int> _listOfInitialIndexesOfCycles = new List<int>();

        public Brainfuck(string line)
        {
            for (int index = 0, indexOfUsedCycled = -1; index < line.Length; index++)
            {
                var @char = line[index];

                switch (@char)
                {
                    case '[':
                        _listOfInitialIndexesOfCycles.Add(index);
                        indexOfUsedCycled = _listOfInitialIndexesOfCycles.Count - 1;
                        
                        break;
                    case ']':
                        if (_list[_position] != 0)
                            index = _listOfInitialIndexesOfCycles[indexOfUsedCycled];
                        else _listOfInitialIndexesOfCycles.RemoveAt(indexOfUsedCycled--);
                        
                        break;
                    case '+':
                        _list[_position]++;
                        
                        break;
                    case '-':
                        _list[_position]--;
                        
                        break;
                    case '<':
                        _position--;
                        if (_position < 0)
                        {
                            _list.Add(0);
                            Utilities.ShiftRight(_list, 1);
                            
                            _position = 0;
                        }
                        
                        break;
                    case '>':
                        if (++_position >= _list.Count) _list.Add(0);
                        
                        break;
                    case '.':
                        Console.Write(((char)_list[_position]).ToString());
                        
                        break;
                    
                    case ',':
                        Console.WriteLine();
                        
                        _list[_position] = Convert.ToInt32(Console.ReadLine());
                        
                        break;
                }
            }
        }

        public string ResultList => string.Join(", ", _list);
    }
}