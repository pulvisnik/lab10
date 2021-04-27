using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class ProcessorClass
    {
        public string modelCPU { get; set; }
        public string country { get; set; }
        public int kernel { get; set; }
        public bool VidCard { get; set; }
        public string typeMemor { get; set; }
        public int potokiv { get; set; }
        public ProcessorClass() {

        }
        public ProcessorClass(string _modelCPU, string _country, string _typeMemor, int _kernel, int _potokiv, bool _VidCard)
        {
            modelCPU = _modelCPU;
            country = _country;
            kernel = _kernel;
            VidCard = _VidCard;
            typeMemor = _typeMemor;
            potokiv = _potokiv;
        }




    }
    
}
