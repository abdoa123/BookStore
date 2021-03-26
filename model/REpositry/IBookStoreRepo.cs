using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.model.REpositry
{
    interface IBookStoreRepo<TEntity>
    {
        IList<TEntity> List();
        TEntity find(int id);
        void Add(TEntity entity);
        void update(int id,TEntity entity); 
        void Delete(int id); 
    }
}
