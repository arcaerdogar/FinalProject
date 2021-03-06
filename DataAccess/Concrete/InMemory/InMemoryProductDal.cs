﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Oracla,Sql Server,Postgres,MongoDB
            _products = new List<Product> { 
                new Product{ProductID=1,CategoryID=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{ProductID=2,CategoryID=1,ProductName="Kamera",UnitPrice=15,UnitsInStock=15},
                new Product{ProductID=3,CategoryID=2,ProductName="Telefon",UnitPrice=15,UnitsInStock=15},
                new Product{ProductID=4,CategoryID=2,ProductName="Klavye",UnitPrice=15,UnitsInStock=15},
                new Product{ProductID=5,CategoryID=2,ProductName="Fare",UnitPrice=15,UnitsInStock=15}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;
            //foreach (var p in _products)//Bu satır yerine linq kullandık
            //{
            //    if (product.ProductID==p.ProductID)
            //    {
            //        productToDelete = p;
            //    }
            //}

            productToDelete = _products.SingleOrDefault(p=>p.ProductID==product.ProductID);

            _products.Remove(productToDelete);
        }

        public Product Get()
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryID)
        {
            return _products.Where(p => p.CategoryID == categoryID).ToList();


        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //gönderdiğim ürün ıdsine sahip listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
