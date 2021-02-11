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

            Console.WriteLine("Class name: " + method.DeclaringType.Name);
        }
    }
    class Printer : BaseClass
    {
        public Printer(IOModule module)
        {
            module.NotifyEvent += DoJob;
        }
        public void DoJob(object sender, EventArgs e)
        {
            base.DoJob();
        }
    }
    class Scanner : BaseClass
    {
        public Scanner(IOModule iOModule)
        {
            iOModule.NotifyEvent += DoJob;
        }
        public void DoJob(object sender, EventArgs e)
        {
            base.DoJob();
        }
    }

    class Scale : BaseClass
    {
        public Scale(IOModule iOModule)
        {
            iOModule.NotifyEvent += DoJob;
        }
        public void DoJob(object sender, EventArgs e)
        {
            base.DoJob();
        }
    }
}
