using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Domain
{
    public class CommitteeMember: User
    {
        private string webpage;
        private string affiliation;
        private string role;
        
        public CommitteeMember()
        {

        }
        
        public CommitteeMember(string uname, string pass, string fname, string lname, string eml, string web, string afl, string role):
            base(uname,pass,fname,lname,eml)
        {
            this.webpage = web;
            this.affiliation = afl;
            this.role = role;
        }

        public string Webpage
        {
            get
            {
                return this.webpage;
            }

            set
            {
                this.webpage = value;
            }
        }

        public string Affiliation
        {
            get
            {
                return this.affiliation;
            }

            set
            {
                this.affiliation = value;
            }
        }

        public string Role
        {
            get
            {
                return this.role;
            }

            set
            {
                this.role = value;
            }
        }

        public override string ToString()
        {
            return base.ToString()+ " " + this.affiliation + " " + this.webpage + " " + this.role;
        }
    }
}
