using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Demo.EF.Logic
{
    //Dentro de la clase LogicBase esta la la definición e instanciación del contexto
    public class ProductLogic : LogicBase, ILogic<Product>
    {
        public List<Product> Add(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> Delete(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        //Distintas formas de obtener un elemento por Id
        public Product GetOne(int id)
        {
            Product prodWithQuerySintax = (from prod in context.Products
                                           where prod.ProductID == id
                                           select prod).FirstOrDefault();
            ///Lo que esta escrito dentro del where (p => p.productID == id) es una lambda expression, y es una manera de pasar una expresion (o funcion)
            ///como parametro, donde "p" serian cada producto y la segunda parte es el cuerpo del metodo donde eb este caso estoy devolviendo si p.ProductID == Id
            Product product = context.Products.Where(p => p.ProductID == id).FirstOrDefault();
            
            ///La diferencia entre First y FirstOrDefault es que el FirstOrDefault si no encuentra un registro devuelve su valor por defecto
            Product product2 = context.Products.Where(p => p.ProductID == id).First();

            ///El metodo Single devuelve el elemento buscado, pero arroja una excepcion si encuentra mas de una ocurrencia
            Product product3 = context.Products.Where(p => p.ProductID == id).SingleOrDefault();
            Product product4 = context.Products.Where(p => p.ProductID == id).Single();
            
            Product product5 = context.Products.FirstOrDefault(p => p.ProductID == id);

            //En este caso esta seria la mejor, que el Find esta preparado para obtener los registros por su PK
            return context.Products.Find(id);
        }

        public Product Update(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
