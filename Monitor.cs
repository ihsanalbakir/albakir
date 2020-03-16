using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperComputer
{
    class Monitor
    {
        private String resolution;
        private Boolean supportHdmi;
        private double size;

        public Monitor(String resolution, Boolean supportHdmi, double size)
        {
            this.resolution = resolution;
            this.supportHdmi = supportHdmi;
            this.size = size;
        }
        private String getresolution()
        {
            return this.resolution;
        }
        private Boolean isSupportHdmi()
        {
            return this.supportHdmi;
        }
        private double getSize()
        {
            return this.size;
        }
        public override string ToString()
        {
            return $"Monitor resolutin: {resolution} ; Monitor support hdmi : {supportHdmi}; Monitor dimensi : {size} inch";
        }
    }
}
