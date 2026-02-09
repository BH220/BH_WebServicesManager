using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH_WebServicesManager
{
    public class clsData
    {
        public string ServiceName { get; set; }
        public string DisplayName { get; set; }
        public string Url { get; set; }
        public string GitBranch { get; set; }
        public string GitUrl { get; set; }
        public string GitUser { get; set; }
        public string GitToken { get; set; }
        public string Path { get; set; }
    }
}
