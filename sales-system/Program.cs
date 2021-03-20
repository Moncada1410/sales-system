namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {
            createObjects createObjects = new createObjects();

            Seller seller1 = new Seller();
            seller1.Name = "Juan Carlos ";
            seller1.Age = 36;
            seller1.CC = 75695347;
            seller1.Gender = "Hombre";
            createObjects.AddSellers(seller1);

            Seller seller2 = new Seller();
            seller2.Name = "Blanca ";
            seller2.Age = 24;
            seller2.CC = 75089354;
            seller2.Gender = "Mujer";
            createObjects.AddSellers(seller2);

            Seller seller3 = new Seller();
            seller3.Name = "Juan Esteban ";
            seller3.Age = 33;
            seller3.CC = 1006985347;
            seller3.Gender = "Hombre";
            createObjects.AddSellers(seller3);

            Seller seller4 = new Seller();
            seller4.Name = "Carolina ";
            seller4.Age = 40;
            seller4.CC = 10564789;
            seller4.Gender = "Mujer";
            createObjects.AddSellers(seller4);

            Seller seller5 = new Seller();
            seller5.Name = "Pedro ";
            seller5.Age = 26;
            seller5.CC = 78654123;
            seller5.Gender = "Hombre";
            createObjects.AddSellers(seller5);

            Product product1 = new Product();
            product1.Name = "Leche";
            product1.Price = 15;
            product1.Category = "Lacteos";
            createObjects.AddProducts(product1);

            Product product2 = new Product();
            product2.Name = "Juguitos hit";
            product2.Price = 5;
            product2.Category = "Jugos";
            createObjects.AddProducts(product2);

            Product product3 = new Product();
            product3.Name = "Avena";
            product3.Price = 2;
            product3.Category = "Lacteos";
            createObjects.AddProducts(product3);

            Product product4 = new Product();
            product4.Name = "cerveza";
            product4.Price = 3;
            product4.Category = "Licor";
            createObjects.AddProducts(product4);

            Product product5 = new Product();
            product5.Name = "Ron";
            product5.Price = 6;
            product5.Category = "Licor";
            createObjects.AddProducts(product5);

            Product product6 = new Product();
            product6.Name = "Tequila";
            product6.Price = 16;
            product6.Category = "Licor";
            createObjects.AddProducts(product6);

            Product product7 = new Product();
            product7.Name = "Jabon rey";
            product7.Price = 2;
            product7.Category = "Aseo";
            createObjects.AddProducts(product7);

            Product product8 = new Product();
            product8.Name = "Fab";
            product8.Price = 20;
            product8.Category = "Aseo";
            createObjects.AddProducts(product8);

            Product product9 = new Product();
            product9.Name = "Piña";
            product9.Price = 8;
            product9.Category = "Fruta";
            createObjects.AddProducts(product9);

            Product product10 = new Product();
            product10.Name = "Barrilete";
            product10.Price = 1;
            product10.Category = "Dulce";
            createObjects.AddProducts(product10);

            Sale sale1 = new Sale();
            sale1.Quantity = 3;
            sale1.Comments = "Producto vendido";
            createObjects.AddSales(sale1);

            Sale sale2 = new Sale();
            sale2.Quantity = 6;
            sale2.Comments = "Producto vendido";
            createObjects.AddSales(sale2);

            Sale sale3 = new Sale();
            sale3.Quantity = 9;
            sale3.Comments = "Producto vendido";
            createObjects.AddSales(sale3);

            Sale sale4 = new Sale();
            sale4.Quantity = 10;
            sale4.Comments = "Producto vendido";
            createObjects.AddSales(sale4);

            Sale sale5 = new Sale();
            sale5.Quantity = 16;
            sale5.Comments = "Producto vendido";
            createObjects.AddSales(sale5);

            Sale sale6 = new Sale();
            sale6.Quantity = 12;
            sale6.Comments = "Producto vendido";
            createObjects.AddSales(sale6);

            Sale sale7 = new Sale();
            sale7.Quantity = 4;
            sale7.Comments = "Producto vendido";
            createObjects.AddSales(sale7);

            Sale sale8 = new Sale();
            sale8.Quantity = 7;
            sale8.Comments = "Producto vendido";
            createObjects.AddSales(sale8);

            Sale sale9 = new Sale();
            sale9.Quantity = 9;
            sale9.Comments = "Producto vendido";
            createObjects.AddSales(sale9);

            Sale sale10 = new Sale();
            sale10.Quantity = 19;
            sale10.Comments = "Producto vendido";
            createObjects.AddSales(sale10);

            createObjects.ProductoMasBarato();
            createObjects.PrecioMedioDeLosProductos();
            createObjects.ProductosVendidos();
            createObjects.ProductoMasCaro();
        }
    }
}
