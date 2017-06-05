using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Domain
{
    public class Paper
    {
        private int idP;
        private string title;
        private string keywords;
        private string topics;
        private string authors;
        private string publisher;
        private string datePaper;
        private string pathPaper;
        private int idSection;


        public Paper()
        {
            /*
            idP = 0;
            title = "";
            keywords = "";
            topics = "";
            authors = "";
            publisher = "";
            datePaper = "0/0/0";
            pathPaper = "";
            idSection = 0;
            */
        }
        		
        public Paper(int idp, string titlu, string keywrd, string topic, string author,string publishers, string dateP, string pathPaper, int idS)
		{
			idP = idp;
			title = titlu;
            keywords = keywrd;
			topics = topic;
			authors = author;
            publisher = publishers;
		this.pathPaper = pathPaper;
            datePaper = dateP;
            idSection = idS;
		}

        public Paper(Paper p)
		{
			idP = p.idP;
			title = p.title;
			keywords = p.keywords;
			topics = p.topics;
            authors = p.authors;
			publisher = p.publisher;
		this.pathPaper = p.pathPaper;
			datePaper = p.datePaper;
			idSection = p.idSection;
		}

		public int IdP
		{
			get
			{
				return idP;
			}

			set
			{
				idP = value;
			}
		}

        public string Title
		{
			get
			{
				return title;
			}

			set
			{
				title = value;
			}
		}

		public string Keywords
		{
			get
			{
                return keywords;
			}

			set
			{
                keywords = value;
			}
		}

		public string Topics
		{
			get
			{
                return topics;
			}

			set
			{
                topics = value;
			}
		}

		public string Authors
		{
			get
			{
                return authors;
			}

			set
			{
                authors = value;
			}
		}

		public string Publisher
		{
			get
			{
                return publisher;
			}

			set
            {
                publisher = value;
            }
		}

        public string DatePaper
		{
			get
			{
                return datePaper;
			}

			set
			{
                datePaper = value;
			}
		}
		public int IdSection
		{
			get
			{
                return idSection;
			}

			set
			{
                idSection = value;
			}
		}
        public string PathPaper
        {
            get
            {
                return pathPaper;
            }
            set
            {
                pathPaper = value;
            }
        }
	}
}

    

