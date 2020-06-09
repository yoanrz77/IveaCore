using IVEACore.Controllers;
using IVEACore.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IVEACore.Models
{
    public class IveaIndex
    {
        private readonly IVEACoreContext _context;

        public IveaIndex(IVEACoreContext context)
        {
            _context = context;
        }

        public int CalculateIvea(int? id)
        {
            if (id == null)
            {
                //return NotFound();
            }

            var farm = _context.Farm.FirstOrDefault(m => m.Id_Farm == id);
            string MynameFarm = farm.NameFarm;
            
            if (farm == null)
            {
                //return NotFound();
            }

            int ivea = ((1 + 2) / 2) * 100;

            return (ivea);
        }
    }
}
