using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Domain
{
     class Abstract
    {
        private Int32 idP;
        private String pathAbstract;
        
        public Abstract()
        {
            idP = 0;
            pathAbstract="";   
        }
          
        public Abstract(Int32 idP, String pathAbstract)
        {
            this.idP = idP;
            this.pathAbstract = pathAbstract;
        }

        public Abstract(Abstract ab)
        {
            this.idP = ab.idP;
            this.pathAbstract = ab.pathAbstract;
        }

       public  Int32 Id
        {
            get
            {
                return this.idP;
            }
                
                
            set
            {
                idP = value;
            }

        }

        public  String Path
        {
            get
            {
                return pathAbstract;
            }

            set
            {
                pathAbstract = value;
            }
        }

        public override string ToString()
        {
            return this.idP + " " + this.pathAbstract;
        }
    }
}
