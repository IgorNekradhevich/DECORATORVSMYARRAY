using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class MyArray : IMyCollection
    {
        protected int[] _array { get;  set; }
        protected int len { get;  set; }

        public int[] GetArray()
        {
            return _array;
        }

        public int[] ReturnArray()
        {
            len = 10;
            Random rnd = new Random();
            _array = new int[len];
            for (int i = 0; i < len; i++)
                _array[i] = rnd.Next(-10, 10);
            return _array;
        }


    }
}
