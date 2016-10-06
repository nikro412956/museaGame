﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseumSpel
{
    // Delegate => publisher
    public delegate void KeyPressedEventHandeler(KeyEventArgs e);

    public partial class Form1 : Form
    {
        
        private SpeelVeld speelVeld; // model
        private Bitmap speler;
        private int penDikte;
        // Delegeate event
        public event KeyPressedEventHandeler KeyPressed;

        public Form1(SpeelVeld speelVeld)
        {
            InitializeComponent();
            this.speelVeld = speelVeld;
            penDikte = 2;
            speelVeld.speler.Cor_X += penDikte; // overlapping
            speelVeld.speler.Cor_Y += penDikte;

            speler = new Bitmap("Afbeeldingen\\Front_50PX.png");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            Pen p1 = new Pen(Color.Black, penDikte);
            Rectangle rec1 = new Rectangle(0, 0, speelVeld.borderX, speelVeld.borderY);
            if (rec1 != Rectangle.Empty)
            {
                dc.DrawRectangle(p1, rec1);
            }
            dc.DrawImage(speler, speelVeld.speler.Cor_X, speelVeld.speler.Cor_Y);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // event start
            if (KeyPressed != null) // Alleen doen wanneer event subscribers heeft
            KeyPressed(e);
        }
    }
}
