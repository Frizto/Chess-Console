using System;

namespace tabletop
{
    class TabletopException : Exception
    {
        public TabletopException (string msg) : base(msg) { }
    }
}
