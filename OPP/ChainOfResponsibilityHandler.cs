using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public abstract class ExcessiveContentHandler
    {
        protected ExcessiveContentHandler next;

        public abstract string Handle(string message);
        public void SetNext(ExcessiveContentHandler next)
        {
            this.next = next;
        }
    }

    public class SwearHandler : ExcessiveContentHandler
    {
        public override string Handle(string message)
        {
            if (message.Contains("fuck") || message.Contains("dalbajov"))
                return "Swear detected!";
            else
                return next.Handle(message);
        }


    }
    public class NudesHandler : ExcessiveContentHandler
    {
        public override string Handle(string message)
        {
            if (message.Contains("booba") || message.Contains("vagin"))
                return "Nudes detected!";
            else
                return next.Handle(message);
        }
    }
    public class ViolenceHandler : ExcessiveContentHandler
    {
        public override string Handle(string message)
        {
            if (message.Contains("kill") || message.Contains("i eat people"))
                return "Violence detected!";
            else
                return next.Handle(message);
        }


    }

    public class EOFHandler : ExcessiveContentHandler
    {
        public override string Handle(string message)
        {
            return "Success";
        }
    }
}

