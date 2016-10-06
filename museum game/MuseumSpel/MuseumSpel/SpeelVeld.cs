using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumSpel
{
    // The Model, SuperClass
    public class SpeelVeld
    {
        //aantalRijen, aantalVakjes
        private int aantalVakkenX;
        private int aantalVakkenY;
        private int vakGrootte;
        public int borderX { get; set; }
        public int borderY { get; set; }
        public Speler speler { get; set; }

        public SpeelVeld(int aantalVakkenX, int aantalVakkenY, Speler speler)
        {
            this.aantalVakkenX = aantalVakkenX;
            this.aantalVakkenY = aantalVakkenY;
            vakGrootte = 50;
            this.speler = speler;            
            borderX = vakGrootte * aantalVakkenY;
            borderY = vakGrootte * aantalVakkenX;
        }

        public void SpelerMovement(string loopRichting)
        {
            switch (loopRichting)
            {
                case "up":
                    if (speler.Cor_Y >= 0)
                        speler.Cor_Y -= speler.speed;
                    break;
                case "down":
                    if (speler.Cor_Y + vakGrootte < borderY)
                        speler.Cor_Y += speler.speed;
                    break;
                case "left":
                    if (speler.Cor_X >= 0)
                        speler.Cor_X -= speler.speed;
                    break;
                case "right":
                    if (speler.Cor_X + vakGrootte < borderX)
                        speler.Cor_X += speler.speed;
                    break;
            }
        }
    }
}