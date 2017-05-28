using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Domain
{
    class Bidding
    {
        private string usernameCommitteeMember;
        private int idPaper;
        private bool accepted;

        public Bidding(string user, int paper, bool accept)
        {
            this.usernameCommitteeMember = user;
            this.idPaper = paper;
            this.accepted = accept;
        }

        public string UsernameCommitteeMember
        {
            get
            {
                return this.usernameCommitteeMember;
            }

            set
            {
                this.usernameCommitteeMember = value;
            }
        }

        public int IdPaper
        {
            get
            {
                return this.idPaper;
            }

            set
            {
                this.idPaper = value;
            }
        }

        public bool Accepted
        {
            get
            {
                return this.accepted;
            }

            set
            {
                this.accepted = value;
            }
        }

        public override string ToString()
        {
            return this.usernameCommitteeMember + " " + this.idPaper.ToString() + " " + this.accepted.ToString();
        }
    }
}
