using OnlineShop.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Entities
{
    public class Product
    {
        private static List<Product> Products = new List<Product>();

        private static int LastId { get; set; } = 1;

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        public ProductCategory Category { get; set; }

        public int Amount { get; set; }



        public static int AddProduct(Product input)
        {

            input.Id= LastId;
            Products.Add(input);
            LastId++;

            return input.Id;
            
        }


        public static List<Product> GetProducts(int? id)
        {
            if(id is null)
            {
                return Products;

            }

            return Products.Where(e => e.Id == id).ToList() ;


        }


    }
}
