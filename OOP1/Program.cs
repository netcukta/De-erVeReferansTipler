using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryID = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.Unitsinstock = 3;

            Product product2 = new Product { CategoryID = 5, Unitsinstock = 500, ProductName = "dsdds" };

            ProductManagerClass1 productManagerClass1 = new ProductManagerClass1();  //örnek oluşturdum

            productManagerClass1.Add(product1);

            productManagerClass1.Topla2(3, 6);
            

            
            int toplamaSonucu = productManagerClass1.Topla(3, 6);

            Console.WriteLine(toplamaSonucu*2);





            
            
            
            

            




            

        }
    }
}
