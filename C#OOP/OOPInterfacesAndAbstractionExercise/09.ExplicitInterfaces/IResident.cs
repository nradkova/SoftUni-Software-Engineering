﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
   public interface IResident
    {
        public string  Name { get; }
        public string Country { get; }
        public void GetName();
    }
}
