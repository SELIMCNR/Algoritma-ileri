using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Array
{
    //<T> GENERİC YAPTI , IEnumerable sıralanabilir , ICloneable klonlanabilir,  
    public class Array<T> : IEnumerable<T>, ICloneable
    {
        private T[] InnerList;  // Sınıf içindeki listemiz
        public int Count { get; set; }  // count özellik dışardan okunabilir sınıf içerisinde yazılabilir.
        public int Capacity => InnerList.Length; // clasın kapasitesi sınıf içindeki dizinin kapasitesi oldu.

        public Array() // yapılandırıcı metot
        {
            InnerList= new T[2];
            Count=0;
        }
        
        public void Add(T item)  // dışardan classa ekleme yapma metodu 
        {
            InnerList[Count]=item;  // listeye ekle item 
            Count++;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }   //klonlanma

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
