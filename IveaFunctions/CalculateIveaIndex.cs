using System;

namespace IVEACore.Models
{
    public class IveaIndex
    {
        public float CalculateIvea(float CFV, float DAS, float DFS, float MPE, float NCS, float NES, float NRS, float PES, float RCES, float RCS, float RES, float VBS, float AF)
        {
            float IndexIveaValue = (CFV + DAS + DFS + MPE + NCS + NES + NRS + PES + RCES + RCS + RES + VBS + AF / 13) / 100;

            float indexIveaValue = (float)Math.Round(IndexIveaValue, 2);

            return indexIveaValue;
        }
    }
}