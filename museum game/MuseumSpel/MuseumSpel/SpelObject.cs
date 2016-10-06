using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumSpel
{
    //abstracte class voor ieder spel object
    public abstract class SpelObject
    {
        public Bitmap texure { get; set; } // not sure
        public string name { get; set; }
        private int cor_X;
        private int cor_Y;

        public SpelObject(string name, int cor_X, int cor_Y)
        {
            this.name = name;
            Cor_X = cor_X;
            Cor_Y = cor_Y;
        }

        public int Cor_X
        {
            get
            {
                return cor_X;
            }
            set
            {
                if (value >= 0)
                {
                    cor_X = value;
                }
            }
        }

        public int Cor_Y
        {
            get
            {
                return cor_Y;
            }
            set
            {
                if (value >= 0)
                {
                    cor_Y = value;
                }
            }
        }
    }
}