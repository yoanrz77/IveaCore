using IVEACore.Data;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace IVEACore.Models
{
    public class IveaIndex
    {
        public float CalculateIvea(float CFV, float DAS, float DFS, float MPE, float NCS, float NES, float NRS, float PES, float RCES, float RCS, float RES, float VBS, float AF)
        {
            float IndexIveaValue = (CFV + DAS + DFS + MPE + NCS + NES + NRS + PES + RCES + RCS + RES + VBS + AF / 13) / 100;

            float indexIveaValue = (float)Math.Round(IndexIveaValue, 2);

            return (indexIveaValue);
        }
    }

    //public class IveaIndex
    //{
    //    private readonly IVEACoreContext _context;
    //    public float IndexIveaValue;

    //    public IveaIndex(IVEACoreContext context)
    //    {
    //        _context = context;
    //    }

    //    public float CalculateIvea(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return 0;
    //        }

    //        //var farmSampling = _context.FarmSampling.FromSqlRaw("SELECT * FROM _context.FarmSampling");
    //        var farmSampling = _context.FarmSampling.FirstOrDefault(m => m.Id_Farm == id);
    //        float AF = farmSampling.Value_AF;
    //        float CFV = farmSampling.Value_CFV;

    //        //if (farmSampling == null)
    //        //{
    //        //    //return NotFound();
    //        //}

    //        float IndexIveaValue = ((AF + CFV) / 2) * 100;

    //        return (IndexIveaValue);
    //    }

    //    public float CalculateIvea(float Val1, float Val2)
    //    {
    //        float IndexIveaValue = ((Val1 + Val2) / 2) * 100;

    //        return (IndexIveaValue);
    //    }
    //}
}
