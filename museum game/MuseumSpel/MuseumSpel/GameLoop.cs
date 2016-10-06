using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumSpel
{
    public class GameLoop
    {
        private GameTimer GameTimer;
        private bool GameOver = false;
        private bool Pause = false;

        public GameLoop(GameTimer Timer)
        {
            this.GameTimer = Timer;
        }

        public void Loop()
        {
            while (!GameOver)
            {
                if (!Pause)
                {
                    
                }
            }
        }
    }
}
