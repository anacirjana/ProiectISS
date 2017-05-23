using System;

namespace ISS
{
    public class Bidding
    {
        private string usernameCommiteeMember;
        private int idP;
        private bool acceptat;

        public Bidding()
        {
            this.usernameCommiteeMember = "";
            this.idP = -1;
            this.acceptat = false;
        }

        public Bidding(string usernameComiteeMember)
        {
            this.usernameCommiteeMember = usernameCommiteeMember;
            this.idP = -1;
            this.acceptat = false;
        }

        public Bidding(string username, int idp)
        {
            this.usernameCommiteeMember = username;
            this.idP = idp;
            this.acceptat = false;
        }

        public Bidding(string username, int idp, bool acceptat)
        {
            this.usernameCommiteeMember = username;
            this.idP = idp;
            this.acceptat = acceptat;
        }

        public string UsernameCommiteeMember
        {
            get
            {
                return usernameCommiteeMember;
            }

            set
            {
                usernameCommiteeMember = value;
            }
        }

        public int IdP
        {
            get
            {
                return idP;
            }
            set
            {
                this.idP = value;
            }
        }

        public bool Acceptat
        {
            get
            {
                return acceptat;
            }
            set
            {
                this.acceptat = acceptat;
            }
        }

        public string toString()
        {
            return this.usernameCommiteeMember;
        }
    }
}
