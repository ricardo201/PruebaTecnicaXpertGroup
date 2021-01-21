using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Models
{
    public class ClassCelda
    {
        public long x { get; set; }
        public long y { get; set; }
        public long z { get; set; }
        public long v { get; set; }

        public void setCell(long x, long y, long z, long v)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.v = v;
        }

        public void setCell(long v)
        {
            this.v = v;
        }

        public long getCell()
        {
            return (this.v);
        }

    }
}
