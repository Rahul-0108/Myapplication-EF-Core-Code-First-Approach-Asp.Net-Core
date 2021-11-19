
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Myapplication.Models
    {
    public class EmployeeClass
        {
        [Key]
        [JsonIgnore]
        public int SerialNo
            {
            get; set;
            }
        [Required]
        public int EmployeeId
            {
            get; set;
            }
        [Required]
        public string EmployeeName
            {
            get;
            set;
            }
        [Required]
        public int EmployeeSalary
            {
            get;
            set;
            }
        }
    }