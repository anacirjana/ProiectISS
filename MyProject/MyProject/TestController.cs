using MyProject.Controller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Tests
{
    class TestController
    {
        public TestController() { }


        public void testCtr()
        {
            ControllerSpeakers ctrs = new ControllerSpeakers();
            Debug.Assert(ctrs.getOneSpeaker("SaraT").Username=="SaraT");

            ControllerReviews ctrr = new ControllerReviews();
            Debug.Assert(ctrr.GetOne(1).Qualifier == "accept");

            ControllerBiddings ctrcm = new ControllerBiddings();
            Debug.Assert(ctrcm.getOneBidding("AndiP", 5).Accepted==true);

            ControllerListeners ctrl = new ControllerListeners();
            Debug.Assert(ctrl.getOneListener("TedG").Username == "TedG");
        }
        
    }
}
