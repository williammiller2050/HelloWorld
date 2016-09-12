using HelloWorld.Helpers;
using HelloWorldLibrary.Interfaces;
using HelloWorldLibrary.Outputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IOutput output = LoadHelper.GetOutputType();
                output.Write();
            }
            catch (Exception ex)
            {
                //Todo: May want to handle the error some other way i.e. log it to the database or use a something like Log4Net.
                Console.WriteLine("Error in the program.");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
