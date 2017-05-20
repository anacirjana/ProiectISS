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

    namespace ISS.Exception
    {
        public class RepositoryException : ApplicationException
        {
            public RepositoryException(string msg)

            : base(msg) { }

        }
    }
}
