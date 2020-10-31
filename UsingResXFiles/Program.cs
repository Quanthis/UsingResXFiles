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
            int read = Convert.ToInt32(UsingResXFiles.Resource1.String3);


            //iterate through all resx files
            foreach(var item in System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames())
            {
                WriteLine(item);
            }


            //get resource by string variable
            string resxPath = "UsingResxFiles.Resource1";
            ResourceManager rm = new ResourceManager(resxPath, Assembly.GetExecutingAssembly());
            WriteLine(rm.GetString("String1"));

            //string read = (UsingResXFiles.Resource1.String3);

            WriteLine(read);

            ReadLine();
        }
    }
}
