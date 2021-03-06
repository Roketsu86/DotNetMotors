﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class Turcell : Coupe, INeedKey, INeedGas
    {
        public override bool BackseatSpace { get; set; } = true;
        public override int Cost { get; set; } = 2000;

        public int FillWithGas()
        {
            return 12;
        }

        public override bool Start()
        {
            Console.WriteLine(UseKey());
            return true;
        }

        public string UseKey()
        {
            return "Turns key.";
        }
    }
}
