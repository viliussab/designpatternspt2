using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public abstract class Algorithm
    {
        public void Calculate1()
        {
            Console.WriteLine("do something 1");
        }
        public virtual void Calculate2()
        {
            Console.WriteLine("do something 2");
        }
        public abstract void Calculate3();
        public void Calculate4()
        {
            Console.WriteLine("do something 4");
        }
        public virtual void TemplateMethod() {
            Calculate1();
            Calculate2();
            Calculate3();
            Calculate4();
        }
    }

    public class AlgorithmImplementationA : Algorithm
    {
        public override void Calculate2()
        {
            Console.WriteLine("do something different 2");
        }
        public override void Calculate3()
        {
            Console.WriteLine("do something different 3");
        }

        public sealed override void TemplateMethod()
        {
            base.TemplateMethod();
        }
    }

    public class AlgorithmImplementationA2 : AlgorithmImplementationA
    {
        public override void Calculate2()
        {
            Console.WriteLine("do something different different 2");
        }
    }
}
