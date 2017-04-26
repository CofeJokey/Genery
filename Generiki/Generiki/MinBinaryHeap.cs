using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiki
{
    class MinBinaryHeap<T> : BinaryHeap<T>
         where T : IComparable
    {

        public MinBinaryHeap() : base()
        {


        }



        public void heapify(int tmp)
        {
            int leftElem;
            int rightElem;
            int minElem;

            for (;;)
            {
                leftElem = 2 * tmp + 1;
                rightElem = 2 * tmp + 2;
                minElem = tmp;

                if (leftElem < listSize && list[leftElem].CompareTo(list[minElem]) < 0)
                {
                    minElem = leftElem;
                }

                if (rightElem < listSize && list[rightElem].CompareTo(list[minElem]) < 0)
                {
                    minElem = rightElem;
                }

                if (minElem == tmp)
                {
                    break;
                }

                T fl = list[tmp];
                list[tmp] = list[minElem];
                list[minElem] = fl;
                tmp = minElem;
            }
        }







        public T extract()
        {
            if (listSize >= 1)
            {
                T result = list[0];
                list[0] = list[listSize - 1];
                list.RemoveAt(listSize - 1);
                return result;
            }
            else throw new ArgumentNullException("Heap is empty");
        }


        public void buildHeap(T[] HeapArray)
        {
            list = HeapArray.ToList();
            for (int i = listSize / 2; i >= 0; i--)
            {
                heapify(i);
            }

        }

        public void insert(T value)
        {

            list.Add(value);

            int i = listSize - 1;
            int parent = (i - 1) / 2;

            while (i > 0 && list[parent].CompareTo(list[i]) < 0)
            {
                T temp = list[i];
                list[i] = list[parent];
                list[parent] = temp;

                i = parent;
                parent = (i - 1) / 2;
            }
        }










    }
}
