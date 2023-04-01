using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Box
    {
        //public int Volume { get; set; }
        private int FrontSurface;
        public int height;
        public int Length;
        public int volume;



        public int FrontSurFace
        {
            get
            {
                return FrontSurface = height * Length;
            }
        }



        public int Volume
        {
            get
            {
                return Volume;
            }
            set
            {
                this.Volume = value;
            }
        }
    }
}
