using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Redmine.Model
{
    public class Issue
    {
        public int Id { get; set; }
        public string IssueName { get; set; }
        public string Description { get; set; }
        public int IssueNumber { get; set; }
        public IssueType Type { get; set; }

    }
}
