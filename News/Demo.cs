using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    public class Demo
    {
        int _donneDeux;
        public int DonneDeux 
        {
            get => _donneDeux * 2;
            set => _donneDeux = value;
        }


        private int _myVar;

        public int MyProperty
        {
            get { return _myVar; }
            set { _myVar = value; }
        }


    }
}
