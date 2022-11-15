using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursa4
{
    internal class device
    {
        private string producer;
        public string getProducer { get { return producer; } set { producer = value; } }
        
        private string model;
        public string getModel { get { return model; } set { model = value; } }

        private string serialID;
        public string getID { get { return serialID; } set { serialID = value; } }
        private string problem { get { return problem; } set { problem = value; } }
        public string getProblem { get { return problem; } set { problem = value; } }

    }
}
