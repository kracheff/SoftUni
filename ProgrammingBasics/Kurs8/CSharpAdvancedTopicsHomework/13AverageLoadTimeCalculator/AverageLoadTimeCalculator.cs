using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13AverageLoadTimeCalculator
{
    class AverageLoadTimeCalculator
    {

        static void Main(string[] args)
        {
            //string[] firstReport =
            //    {
            //        "2014-Mar-02 11:33 http://softuni.bg 8.37725",
            //        "2014-Mar-02 11:34 http://www.google.com 1.335",
            //        "2014-Mar-03 21:03 http://softuni.bg 7.25",
            //        "2014-Mar-03 22:00 http://www.google.com 2.44",
            //        "2014-Mar-03 22:01 http://www.google.com 2.45",
            //        "2014-Mar-03 22:01 http://www.google.com 2.77"
            //    };

            string[] firstReport =
            {
                "2014-Apr-01 02:01 http://softuni.bg 8.37725",
                "2014-Apr-01 02:05 http://www.nakov.com 11.622",
                "2014-Apr-01 02:06 http://softuni.bg 4.33",
                "2014-Apr-01 02:11 http://www.google.com 1.94",
                "2014-Apr-01 02:11 http://www.google.com 2.011",
                "2014-Apr-01 02:12 http://www.google.com 4.882",
                "2014-Apr-01 02:34 http://softuni.bg 4.885",
                "2014-Apr-01 02:36 http://www.nakov.com 10.74",
                "2014-Apr-01 02:36 http://www.nakov.com 11.75",
                "2014-Apr-01 02:38 http://softuni.bg 3.886",
                "2014-Apr-01 02:44 http://www.google.com 1.04",
                "2014-Apr-01 02:48 http://www.google.com 1.4555",
                "2014-Apr-01 02:55 http://www.google.com 1.977"
            };

            Dictionary<string, double> firstReportDict = new Dictionary<string, double>();
            List<double> loadTimes = new List<double>();
            List<string> firstWebsitesList = new List<string>();

            // make a list only of the web sites
            for (int i = 0; i < firstReport.Length; i++)
            {
                string[] firstReportSplit = firstReport[i].Substring(18).Split(' ');
                for (int j = 0; j < firstReportSplit.Length; j++)
                {
                    if (j == 0)
                    {
                        firstWebsitesList.Add(firstReportSplit[0]);
                    }
                }
            }

            // make a list of the unique web sites
            List<string> uniqueFirstWebSites = new List<string>();

            for (int i = 0; i < firstWebsitesList.Count; i++)
            {
                if (!uniqueFirstWebSites.Contains(firstWebsitesList[i]))
                {
                    uniqueFirstWebSites.Add(firstWebsitesList[i]);
                }
            }
            // add load times to each dictionary
            for (int i = 0; i < uniqueFirstWebSites.Count; i++)
            {
                for (int j = 0; j < firstReport.Length; j++)
                {
                    string[] splitReport = firstReport[j].Substring(18).Split(' ');
                    if (uniqueFirstWebSites[i] == splitReport[0])
                    {
                        loadTimes.Add(double.Parse(splitReport[1]));
                    }
                }
                firstReportDict.Add(uniqueFirstWebSites[i], loadTimes.Average());
                loadTimes.Clear();
            }
            // print the dict
            foreach (var item in firstReportDict)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
