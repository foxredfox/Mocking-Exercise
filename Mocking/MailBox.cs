using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking
{
    public class MailBox
    {
        public  int NumReceivedMessages { 
            get{ return list.Count(); }
            set{ }
        }

        private IList<Mail> list = new List<Mail>();
        

        public void Add(Mail m) { list.Add(m); }

        public String GetLatestMessageText()
        {
            return list.Last().Content;
        }

        
    }
}
