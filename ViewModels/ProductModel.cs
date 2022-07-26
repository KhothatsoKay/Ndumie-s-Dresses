using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ndumies_dresses.Models;
using Ndumis_Dresses.Models;

namespace Ndumis_Dresses.ViewModels
{
    public class ProductModel
    {
        public List<Product> _products { get; set; }

        public List<Product> findAll()
        {
            _products = new List<Product>
            {
                new Product()
                {

                    Id = "1",
                    Name = "Umbaco",
                    Photo = "Umbaco.jpg",
                    Price = 2500


                },
                new Product()
                {
                    Id = "2",
                    Name = "Dress",
                    Photo = "dress.jpg",
                    Price = 950
                },
                new Product()
                {
                    Id = "3",
                    Name = "Sotho Dress",
                    Photo = "sotho.jpg",
                    Price = 1000
                },
                new Product()
                {
                    Id = "4",
                    Name = "Xhosa Yellow",
                    Photo = "YellowXhosa.jpg",
                    Price = 2500
                },
                new Product()
                {
                    Id = "5",
                    Name = "Blue and Gold",
                    Photo = "overlay.jpg",
                    Price = 950
                },
                new Product()
                {
                    Id = "6",
                    Name = "Yellow Dress",
                    Photo = "YellowDress.jpg",
                    Price = 650
                },
                new Product()
                {
                    Id = "7",
                    Name = "Trad Dress",
                    Photo = "TradDress.jpg",
                    Price = 1000
                },

                new Product()
                {
                    Id = "8",
                    Name = "Trad Dress 2",
                    Photo = "TradDress2.jpg",
                    Price = 1000
                },
                new Product()
                {
                    Id = "9",
                    Name = "Amazing",
                    Photo = "amazing.jpg",
                    Price = 1500
                },
                new Product()
                {
                    Id = "10",
                    Name = "Purple",
                    Photo = "Purple.jpg",
                    Price = 950
                }
            };
            return _products;

        }
        public Product find(string id)
        {
            List<Product> products = findAll();
            var prod = products.Where(a => a.Id == id).FirstOrDefault();
            return prod;
                }
    } 
}
