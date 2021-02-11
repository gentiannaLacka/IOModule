using System;

namespace IOModule
{
    class IOModule
    {
        public event EventHandler NotifyEvent;
        public void Start()
        {
            OnStart(new EventArgs());
        }

        protected virtual void OnStart(EventArgs e)
        {
            EventHandler raiseEvent = NotifyEvent;
            raiseEvent?.Invoke(this, e);
        }
    }

}