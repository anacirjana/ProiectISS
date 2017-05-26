using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repository
{
    interface IValidator<T>
    {
        void validate(T item);
    }
}
