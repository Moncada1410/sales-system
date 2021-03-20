using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system
{
    public class createObjects
    {
        int count = 0;

        Seller[] Sellers = new Seller[50];
        int countSeller = 0;

        Product[] Products = new Product[50];
        int countProduct = 0;

        List<Sale> Sales = new List<Sale>();
        int countSale = 0;

        public void AddSellers(Seller seller)
        {
            Sellers[countSeller] = seller;
            countSeller++;
        }

        public void AddProducts(Product product)
        {
            Products[countProduct] = product;
            countProduct++;
        }

        public void AddSales(Sale sale)
        {
            if (count < countSeller)
            {
                Sales.Add(new Sale()
                {
                    Seller = Sellers[count],
                    Product = Products[countSale],
                    Quantity = sale.Quantity,
                    Comments = sale.Comments
                });
                countSale++;
                count++;
            }
            else
            {
                count = 0;
                Sales.Add(new Sale()
                {
                    Seller = Sellers[count],
                    Product = Products[countSale],
                    Quantity = sale.Quantity,
                    Comments = sale.Comments
                });
                countSale++;
                count++;
            }
        }

        public void ProductoMasBarato()
        {
            string nameSeller = "";
            string nameProduct = "";
            double priceProduct = 0;
            string categoryProduct = "";
            double value = 0;

            for (int i = 0; i < Sales.Count; i++)
            {
                double price = Sales[i].Product.Price;

                if (value == 0)
                {
                    nameSeller = Sales[i].Seller.Name;
                    nameProduct = Sales[i].Product.Name;
                    priceProduct = Sales[i].Product.Price;
                    categoryProduct = Sales[i].Product.Category;
                    value = priceProduct;
                }
                else if (price < value)
                {
                    nameSeller = Sales[i].Seller.Name;
                    nameProduct = Sales[i].Product.Name;
                    priceProduct = Sales[i].Product.Price;
                    categoryProduct = Sales[i].Product.Category;
                    value = priceProduct;
                }
            }

            Console.WriteLine("Quién es el vendedor (nombre del vendedor), quién ha vendido el producto más barato.");
            Console.WriteLine("Nombre: " + nameSeller);
            Console.WriteLine("Producto: " + nameProduct);
            Console.WriteLine("Precio: " + priceProduct);
            Console.WriteLine("Categoria: " + categoryProduct);
        }

        public void PrecioMedioDeLosProductos()
        {
            double priceProducts = 0;
            double productPrice = 0;
            double averagePriceProducts = 0;

            for (int i = 0; i < countProduct; i++)
            {
                productPrice = Products[i].Price;
                priceProducts = priceProducts + productPrice;
            }

            averagePriceProducts = priceProducts / countProduct;
            Console.WriteLine("Precio medio de los productos.");
            Console.WriteLine("Precio promedio: " + averagePriceProducts);
        }

        public void ProductosVendidos()
        {
            string nameProduct = "";
            int cantidad = 0;


            for (int i = 0; i < Sales.Count; i++)
            {

                nameProduct = Sales[i].Product.Name;
                cantidad = Sales[i].Quantity;

                Console.WriteLine("Cuántas unidades del producto se han vendido.");
                Console.WriteLine("Nombre Del producto: " + nameProduct);
                Console.WriteLine("Cantidad producto: " + cantidad);

            }


        }

        public void ProductoMasCaro()
        {
            string nameProduct = "";
            double priceProduct = 0;
            double value = 0;

            for (int i = 0; i < Sales.Count; i++)
            {
                double price = Sales[i].Product.Price;

                if (value == 0)
                {
                    nameProduct = Sales[i].Product.Name;
                    priceProduct = Sales[i].Product.Price;
                    value = priceProduct;
                }
                else if (price > value)
                {
                    nameProduct = Sales[i].Product.Name;
                    priceProduct = Sales[i].Product.Price;
                    value = priceProduct;
                }
            }

            Console.WriteLine("el producto más caro");
            Console.WriteLine("Producto: " + nameProduct);
            Console.WriteLine("Precio: " + priceProduct);


        }
    }
}
