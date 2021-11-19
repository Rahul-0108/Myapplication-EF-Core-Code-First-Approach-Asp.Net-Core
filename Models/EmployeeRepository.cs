using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myapplication.Models
    {
    public class EmployeeRepository : IEmployeeRepository
        {
        private readonly MyDBContextClass contextObject;

        public EmployeeRepository (MyDBContextClass context)
            {
            this.contextObject = context;
            }
        public bool AddEmployee (EmployeeClass myobject)
            {
            bool successCheck = false;
            //try
            //    {
            if ( myobject != null )
                {
                contextObject.Employees.Add(myobject);
                contextObject.SaveChanges();
                successCheck = true;
                }

            //    }
            //catch ( Exception )
            //    {
            //    }
            return successCheck;
            }

        public EmployeeClass DeleteEmployee (int id)
            {
            //    var employeeObject = contextObject.Employees.FirstOrDefault(b => b.EmployeeId == id);
            EmployeeClass employeeObject = contextObject.Employees.FirstOrDefault(b => b.EmployeeId == id);
            if ( employeeObject != null )
                {
                contextObject.Employees.Remove(employeeObject);
                contextObject.SaveChanges();
                }
            return employeeObject;
            }

        public IEnumerable<EmployeeClass> GetAllEmployees ()
            {
            return contextObject.Employees;
            }

        public EmployeeClass GetEmployee (int id)
            {
            // return contextObject.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            // return contextObject.Employees.Find(id);
            var employeeObject = contextObject.Employees.FirstOrDefault(b => b.EmployeeId == id);
            return employeeObject;
            }
        }
    }
