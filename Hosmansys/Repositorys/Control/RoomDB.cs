using Hosmansys.Repositorys.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hosmansys.Repositorys.Control
{
    internal class RoomDB
    {
        public async Task<List<Room>> GetRoomListAsync()
        {
            List<Room> Roomlist = new List<Room>();
            try
            {
                using var context = new EnvEntities();
                Roomlist = await context.Rooms.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Roomlist;
        }

        public async Task<Room> GetRoomByIdAsync(int id)
        {
            Room? MyRoom = null;
            try
            {
                using var context = new EnvEntities();
                MyRoom = await context.Rooms.FirstOrDefaultAsync(u => u.Rid == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return MyRoom;
        }

        public List<Room> GetRoomByNameAsParallel(String name)
        {
            List<Room>? myRoom = null;
            try
            {
                using var context = new EnvEntities();
                myRoom = context.Rooms.AsParallel().Where(p => p.Rtype == name).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return myRoom;
        }

        public async Task AddRoomAsync(Room Room)
        {

            try
            {
                Room MyRoom = await GetRoomByIdAsync(Room.Rid);
                if (MyRoom == null)
                {
                    try
                    {
                        using var context = new EnvEntities();
                        await context.Rooms.AddAsync(Room);
                        await context.SaveChangesAsync();
                    }
                    catch (Exception ex) { throw new Exception(ex.Message); }

                }
                else
                {
                    throw new Exception("Room already exists in the database");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateRoomAsync(Room Room)
        {
            try
            {
                Room MyRoom = await GetRoomByIdAsync(Room.Rid);
                if (MyRoom != null)
                {
                    try
                    {
                        using var context = new EnvEntities();
                        context.Rooms.Update(Room);
                        await context.SaveChangesAsync();
                    }
                    catch (Exception ex) { throw new Exception(ex.Message); }
                }
                else
                {
                    throw new Exception("Room Doesn't exist in the database");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task RemoveRoomAsync(Room Room)
        {

            try
            {
                Room MyRoom = await GetRoomByIdAsync(Room.Rid);
                if (MyRoom != null)
                {
                    using var context = new EnvEntities();
                    context.Rooms.Remove(Room);
                    await context.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("Room Doesn't exist in the database");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
