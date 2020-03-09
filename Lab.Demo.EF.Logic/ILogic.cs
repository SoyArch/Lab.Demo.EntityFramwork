using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    /// <summary>
    /// Esto es una Interfaz que utiliza un parametro de tipo T (T es un tipo generico) y nos permite reutilizar esta interfaz 
    /// e implementar distintas firmas para los metodos segun el tipo que se implente al usar la interfaz
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ILogic<T>
    {
        ///Al pasar distintos tipos cuando implente la interfaz obtendria distintos resultados de los metodos, ej: 
        ///* Si implemento la interfaz ILogic<Product> => tendria que crear un metodo List<Product> GetAll()
        ///* Si implemento la interfaz ILogic<Region> => tendria que crear un metodo List<Region> GetAll()
        
        List<T> GetAll();

        T GetOne(int id);

        List<T> Add(T entity);

        List<T> Delete(T entity);

        T Update(T entity);

    }
}
