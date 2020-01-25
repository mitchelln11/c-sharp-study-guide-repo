using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cSharpStudyGuide.ProxyPatterrn
{
    //proxy
    //proxy exposes same interface that real subject exposes
    //proxy encapsulates (4 Pillars of OOP) all necessary logic that's invovled in interfacing the real subjet
    public class ComponentPriceProxy : IComponentPrice
    {
        private decimal MakeRequest(string component)
        {
            using (var client = new TcpClient())
            {
                client.Connect("127.0.0.1", 8080);

                var stream = client.GetStream();
                var data = Encoding.Default.GetBytes(component);

                stream.Write(data, 0, data.Length);

                var rawResponse = new byte[15];
                stream.Read(rawResponse, 0, rawResponse.Length);

                var response = Encoding.Default.GetString(rawResponse);

                return Convert.ToDecimal(response);
            }
        }

        // ==== Below 3 are examples of Data Abstraction (4 Pillars of OOP)
        // Run private method, then return cpu
        public decimal CpuPrice
        {
            get { return MakeRequest("cpu"); }
        }

        // Run private method, then return ram
        public decimal RamPrice
        {
            get { return MakeRequest("ram"); }
        }

        // Run private method, then return ssd
        public decimal SsdPrice
        {
            get { return MakeRequest("ssd"); }
        }

        // Display Prices
        public void RunProxy()
        {
            var prices = new StoredComponentPrices();

            Console.WriteLine("CPU Price: {0}", prices.CpuPrice);
            Thread.Sleep(500);
            Console.WriteLine("CPU Price: {0}", prices.RamPrice);
            Thread.Sleep(500);
            Console.WriteLine("CPU Price: {0}", prices.SsdPrice);
            Thread.Sleep(500);
        }
    }
}
