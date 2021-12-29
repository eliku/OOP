using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_task3
{
    class InfoPerson
    {
        private string _FullName;
        private string _Email;

        public string FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                _FullName = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }

        public void SearchMail(ref string s)
        {
            s = s.Substring(s.IndexOf('&') + 1);        
        }
    }
}
