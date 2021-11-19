using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myapplication.Models
    {
    public interface IEmployeeRepository
        {
        EmployeeClass GetEmployee (int id);
        bool AddEmployee (EmployeeClass myobject);
        EmployeeClass DeleteEmployee (int id);
        IEnumerable<EmployeeClass> GetAllEmployees ();
        }
    }