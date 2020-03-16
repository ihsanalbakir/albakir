using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor lgMonitor = new Monitor("1200x600", true, 32);
            printer hpprinter = new printer("HP", "MP102", 50);

            VGA nvdiaVGA = new VGA("Nvdia",2045,2054);
            RAM samsungRAM = new RAM("DDR4", 5000, 8000);
            Processor intelProcessor = new Processor();
            intelProcessor.setcache(254);
            intelProcessor.setcore(8);
            intelProcessor.setseries("CORE i7 8th Gen");

            Computer computer = new
    Computer.Builder(samsungRAM, nvdiaVGA, intelProcessor)
                    .withMonitor(lgMonitor)
                    .withprinter(hpprinter)
                    .build();
            Console.WriteLine(computer.ToString());
        }
    }
}