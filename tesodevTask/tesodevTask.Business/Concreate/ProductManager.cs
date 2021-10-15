using System;
using System.Collections.Generic;
using System.Text;
using tesodevTask.Business.Abstract;
using tesodevTask.DataAccess.Abstract;
using tesodevTask.DataAccess.Concreate;
using tesodevTask.Entities;

namespace tesodevTask.Business.Concreate
{
    public class ProductManager:IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager()
        {
            _productRepository = new ProductRepository();

        }

        public Product Create(Product product)
        {
            return _productRepository.Create(product);
        }

        public void Delete(Guid id)
        {
             _productRepository.Delete(id);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(Guid id)
        {
            return _productRepository.GetById(id);
        }

        public Product Update(Product product)
        {
            return _productRepository.Update(product);
        }
    }
}
