using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Models
{
    public class SumCube
    {
        public List<string> output { get; set; }
        public string input { get; set; }
        ClassCubo cubo;

        public SumCube(string input)
        {
            this.input = input;
        }

        public void Summation()
        {
            output = new List<string>();
            string[] lines = input.Split("\r\n");

            long testCase = long.Parse(lines[0]);
            long j = 1;
            for (long i = 1; i <= testCase; i++)
            {
                string testCaseString = lines[j];

                string[] data = testCaseString.Split(' ');
                long N = long.Parse(data[0]);
                long M = long.Parse(data[1]);
                cubo = new ClassCubo(N);
                for (long operations = 1; operations <= M; operations++)
                {
                    string operationsString = lines[j + operations];
                    string[] operationData = operationsString.Split(' ');
                    if (operationData[0] == "UPDATE")
                    {
                        cubo.UpdateCell(long.Parse(operationData[1]), long.Parse(operationData[2]), long.Parse(operationData[3]), long.Parse(operationData[4]));

                    }
                    else
                    {
                        output.Add(cubo.Query(long.Parse(operationData[1]), long.Parse(operationData[2]), long.Parse(operationData[3]), long.Parse(operationData[4]), long.Parse(operationData[5]), long.Parse(operationData[6])));
                    }
                }

                j = j + M + 1;


            }



            
        }
    }
}
