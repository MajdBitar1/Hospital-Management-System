using Hosmansys.Repositorys.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hosmansys.Repositorys.Control
{
    internal class EmployeeDB
    {

        public async Task<List<Employee>> GetEmployeeListAsync()
        {
            List<Employee> Employeelist = new List<Employee>();
            try
            {
                using var context = new EnvEntities();
                Employeelist = await context.Employees.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Employeelist;
        }
        public List<Employee> GetEmployeeByNameAsParallel(String name)
        {
            List<Employee>? myemployee = null;
            try
            {
                using var context = new EnvEntities();
                myemployee = context.Employees.AsParallel().Where(p => p.Ename == name).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return myemployee;
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            Employee? MyEmployee = null;
            try
            {
                using var context = new EnvEntities();
                MyEmployee = await context.Employees.FirstOrDefaultAsync(u => u.Eid == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return MyEmployee;
        }

        public async Task AddEmployeeAsync(Employee Employee)
        {

            try
            {
                Employee MyEmployee = await GetEmployeeByIdAsync(Employee.Eid);
                if (MyEmployee == null)
                {
                    try
                    {
                        using var context = new EnvEntities();
                        await context.Employees.AddAsync(Employee);
                        await context.SaveChangesAsync();
                    }
                    catch (Exception ex) { throw new Exception(ex.Message); }

                }
                else
                {
                    throw new Exception("Employee already exists in the database");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateEmployeeAsync(Employee Employee)
        {
            try
            {
                Employee MyEmployee = await GetEmployeeByIdAsync(Employee.Eid);
                if (MyEmployee != null)
                {
                    try
                    {
                        using var context = new EnvEntities();
                        context.Employees.Update(Employee);
                        await context.SaveChangesAsync();
                    }
                    catch (Exception ex) { throw new Exception(ex.Message); }
                }
                else
                {
                    throw new Exception("Employee Doesn't exist in the database");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task RemoveEmployeeAsync(Employee Employee)
        {

            try
            {
                Employee MyEmployee = await GetEmployeeByIdAsync(Employee.Eid);
                if (MyEmployee != null)
                {
                    using var context = new EnvEntities();
                    context.Employees.Remove(Employee);
                    await context.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("Employee Doesn't exist in the database");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
