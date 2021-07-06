using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Keyboard
    {
        private Key[] Keys { get; set; }
        Key key = new Key();
        public Key this[int index]
        {
       
            get
            {
                if (index < 0 || index >= Keys.Length)
                {
                    
                }
                else
                {
                    key = Keys[index];
                }
                return key;
            }
            set
            {
                Keys[index] = value;
            }
        }
        public Keyboard(Key[] keys)
        {
            Keys = keys;
        }

        public Keyboard()
        {
            Keys = new Key[]
            {
                new Key{ KeyCode = 65, KeyName = 'A' },
                new Key{ KeyCode = 66, KeyName = 'B' },
                new Key{ KeyCode = 67, KeyName = 'C' },
                new Key{ KeyCode = 68, KeyName = 'D' },
                new Key{ KeyCode = 69, KeyName = 'E' },
                new Key{ KeyCode = 70, KeyName = 'F' },
            };
        }

        public void PressKey(Key key)
        {
            key.Press();
        }
    }
}
