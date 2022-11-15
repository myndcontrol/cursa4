using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursa4
{
    internal class devicesList
    {
        private List<device> deviceList = new List<device>();
        public List<device> GetDevices { get { return deviceList; } set { deviceList = value; } }
    }
}
