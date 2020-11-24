using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DTO
{
    class accountDTO
    { 
        private string userName;
        private string passWords;

        public string UserName
        {
            get => userName;
            set { userName = value; }
        }
        public string PassWords
        {
            get => passWords;
            set { passWords = value; }
        }
    }
}
