using System.Collections.Generic;

namespace IVEACore.IveaFunctions
{
    public class GetDropDownListValues
    {
        private List<int> ValueList = new List<int>() {};

        public List<int> GetLevel(int filedValue)
        {
            if (filedValue < 4)
            {
                ValueList = new List<int>(3) { 1, 2, 3 };
            }
            else if (filedValue > 6)
            {
                ValueList = new List<int>(3) { 7, 8, 9 };
            }
            else
            {
                ValueList = new List<int>(3) { 4, 5, 6 };
            }

            return ValueList;
        }
    }

    //    public IEnumerable<int> GetLevel1()
    //    {
    //        Filtering the values for Level1
    //        var ValueListFiltered = ValueList.Where(v => v < 4);
    //        return ValueListFiltered;
    //    }

}
