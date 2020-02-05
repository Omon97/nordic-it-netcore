using System;

namespace ClassWork_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point point = new Point();

            //point.X = 1.0F;
            //point.Y = -1.5F;
            //point.Z = 
            //point.Color = "Red";

            //Point point2 = new Point();

            //Console.WriteLine(point == point2);
            //Console.WriteLine(point.Equals(point2));

            //Wallet myWallet = new Wallet();
            ////myWallet.DollarsAmount = 100;
            ////myWallet.RublesAmount = 6289.25M;
            //myWallet.AddDollars(100);

            //Console.WriteLine(myWallet.GetRubles());
            //Console.WriteLine(myWallet.GetDollars());


            // спросить сколько потратит и в какой валюте
            // 

            //decimal ratio = myWallet.DollarsAmount / myWallet.RublesAmount;
            //myWallet.RublesAmount -= 50;
            //myWallet.DollarsAmount -= 50 * ratio;

            Pet p1 = new Pet
            {
                Name = "Sharik",
                Age = 4,
                Sex = 'M',
                Kind = Kind.Dog
            };
            Console.WriteLine(p1.Description);

            Pet p2 = new Pet
            {
                Name = "Motriskin",
                Age = 6,
                Sex = 'F',
                Kind = Kind.Cat
            };
            Console.WriteLine(p2.Description);

          

        }
    }

    class Point
    {
        public float X;
        public float Y;
        public float Z;
        public string Color;
    }

    //    class Wallet
    //    {
    //        private decimal _money;
    //        private const decimal _rublesRatio = 10;
    //        private const decimal _dollarsRatio = 628.925M;


    //        public decimal GetRubles()
    //        {
    //            return _money * _rublesRatio;
    //        }

    //        public decimal GetDollars()
    //        {
    //            return _money / _dollarsRatio;
    //        }

    //        public void AddRubles(decimal rublesToAdd)
    //        {
    //            _money += rublesToAdd * _rublesRatio;
    //        }

    //        public void AddDollars(decimal dollarsToAdd)
    //        {
    //            _money += dollarsToAdd * _dollarsRatio;
    //        }
    //    }
    //}
    class Wallet
    {
        private decimal _money { get; set; }
        private const decimal _rublesRatio = 10;
        private const decimal _dollarsRatio = 628.925M;


        public decimal GetRubles()
        {
            return _money * _rublesRatio;
        }

        public void SetRubles(decimal rublesToAdd)
        {
            _money += rublesToAdd * _rublesRatio;
        }

        public decimal Rubles
        {
            get { return _money / _rublesRatio; }
            set { _money = value * _rublesRatio; }
        }
        


        public decimal GetDollars()
        {
            return _money / _dollarsRatio;
        }

        

        public void AddDollars(decimal dollarsToAdd)
        {
            _money += dollarsToAdd * _dollarsRatio;
        }
    }
}
