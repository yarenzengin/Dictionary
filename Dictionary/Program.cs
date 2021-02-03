using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> names = new MyDictionary<string>();
            names.Add("yaren ");
            names.Add("simge");
            names.Add("büşra ");
            names.Add("şevval");
            names.Add("esra");
            names.Add("beyza");
            names.Add("elif ");
            names.Add("nejdet");
            names.Add("halil ");
            names.Add("mürsel");
            Console.WriteLine(names.Count);

        }
    }

    class MyDictionary<T>
    {
        //metotun dışında tanımlarsak class'ın içinde istediğimiz yerde kullanabiliriz
        T[] items;
        T[] tempItems;
        public MyDictionary()//contructor
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempItems = items;//items'ı new'lediğimiz zaman önceki değerler uçuyor,bunun olmaması için bir tane geçici diziyle o referasları tutuyoruz
            items = new T[items.Length + 1];//dizinin eleman sayısını arttırdım
            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];//tempItems daki elemanları items a geri aldık 
            }
            items[items.Length - 1] = item;//yukarıdan gelen elemanları ekledik.
            //1 çıkarmamızın sebei ; örneğin dizimiz 6 elemanlı ama diziler 0.indexden başlar yani {0,1,2,3,4,5} şeklinde olduğu için 1 çıkardık

        }
         public int Count
        {
            get { return items.Length; } // elemanları sayıyoruz.
        }



    }
    
    

}
