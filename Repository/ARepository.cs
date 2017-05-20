using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ISS.Repository
    {
       public abstract class ARepository<ID,E>:IRepository<ID,E>
        {
            IDictionary<ID, E> items;
            public ARepository(IValidator<E> validator)
            {
                items = new Dictionary<ID, E>();
            }
            public AbsRepo()
            {
                items = new Dictionary<ID, T>();
            }


            public virtual void Delete(ID id)
            {
                items.Remove(id);

            }
            public virtual void update(E entityold, E entity)
            {
                items[entityold.Id]= entity;
            }

            public virtual IEnumerable<E> GetAll()
            {
                return items.Values;
            }

            public virtual E GetOne(ID id)
            {

                if (items.ContainsKey(id))
                    return items[id];
                else
                    return default(E);

            }

            public virtual void Save(E entity)
            {
                if (!items.ContainsKey(entity.Id))
                    items.Add(entity.Id, entity);
                else throw new RepositoryException("Duplicate entity " + entity);
            }
        }
}
