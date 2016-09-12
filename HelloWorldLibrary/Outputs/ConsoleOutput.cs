using HelloWorldLibrary.Helpers;
using HelloWorldLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace HelloWorldLibrary.Outputs
{
    public class ConsoleOutput : IOutput
    {
        public void Write()
        {
            IEnumerable<string> list = Values.GetValues();

            if (list.Count() != 0)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey(true);
        }
    }
}
