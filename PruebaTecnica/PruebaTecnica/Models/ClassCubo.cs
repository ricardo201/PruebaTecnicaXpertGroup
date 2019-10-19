using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Models
{
    public class ClassCubo
    {
        List<ClassCelda> celdas { get; set; }
        long n;

        

        public ClassCubo(long dimension)
        {
            n = dimension;
            celdas = new List<ClassCelda>();
            for (long x = 1; x <= n; x++)
            {
                for (long y = 1; y <= n; y++)
                {
                    for (long z = 1; z <= n; z++)
                    {
                        ClassCelda celda = new ClassCelda();
                        celda.setCell(x, y, z, 0);
                        celdas.Add(celda);
                    }
                }
            }
        }

        public void UpdateCell(long x, long y, long z, long v)
        {
            ((celdas.First(c => c.x == x && c.y == y && c.z == z))).setCell(v);
        }        

        public string Query(long x1, long y1, long z1, long x2, long y2, long z2)
        {
            long sum = 0;
            sum = celdas.Where(c => c.x >= x1 && c.y >= y1 && c.z >= z1 && c.x <= x2 && c.y <= y2 && c.z <= z2 && c.v != 0).Sum(c => c.v);
            return sum.ToString();
        }
    }
}
