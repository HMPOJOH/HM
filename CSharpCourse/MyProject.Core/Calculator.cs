
using System;

namespace MyProject.Core
{
    public class Calculator
    {
        private int _value = 0;

        public void Add(string number)
        {
            if (int.TryParse(number, out int result))
            {
                _value += result;
            }

        }

        public int GetValue()
        {
            return _value;
        }

        // todo: create Reset method (set _value to 0) + create tests for that method

        public void Subtract(string number)
        {
            if (int.TryParse(number, out int result))
            {
                _value -= result;
            }
        }
    }
}
