using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Myapplication.Models;

namespace Myapplication.Controllers
    {
  
    [Route("[controller]")]
    public class EmployeeController : Controller
        {
        private IEmployeeRepository m_employeeRepository;
        public EmployeeController (IEmployeeRepository employeeRepository)
            {
            m_employeeRepository = employeeRepository;
            }
        [HttpGet]
        [Route("[action]/{id}")]
        public JsonResult Get (int id)
            {
            JsonResult jsonResult = default(JsonResult);
            EmployeeClass modelObject = m_employeeRepository.GetEmployee(id);
            if ( modelObject != null )
                {
                jsonResult = new JsonResult(modelObject);
                }
            else
                {
                string valueReturn = "{''Operations'': ''failed''}";
                jsonResult = new JsonResult(valueReturn);
                }
            return jsonResult;
            }
        [HttpGet]
        [Route("[action]")]
        public JsonResult Get ()
            {
            JsonResult jsonResult = default(JsonResult);
            IEnumerable<EmployeeClass> modelObject = m_employeeRepository.GetAllEmployees();
            if ( modelObject != null )
                {
                jsonResult = new JsonResult(modelObject);
                }
            else
                {
                string valueReturn = "{''Operations'': ''failed''}";
                jsonResult = new JsonResult(valueReturn);
                }
            return jsonResult;
            }

        [Route("[action]/{id}")]
        public JsonResult Delete (int id)
            {
            JsonResult jsonResult = default(JsonResult);
            EmployeeClass modelObject = m_employeeRepository.DeleteEmployee(id);
            if ( modelObject != null )
                {
                jsonResult = new JsonResult(modelObject);
                }
            else
                {
                string valueReturn = "{''Operations'': ''failed''}";
                jsonResult = new JsonResult(valueReturn);
                }
            return jsonResult;
            }
        [Route("[action]")]
        [HttpPost]
        public JsonResult Post ([FromBody] EmployeeClass employeeObject)
            {
            JsonResult jsonResult = default(JsonResult);
            bool successCheck = m_employeeRepository.AddEmployee(employeeObject);
            if ( successCheck == true )
                {
                string successReturn = "{''Operations'': ''Success''}";
                jsonResult = new JsonResult(successReturn);
                }
            else
                {
                string falseReturn = "{''failed''}";
                jsonResult = new JsonResult(falseReturn);
                }
            return jsonResult;
            }
        }
    }


