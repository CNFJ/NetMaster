using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetMaster.Blog.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Display(Name ="部门名称")]
        public string Name { get; set; }
        [Display(Name = "地址")]
        public string Location { get; set; }
        [Display(Name = "人数")]
        public int EmployeeCount { get; set; }
    }
}
