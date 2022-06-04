using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUI
{
    public class Rule_Regex
    {
        private static Rule_Regex instance;

        public static Rule_Regex Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Rule_Regex();
                }
                return instance;
            }
        }


        public Regex UserNam_Regex = new Regex(@"[^a-zA-Z0-9{@}]|([\s])");
        public Regex Name_Regex = new Regex(@"([^\w\s])|([0-9])");
        public Regex Address_Regex = new Regex(@"([^\w\s0-9\{/}])");
        public Regex MobileNumber_Regex = new Regex(@"[^0-9]");
        public Regex Password_Regex = new Regex(@"([^\a-zA-Z])|([\s])");
        public Regex Number_Regex = new Regex(@"([^0-9])");
    }
}
