using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperComputer
{
    class RAM
    {
        private String type;
        private int speed;
        private int memorySize;

        public RAM(String type, int speed, int memorySize)
        {
            this.type = type;
            this.speed = speed;
            this.memorySize = memorySize;
        }

        public string gettype()
        {
            return this.type;
        }
        public int getspeed()
        {
            return this.speed;
        }
        public int getmemorySize()
        {
            return this.memorySize;
        }
        public override string ToString()
        {
            return $"RAM type : {this.type} ; RAM speed : {this.speed} ; RAM size : {this.memorySize}";
        }
    }
}