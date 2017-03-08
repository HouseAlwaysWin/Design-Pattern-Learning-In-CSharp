using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 9999);

            while (true)
            {
                listener.Start();
                Console.WriteLine("Waiting for client....");
                Socket socket = listener.AcceptSocket();

                Console.WriteLine("Accepting Resquest...");

                byte[] b = new byte[100];

                int count = socket.Receive(b);

                string input = string.Empty;

                for (int i = 0; i < count; i++)
                {
                    input += Convert.ToChar(b[i]);
                }

                IActualPrices realSubject = new ActualPrices();
                string returnValue = string.Empty;

                switch (input)
                {
                    case "g":
                        returnValue = realSubject.GoldPrice;
                        break;
                    case "s":
                        returnValue = realSubject.SilverPrice;
                        break;
                    case "d":
                        returnValue = realSubject.DollarPrice;
                        break;
                }

                ASCIIEncoding asen = new ASCIIEncoding();
                socket.Send(asen.GetBytes(returnValue));

                socket.Close();
                listener.Stop();
                Console.WriteLine("Response Sent....");


            }
        }
    }
}
