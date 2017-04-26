using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiki
{
    class Program
    {

        static void Main(string[] args)
        {

            MaxBinaryHeap<int> heapValue = new MaxBinaryHeap<int>();
            //var list = new MaxBinaryHeap<int>(1, 2, 3, 4);




            heapValue.insert(15);


            heapValue.insert(21);
            heapValue.insert(3);
            heapValue.insert(4);
            heapValue.insert(2);
            heapValue.insert(7);
            heapValue.insert(1);

            Console.WriteLine(heapValue.extract());




        }



    }
}
