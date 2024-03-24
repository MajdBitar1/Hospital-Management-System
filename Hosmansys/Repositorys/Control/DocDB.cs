using Hosmansys.Repositorys.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hosmansys.Repositorys.Control
{
    internal class DocDB
    {

        public async Task<List<Doctor>> GetDoctorListAsync()
        {
            List<Doctor> Doctorlist = new List<Doctor>();
            try
            {
                using var context = new EnvEntities();
                Doctorlist = await context.Doctors.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Doctorlist;
        }

        public async Task<Doctor> GetDoctorByIdAsync(int id)
        {
            Doctor? MyDoctor = null;
            try
            {
                using var context = new EnvEntities();
                MyDoctor = await context.Doctors.FirstOrDefaultAsync(u => u.DocId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return MyDoctor;
        }

        public List<Doctor> GetDoctorByNameAsParallel(String name)
        {
            List<Doctor>? myDoctor = null;
            try
            {
                using var context = new EnvEntities();
                myDoctor = context.Doctors.AsParallel().Where(p => p.Docname == name).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return myDoctor;
        }

        public async Task AddDoctorAsync(Doctor Doctor)
        {

            try
            {
                Doctor MyDoctor = await GetDoctorByIdAsync(Doctor.DocId);
                if (MyDoctor == null)
                {
                    try
                    {
                        using var context = new EnvEntities();
                        await context.Doctors.AddAsync(Doctor);
                        await context.SaveChangesAsync();
                    }
                    catch (Exception ex) { throw new Exception(ex.Message); }

                }
                else
                {
                    throw new Exception("Doctor already exists in the database");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateDoctorAsync(Doctor Doctor)
        {
            try
            {
                Doctor MyDoctor = await GetDoctorByIdAsync(Doctor.DocId);
                if (MyDoctor != null)
                {
                    try
                    {
                        using var context = new EnvEntities();
                        context.Doctors.Update(Doctor);
                        await context.SaveChangesAsync();
                    }
                    catch (Exception ex) { throw new Exception(ex.Message); }
                }
                else
                {
                    throw new Exception("Doctor Doesn't exist in the database");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task RemoveDoctorAsync(Doctor Doctor)
        {

            try
            {
                Doctor MyDoctor = await GetDoctorByIdAsync(Doctor.DocId);
                if (MyDoctor != null)
                {
                    using var context = new EnvEntities();
                    context.Doctors.Remove(Doctor);
                    await context.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("Doctor Doesn't exist in the database");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
