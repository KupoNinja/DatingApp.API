using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Services
{
    public class ValuesRepository
    {
        private readonly DatingAppContext _db;

        public async Task<List<Value>> GetAll()
        {
            var values = await _db.Values.ToListAsync();

            return values;
        }

        public async Task<Value> GetById(int id)
        {
            var value = await _db.Values.FirstOrDefaultAsync(v => v.Id == id);

            return value;
        }

        public ValuesRepository(DatingAppContext db)
        {
            _db = db;
        }
    }
}