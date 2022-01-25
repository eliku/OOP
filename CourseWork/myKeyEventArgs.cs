using System;
using System.ComponentModel;

namespace CourseWork
{
    class myKeyEventArgs: HandledEventArgs
    {
        // нажатая кнопка
        public ConsoleKeyInfo key;

        public myKeyEventArgs(ConsoleKeyInfo _key)
        {
            key = _key;
        }
    }
}
