using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Text;

namespace BLL
{
    interface IRepository<T> where T:class
    {
        bool Guardar(T entity);
        bool Modificar(T entity);
        bool Eliminar(int Id);
        T Buscar(int Id);
        List<T> GetList(Expression<Func<T, bool>> expression);

    }
}