using System;
using System.Collections.Generic;
using BF.Util;

namespace BF.Core
{
    class Context
    {
        public Context()
        {
            Data = new Dictionary<int, char>();
        }

        private IDictionary<int, char> Data { get; set; }
        private int CurrentIndex { get; set; }

        public char Value
        {
            get { return Data.TryGetValue(CurrentIndex); }
            set { Data[CurrentIndex] = value; }
        }

        public void PreviousValue()
        {
            CurrentIndex--;
        }

        public void NextValue()
        {
            CurrentIndex++;
        }

        public void DecrementValue()
        {
            Data[CurrentIndex] = (char)(Data.TryGetValue(CurrentIndex) - 1);
        }

        public void IncrementValue()
        {
            Data[CurrentIndex] = (char)(Data.TryGetValue(CurrentIndex) + 1);
        }
    }
}