using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class EmployeeLogic : LogicBase, ILogic<Employee>
    {
        public List<Employee> Add(Employee entity)
        {
            context.Employees.Add(entity);
            context.SaveChanges();

            return GetAll();
        }

        public List<Employee> Delete(Employee entity)
        {
            context.Employees.Remove(entity);

            return GetAll();
        }

        public List<Employee> GetAll()
        {
            return context.Employees.ToList();
        }

        public Employee GetOne(int id)
        {
            return context.Employees.Find(id);
                
        }

        public Employee Update(Employee entity)
        {
            var employee = context.Employees.Find(entity.EmployeeID);

            employee.FirstName = entity.FirstName;
            employee.LastName = entity.LastName;
            employee.Address = entity.Address;

            context.SaveChanges();
            return GetOne(entity.EmployeeID);


        }

        public List<Employee> GetAllOrderAP() {

            var empleadosOrder = from e in context.Employees
                                 orderby e.LastName, e.FirstName
                                 select e;

            return empleadosOrder.ToList();
        }

        public List<Employee> GetTresOlder() {

            var empleadosOrder = (from e in context.Employees
                                  orderby e.BirthDate
                                  select e).Take(3).ToList();


            return empleadosOrder;
        }

        public List<Employee> GetWithPC(int postalCode) {

            var employees = context.Employees.Where(e => e.PostalCode == postalCode.ToString()).Select(e => e);              
                
                /*from e in context.Employees
                           where e.PostalCode == postalCode.ToString()
                           select e;
                */

            return employees.ToList();
        }

        public List<Employee> GetEmpWithTerritories() {

            /* var employees = from emp in context.Employees
                             join terr in context.Territories on emp equals terr.Employees
                             select emp
                             ;
 */

            var employees = context.Employees.Include("Territories").ToList();

            return employees;
        }
    }
}
