using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperComputer
{
    class Processor
    {
        private String series;
        private int core;
        private int cache;

        public Processor(){
        
        }
        public void setseries(String series){
            this.series = series;
        }
        public string getseries(){
            return this.series;
        }
        public void setcore(int core){
            this.core = core;
        }
        public int getcore(){
            return this.core;
        }
        public void setcache(int cache){
            this.cache = cache;
        }
        public int getcache(){
            return this.cache;
        }
        public override string ToString()
        {
            return $"Processor series:{this.series}; Processor core: {this.core}; Processor cache:{this.cache}";
        }
    }
}
