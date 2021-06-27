using EmployeeManager.DataAccess;
using EmployeeManager.DTOs;
using EmployeeManager.Helpers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace EmployeeManager.Service
{
    public class EmployeeService
    {
        public int GetPageCount()
        {
            WebApiCaller webApiCaller = new WebApiCaller();
            string paginationTagJson = webApiCaller.CallGetOperation("users", "meta");
            string paginationJson = JObject.Parse(paginationTagJson)["pagination"].ToString();
            JsonSerializationHelper<Pagination> jsonSerializationHelper = new JsonSerializationHelper<Pagination>();
            Pagination pagination = jsonSerializationHelper.DeserializeFromString(paginationJson);
            return pagination.Pages;
        }
        public List<Employee> GetAllEmployees(int pageNumber)
        {
            WebApiCaller webApiCaller = new WebApiCaller();
            string employeesJson = webApiCaller.CallGetOperation($"users?page={pageNumber}");
            JsonSerializationHelper<List<Employee>> jsonSerializationHelper = new JsonSerializationHelper<List<Employee>>();
            List<Employee> employees = jsonSerializationHelper.DeserializeFromString(employeesJson);
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            WebApiCaller webApiCaller = new WebApiCaller();
            string response = webApiCaller.CallGetOperation($"users/{id}");
            JsonSerializationHelper<Employee> jsonSerializationHelper = new JsonSerializationHelper<Employee>();
            Employee employee = jsonSerializationHelper.DeserializeFromString(response);
            return employee;
        }

        public bool DeleteEmployee(int id)
        {
            WebApiCaller webApiCaller = new WebApiCaller();
            bool response = webApiCaller.CallDeleteOperation($"users/{id}");
            return response;
        }
        public Employee UpdateEmployee(Employee employee)
        {
            JsonSerializationHelper<Employee> jsonSerializationHelper = new JsonSerializationHelper<Employee>();
            string inputJson = jsonSerializationHelper.SerializeObject(employee);
            WebApiCaller webApiCaller = new WebApiCaller();
            string employeeJson = webApiCaller.CallPutOperation($"users/{employee.Id}", inputJson);
            Employee updatedEmployee = jsonSerializationHelper.DeserializeFromString(employeeJson);
            return updatedEmployee;
        }

        public Employee CreateEmployee(Employee employee)
        {
            JsonSerializationHelper<Employee> jsonSerializationHelper = new JsonSerializationHelper<Employee>();
            string inputJson = jsonSerializationHelper.SerializeObject(employee);
            WebApiCaller webApiCaller = new WebApiCaller();
            string employeeJson = webApiCaller.CallPostOperation($"users", inputJson);
            Employee updatedEmployee = jsonSerializationHelper.DeserializeFromString(employeeJson);
            return updatedEmployee;
        }

        internal string Export(string selectedPath, List<Employee> employees)
        {
            try
            {

                StringBuilder csv = new StringBuilder();
                foreach (var employee in employees)
                {
                    StringBuilder line = new StringBuilder();
                    foreach (PropertyInfo propertyInfo in employee.GetType().GetProperties())
                    {
                        line.Append(propertyInfo.GetValue(employee, null));
                        line.Append(",");
                    }
                    line.Remove(line.Length - 1, 1);
                    csv.AppendLine(line.ToString());
                }
                string fileName = $@"{selectedPath}\{Guid.NewGuid()}.csv";
                File.WriteAllText(fileName, csv.ToString());
                return fileName;
            }catch(Exception ex)
            {
                Logger.Log($"{ex.Message}{Environment.NewLine}{ex.StackTrace}");
                return string.Empty;
            }
        }
    }
}
