using Hosmansys.Repositorys.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hosmansys.Repositorys.Control
{
    internal class PatientDB
    {
        public async Task<List<Patient>> GetPatientListAsync()
        {
            List<Patient> Patientlist = new List<Patient>();
            try
            {
                using var context = new EnvEntities();
                Patientlist = await context.Patients.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Patientlist;
        }

        public async Task<Patient> GetPatientByIdAsync(int id)
        {
            Patient? MyPatient = null;
            try
            {
                using var context = new EnvEntities();
                MyPatient = await context.Patients.FirstOrDefaultAsync(u => u.Pid == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return MyPatient;
        }

        public List<Patient> GetPatientByNameAsParallel(String name)
        {
            List<Patient>? myPatient = null;
            try
            {
                using var context = new EnvEntities();
                myPatient = context.Patients.AsParallel().Where(p => p.Pname == name).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return myPatient;
        }

        public async Task AddPatientAsync(Patient Patient)
        {

            try
            {
                Patient MyPatient = await GetPatientByIdAsync(Patient.Pid);
                if (MyPatient == null)
                {
                    try
                    {
                        using var context = new EnvEntities();
                        await context.Patients.AddAsync(Patient);
                        await context.SaveChangesAsync();
                    }
                    catch (Exception ex) { throw new Exception(ex.Message); }

                }
                else
                {
                    throw new Exception("Patient already exists in the database");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdatePatientAsync(Patient Patient)
        {
            try
            {
                Patient MyPatient = await GetPatientByIdAsync(Patient.Pid);
                if (MyPatient != null)
                {
                    try
                    {
                        using var context = new EnvEntities();
                        context.Patients.Update(Patient);
                        await context.SaveChangesAsync();
                    }
                    catch (Exception ex) { throw new Exception(ex.Message); }
                }
                else
                {
                    throw new Exception("Patient Doesn't exist in the database");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task RemovePatientAsync(Patient Patient)
        {

            try
            {
                Patient MyPatient = await GetPatientByIdAsync(Patient.Pid);
                if (MyPatient != null)
                {
                    using var context = new EnvEntities();
                    context.Patients.Remove(Patient);
                    await context.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("Patient Doesn't exist in the database");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }

}
