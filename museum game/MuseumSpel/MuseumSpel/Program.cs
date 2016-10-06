using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseumSpel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Speler speler = new Speler("Dino", 0, 0, 50);
            SpeelVeld speelVeld = new SpeelVeld(8, 12, speler);
            GameTimer gameTimer = new GameTimer();
            GameLoop gameLoop = new GameLoop(gameTimer);
            Form1 form1 = new Form1(speelVeld); //publisher
            SpeelVeldController speelVeldController = new SpeelVeldController(form1, speelVeld);
            form1.KeyPressed += speelVeldController.OnKeyPressed; //subscriber
            Application.Run(form1);
            
            
        }
    }
}
