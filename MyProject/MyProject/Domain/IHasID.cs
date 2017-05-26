using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Domain
{
    interface IHasID<T>
    {
        T Id { get; set; }
    }
}
