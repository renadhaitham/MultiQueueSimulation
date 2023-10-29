using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public static class Logic
    {
        public static void ReadFromFile(string fileName)
        {
            string fileContent;
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
            //To Do: use the data read from a file
        }

        public static void CalculateComulativeAndRange(List<TimeDistribution> timeDistributionList)
        {
            //To Do: calculate the commulative probability and range for a give time distribution
            if (timeDistributionList[0].CummProbability == timeDistributionList[0].Probability)
            {
                timeDistributionList[0].MinRange = 1;
                timeDistributionList[0].MaxRange = (int)(timeDistributionList[0].CummProbability) * 100;

            }
            for (int i = 1; i <= timeDistributionList.Count; i++)
            {
                timeDistributionList[i].CummProbability = timeDistributionList[i - 1].CummProbability + timeDistributionList[i].Probability;
                timeDistributionList[i].MinRange = (timeDistributionList[i-1].MaxRange + 1);
                timeDistributionList[i].MaxRange = (int)(timeDistributionList[i].CummProbability)*100 ;
            }
        }

        public static void CalculateServerPerformanceMeasures(Server server)
        {
            //To Do: Calculate the performance measures for a given server 
        }

        public static void CalculateSystemPerformanceMeasures()
        {
            //To Do: Calculate the performance measures for the system 
        }

    }
}
