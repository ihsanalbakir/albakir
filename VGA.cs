using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperComputer
{
    class VGA
    {
        private String brand;
        private int graphicsClock;
        private int memoryClock;

        public VGA(String brand, int graphicsClock, int memoryClock){
            this.brand = brand;
            this.graphicsClock = graphicsClock;
            this.memoryClock = memoryClock;
        }

        public string getbrand(){
            return this.brand;
        }
        public int getgraphicsClock(){
            return this.graphicsClock;
        }
        public int getmemoryClock()
        {
            return this.memoryClock;
        }
        public override string ToString()
        {
            return $"VGA brand:{this.brand}; Vga clock graphics : {this.graphicsClock}; VGA clock memory : {this.memoryClock}";
        }
    }
}