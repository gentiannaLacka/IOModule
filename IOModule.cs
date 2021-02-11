using System;

namespace IOModule
{

    class IOModule
    {
        public delegate void EventHandler(object sender, EventArgs args);
        public event EventHandler ThrowEvent = delegate { };

        public void JobEvent() => ThrowEvent(this, new EventArgs());
    }
}