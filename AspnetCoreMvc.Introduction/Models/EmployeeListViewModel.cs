using System.Collections.Generic;
using AspnetCoreMvc.Introduction.Entities;

namespace AspnetCoreMvc.Introduction.Models
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<string> Cities { get; set; }
    }
}