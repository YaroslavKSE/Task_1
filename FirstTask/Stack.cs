namespace FirstTask
{
    using System;

    
    public class Stack
    {
        private const int Capacity = 50;

        private string[] _array = new string[Capacity];

        private int _pointer = 0;

        public void Push(string value)
        {
            if (_pointer == _array.Length)
            {
                throw new Exception("Stack overflowed");
            }

            _array[_pointer] = value;
            _pointer++;
        }

        public string Pull()
        {
            if (_pointer == 0)
            {
                return null;
            }

            var value = _array[_pointer - 1];
            _pointer--;
            return value;
        }

        public string ToString()
        {
            return string.Join(' ', _array);
        }
        
        public bool IsEmpty()
        {
            return _pointer == 0;
        }

        public string GetLast()
        {
            if (_pointer == 0)
            {
                return null;
            }

            return _array[_pointer - 1];
        }
    }
}
