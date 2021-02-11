using System;
using System.Diagnostics;
using System.Reflection;

namespace IOModule
{
    abstract class BaseClass
    {
        public virtual void DoJob()
        {
            StackFrame frame = new StackFrame(1);
            MethodBase method = frame.GetMethod();

            Console.WriteLine(method.DeclaringType.Name);
        }
    }
    class Printer : BaseClass
    {
        private IOModule _ioModuleEvent;

        public Printer()
        {
            _ioModuleEvent = new IOModule();

            _ioModuleEvent.ThrowEvent += (sender, args) => { DoJob(); };
        }
        public override void DoJob()
        {
            base.DoJob();
        }
    }
    class Scanner : BaseClass
    {
        private IOModule _ioModuleEvent;

        public Scanner()
        {
            _ioModuleEvent = new IOModule();

            _ioModuleEvent.ThrowEvent += (sender, args) => { DoJob(); };
        }
        public override void DoJob()
        {
            base.DoJob();
        }
    }

    class Scale : BaseClass
    {
        private IOModule _ioModuleEvent;

        public Scale()
        {
            _ioModuleEvent = new IOModule();

            _ioModuleEvent.ThrowEvent += (sender, args) => { DoJob(); };
        }
        public override void DoJob()
        {
            base.DoJob();
        }
    }
}
