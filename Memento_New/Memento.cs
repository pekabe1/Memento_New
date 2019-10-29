using System;
using System.Collections.Generic;
using System.Text;

namespace Memento_New
{
    class Memento
    {
        string text { get; set; }
        public void SetMemento(string text)
        {
            this.text = text;
        }
        public string GetMemento()
        {
            return text;
        }
    }
}
