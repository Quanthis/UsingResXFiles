using System;
using System.Reflection;
using System.Resources;
using static System.Console;

namespace UsingResXFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourceManager = new ResourceManager("Resource1", Assembly.GetExecutingAssembly());

            int read = Convert.ToInt32(UsingResXFiles.Resource1.String3);

            //string read = (UsingResXFiles.Resource1.String3);

            WriteLine(read);

            ReadLine();
        }
    }
}
