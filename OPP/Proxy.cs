using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public interface HttpSender
    {
        void send(string url, string data);
    }

    public class Sender : HttpSender
    {
        public void send(string url, string data)
        {
            Console.WriteLine($"Sending: \"{data}\" to {url}");
        }
    }

    public class SenderProxy : HttpSender
    {
        private Sender original;

        public SenderProxy(Sender sender)
        {
            original = sender;
        }

        public void send(string url, string data)
        {
            if (url == null || data == null)
            {
                return;
            }

            original.send(url, data);
        }
    }
}
