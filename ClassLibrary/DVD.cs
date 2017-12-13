using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DVD:Storage
    {
        public int Speed { get; set; }
        public bool Side { get; set; }
        public int Memory { get; set; }
        public int FilledMemory { get; set; }

        public override void FillMemory(int memory)
        {
            FilledMemory = memory;
        }

        public override int GetEmptyMemory()
        {
            return Memory - FilledMemory;
        }

        public override int GetMemory()
        {
            return Memory;
        }

        public override string Show()
        {
            string info = String.Format(" Name; {0} \n Model; {1} \n Memory; {2} \n Filled Memory; {3} \n Speed; {4}", GetName(), GetModel(), Memory, FilledMemory, Speed);
            return info;
        }
    }
}
