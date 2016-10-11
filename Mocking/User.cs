using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking
{
    public enum Rights { Full, None }

    public class User
    {
        public String UserName {get; set;}
        public String Password {get; set;}
        public Rights Rights {get; set;}

        public int    NumMessagesCreated {get; set;}

        public string ViewAllEmployees(){return "Here is the list";}
    }
}
