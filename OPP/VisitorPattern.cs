using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public interface Location
    {
        void Accept(Visitor v);
    }

    public interface Visitor
    {
        void Visit(City c);
        void Visit(Church c);
    }

    public class City : Location
    {
        public void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }

    public class Church : Location
    {
        public void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }

    public class President : Visitor
    {
        public void Visit(City c)
        {
            Console.WriteLine("President visits the city, he goes to museum");
        }

        public void Visit(Church c)
        {
            Console.WriteLine("President goes to church and zachrisstii");
        }
    }

    public class PolishPerson : Visitor
    {
        public void Visit(City c)
        {
            Console.WriteLine("Kurwa mac");
        }

        public void Visit(Church c)
        {
            Console.WriteLine("Tylko jedno w glowie man, koksu piec gram");
        }
    }
}
