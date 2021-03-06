﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGeometriH2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Square

            #region Objecter
            Square square0 = new Square(10);
            Square square1 = new Square(20);
            Square square2 = new Square(30);
            Square square3 = new Square(40);
            #endregion

            #region Omkredsen del (CW)
            Console.WriteLine("kvadratens omkredsen er " + square0.Omkredsen());
            Console.WriteLine("kvadratens omkredsen er " + square1.Omkredsen());
            Console.WriteLine("kvadratens omkredsen er " + square2.Omkredsen());
            Console.WriteLine("kvadratens omkredsen er " + square3.Omkredsen());
            #endregion

            #region Areal del (CW)
            Console.WriteLine("kvadratens Areal er " + square0.Areal());
            Console.WriteLine("kvadratens Areal er " + square1.Areal());
            Console.WriteLine("kvadratens Areal er " + square2.Areal());
            Console.WriteLine("kvadratens Areal er " + square3.Areal());
            #endregion

            #endregion 

            #region Parallelogram

            Square parallelogram = new Parallelogram(3,5,20);

            Console.WriteLine("Parallelogram areal er " + parallelogram.Areal().ToString("#.##"));
            Console.WriteLine("Parallelogram omkredesn er " + parallelogram.Omkredsen().ToString("#.##"));

            #endregion

            #region Trapez

            Square trapez = new Trapez(10, 9, 8, 9);

            Console.WriteLine("Arealet for trapezen er " + trapez.Areal().ToString("#.##"));

            #endregion

            #region Rektangel

            Square rektangel = new Rektangel(2,4);

            Console.WriteLine("Rektangel omkreds er " + rektangel.Omkredsen().ToString("#.##"));
            Console.WriteLine("Rektengel areal er " + rektangel.Areal().ToString("#.##"));

            #endregion

            #region retvinklet trekant

            Square retvinkletTrekant = new RetvinkletTrekant(5, 6);

            Console.WriteLine("retvinklert trekant areal er " + retvinkletTrekant.Areal().ToString("#.##"));
            Console.WriteLine("retvinklert trekant omkredesen er " + retvinkletTrekant.Omkredsen().ToString("#.##"));

            #endregion

            Console.ReadKey();
        }
    }
}
