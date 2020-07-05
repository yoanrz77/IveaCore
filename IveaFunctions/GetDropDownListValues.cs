using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IVEACore.IveaFunctions
{
    public class GetDropDownListValues
    {
        private List<int> ValueList = new List<int>(9) { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public IEnumerable<int> GetLevel1()
        {
            //Filtering the values for Level1 
            var ValueListFiltered = ValueList.Where(v => v < 4);

            return ValueListFiltered;
        }

        public IEnumerable<int> GetLevel2()
        {
            //Filtering the values for Level2 
            var ValueListFiltered1 = ValueList.Where(v => v  > 3);
            var ValueListFiltered = ValueListFiltered1.Where(v => v  < 7 );

            return ValueListFiltered;
        }

        public IEnumerable<int> GetLevel3()
        {
            //Filtering the values for Level3 
            var ValueListFiltered = ValueList.Where(v => v > 6);

            return ValueListFiltered;
        }

    }
}
