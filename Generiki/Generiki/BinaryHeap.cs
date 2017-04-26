using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiki
{
    public class BinaryHeap<T>
    
     where T : IComparable
     {
            protected List<T> list;

            public int listSize
            {
                get {return list.Count();}
            }


        public BinaryHeap()
        {
            list = new List<T>();
        }






    }



}


    
        



