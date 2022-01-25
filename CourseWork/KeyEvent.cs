using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class KeyEvent
    {
        // событие нажатия
        public event EventHandler<myKeyEventArgs> KeyPress;

        // метод запуска события
        public void OnKeyPress(ConsoleKeyInfo _key)
        {
            KeyPress(this, new myKeyEventArgs(_key));
        }
    }
}
