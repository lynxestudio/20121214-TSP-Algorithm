using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Xml;

namespace TSP
{
    public partial class pnDraw : UserControl
    {
        int SupplyPointCount;
        int populationSize;
        double mutationPercent;
        bool isRunning;
        public bool IsRunning() {
            return isRunning;
        }
        public void SetCityCount(int c) {
            SupplyPointCount = c;
        }

        public void SetpopulationSize(int b) {
            populationSize = b;
        }

        public void SetmutationPercent(double a) {
            mutationPercent = a;
        }

        protected int matingPopulationSize;
        protected int favoredPopulationSize;
        protected int cutLength;
        protected int generation;
        protected Thread worker = null;
        protected SupplyPoint[] cities;
        protected Chromosome[] chromosomes;
        public bool started = false;
        Random random = new Random();
        int toppanel = 60;
        double mutationRate;
        double thisCost;
        double timeRunning;
        //persistence


        public pnDraw()
        {
            InitializeComponent();
        }

        private void pnDraw_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush sb = new SolidBrush(System.Drawing.Color.Black);
            Pen pb = new Pen(new SolidBrush(Color.SteelBlue));
            e.Graphics.DrawRectangle(pb, new Rectangle(0,0, Width - 8, toppanel));
            e.Graphics.DrawString(string.Format("Generation [   {0}   ] - Cost [   {1}    ] - Mutate % [  {2}  ]",generation,(int)thisCost,mutationRate),
                new Font("Helvetica", 10), sb, 4,toppanel - 30);
            SolidBrush rb = new SolidBrush(Color.Navy);
            e.Graphics.DrawString(String.Format("Running... {0}  ", Convert.ToString(timeRunning)),
                new Font("Helvetica", 10, FontStyle.Bold), rb, Width - 333, toppanel - 30);
            update(e.Graphics);
           
        }//end method

        public void update(Graphics g)
        {           

            if (started && (cities != null))
            {
                SolidBrush sb = new SolidBrush(System.Drawing.Color.Red);
                for (int i = 0; i < SupplyPointCount; i++)
                {
                    int xpos = cities[i].getx();
                    int ypos = cities[i].gety();
                    g.FillEllipse(sb,xpos - 5, ypos - 5, 10, 10);
                    g.DrawString(i.ToString(), new Font("Courier", 10), sb, xpos - 10, ypos + 5);
                }

                Pen pw = new Pen(System.Drawing.Color.Blue);
                for (int i = 0; i < SupplyPointCount; i++)
                {
                    int iSupplyPoint = chromosomes[0].getCity(i);
                    if (i != 0)
                    {
                        int last = chromosomes[0].getCity(i - 1);
                        g.DrawLine(pw,
                                  cities[iSupplyPoint].getx(),
                                  cities[iSupplyPoint].gety(),
                                  cities[last].getx(),
                                  cities[last].gety());
                    }
                }

            }
        }//end method
        //este metodo establece el valor predeterminado de todas las variables
        public void startThread()
        {
            
            matingPopulationSize = populationSize / 2;
            favoredPopulationSize = matingPopulationSize / 2;
            cutLength = SupplyPointCount / 5;
            cities = new SupplyPoint[SupplyPointCount];
            //	 crea una lista aleatoria de ciudades
            for (int i = 0; i < SupplyPointCount; i++)
            {
                cities[i] = new SupplyPoint((int)(random.NextDouble() * Width - 20), (int)(random.NextDouble() * Height) + toppanel );
            }
            //// se crean los cromosomas iniciales
            chromosomes = new Chromosome[populationSize];
            for (int i = 0; i < populationSize; i++)
            {
                chromosomes[i] = new Chromosome(cities);
                chromosomes[i].setCut(cutLength);
                chromosomes[i].setMutation(mutationPercent);
            }
            Chromosome.sortChromosomes(chromosomes, populationSize);
            started = true;
            generation = 0;
        }

        public void run()
        {
            isRunning = true;
            thisCost = 500.0;
            double oldCost = 0.0;
           //double dcost = 500.0;
            int countSame = 0;
            Invalidate();
            DateTime begin = DateTime.Now;
            while (countSame < 100)
            {
                generation++;
                int ioffset = matingPopulationSize;
                int mutated = 0;
                for (int i = 0; i < favoredPopulationSize; i++)
                {
                    Chromosome cmother = chromosomes[i];
                
                    int father = (int)(0.999999 * random.NextDouble() * (double)matingPopulationSize);
                    Chromosome cfather = chromosomes[father];

                    mutated += cmother.mate(cfather, chromosomes[ioffset], chromosomes[ioffset + 1]);
                    ioffset += 2;
                }
                for (int i = 0; i < matingPopulationSize; i++)
                {
                    chromosomes[i] = chromosomes[i + matingPopulationSize];
                    chromosomes[i].calculateCost(cities);
                }   
                Chromosome.sortChromosomes(chromosomes, matingPopulationSize);

                double cost = chromosomes[0].getCost();
                //double dcost = Math.Abs(cost - thisCost);
                thisCost = cost;
                mutationRate = 100.0 * (double)mutated / (double)matingPopulationSize;
                if ((int)thisCost == (int)oldCost)
                {
                    countSame++;
                }
                else
                {
                    countSame = 0;
                    oldCost = thisCost;
                }
                
                DateTime end = DateTime.Now;
                TimeSpan t1 = end - begin;
                timeRunning = t1.TotalMilliseconds;
                Invalidate();
                isRunning = false;
            }
            
        }

        
    }
}
