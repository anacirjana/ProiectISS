using MyProject.Domain;

using System.Diagnostics;

public class TestDomain
{
    public TestDomain() { }

    public void testare01()
    {
       
        Bidding c = new Bidding("", 12 , true);
        Debug.Assert(c.Accepted == true);
        Debug.Assert(c.IdPaper == 12);

        
        Paper p2 = new Paper(1, "Bayes Theorem", "#spam", "Internet", "Bill", "Science Daily", "2017-05-04", "path", 2);
        Debug.Assert(p2.IdP == 1);
        Debug.Assert(p2.Keywords == "#spam");

        Speaker s = new Speaker("username", "password", "ion", "iancu", "ion.iancu@email.com");
        Debug.Assert(s.FirstName == "ion");
        Debug.Assert(s.Email == "ion.iancu@email.com");
        
        User u = new User("username2", "password2", "Ben", "G", "beng@email.com");
        Debug.Assert(u.FirstName == "Ben");
        Debug.Assert(u.Email == "beng@email.com");
        

        Listener l = new Listener("andrei_b", "12345", "Andrei", "Barz", "barzandrei@email.com");
        Debug.Assert(l.FirstName == "Andrei");
        Debug.Assert(l.Email == "barzandrei@email.com");
        
        Review r = new Review("marcanton", 1, "reject", "The paper is not good enough to pass");
        Debug.Assert(r.Qualifier == "reject");
        Debug.Assert(r.UsernameCommiteeMember == "marcanton");

        CommitteeMember cm = new CommitteeMember("username", "pass", "Pop", "Antonio", "eml@mail.com", "www.web.ro", "Medicine","normal");
        Debug.Assert(cm.FirstName == "Pop");
        Debug.Assert(cm.Affiliation == "Medicine");

    }
}
