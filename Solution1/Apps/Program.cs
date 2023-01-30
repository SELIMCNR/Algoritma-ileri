using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {

        var arr = new DataStructures.Array.Array<int>(); // Veriyapıları kütüphanesinden Array adlı klasörden obje oluştu
      
        arr.Add(23);  
        arr.Add(55);
        
        Console.WriteLine(arr.Count);   // içerisindeki eleman sayısı
        Console.WriteLine(arr.Capacity);  // nesnenin kapasitesi

        Console.ReadKey();
    }
}