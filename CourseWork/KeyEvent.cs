using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class KeyEvent
    {
        public event EventHandler<KeyEventArgs> KeyPress;

        // This is called when a key is pressed.
        public void OnKeyPress(char key)
        {
            KeyEventArgs k = new KeyEventArgs();

            if (KeyPress != null)
            {
                k.ch = key;
                KeyPress(this, k);
            }
        }
    }
}
