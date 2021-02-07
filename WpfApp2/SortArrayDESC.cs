using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class SortArrayDESC : Decorator
    {
        public SortArrayDESC(IMyCollection myCollection) : base(myCollection) { }
        public override int[] ReturnArray()
        {
            _myCollection.ReturnArray();

            int[] buffer = _myCollection.GetArray();

            for(int i=0; i< buffer.Length;i++)
                for (int j=0;j< buffer.Length-i-1;j++)
                {
                    if (buffer[j]< buffer[j + 1])
                    {
                        int temp = buffer[j];
                        buffer[j] = buffer[j + 1];
                        buffer[j + 1]= temp;
                    }
                }
            return buffer;
        }
    }
}
