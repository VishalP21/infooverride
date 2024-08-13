using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infooverride
{
    public class infomation
    {
        public string firstname {  get; set; }
        public string lastname { get; set; }

        public override string ToString()
        {
            return $"{firstname} {lastname}";
        }
    }
}
