using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    abstract class Decorator : IMyCollection
    {
        protected IMyCollection _myCollection;
        public Decorator( IMyCollection myCollection)
        {
            _myCollection = myCollection;
        }

        abstract public int[] ReturnArray();

        public int[] GetArray()
        {
            return _myCollection.GetArray();
        }
    }
}
