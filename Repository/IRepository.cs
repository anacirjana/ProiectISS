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
        public interface IRepository<ID, E>
        {
            void Save(E elem);
            void Delete(ID id);
            E GetOne(ID id);
            IEnumerable<E> GetAll();
            void Update(E e1, E e2);
        }
    }

}
