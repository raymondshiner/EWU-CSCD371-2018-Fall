using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Assignment9
{
    public static class PatentDataAnalyzer
    {
        private static IEnumerable<object> thePatents;

        public static List<string> InventorNames(string country)
        {
            IEnumerable<string> inventors =
                PatentData.Inventors.Where(inventor => inventor.Country.Equals(country))
                    .Select(inventor => inventor.Name);
            List<string> newList = new List<string>(inventors);
            return newList;
        }

        public static IEnumerable<string> InventorLastNames()
        {
            IEnumerable<string> inventorLastNames =
                PatentData.Inventors.Select(inventor => new
                    {
                        inventor,
                        lastName = inventor.Name.Split(' ').Last()
                    })
                    .OrderByDescending(inventorWrap => inventorWrap.inventor.Id)
                    .Select(inventorWrap => inventorWrap.lastName);
            return inventorLastNames;
        }

        public static string LocationsWithInventors()
        {
            IEnumerable<string> Locations =
                PatentData.Inventors.Select(inventor => $"{inventor.State}-{inventor.Country}").Distinct().ToArray();

            return string.Join(", ", Locations);
        }
    }
}