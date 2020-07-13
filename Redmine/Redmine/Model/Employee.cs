using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Redmine.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int EmpId { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime LastActive { get; set; }
        public string PhoneNo { get; set; }
        public IEnumerable<Issue> IssuesAssigned { get; set; }
        public IEnumerable<Issue> IssuesReported { get; set; }
        public IEnumerable<Project> Projects { get; set; }
    }
}
