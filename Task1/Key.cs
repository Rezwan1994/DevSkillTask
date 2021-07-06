using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Key
    {
        public char KeyName { get; set; }
        public int KeyCode { get; set; }
        public bool Pressed { get; private set; }

        public Key()
        {
            Pressed = false;
        }

        public void Press()
        {
            Pressed = true;
        }
    }
}
