using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Storage
    {
        private string _name;
        private string _model;


        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetModel()
        {
            return _model;
        }

        public void SetModel(string model)
        {
            _model = model;
        }


        public abstract int GetMemory();

        public abstract void FillMemory(int memory);

        public abstract int GetEmptyMemory();

        public abstract string Show();
    }
}
