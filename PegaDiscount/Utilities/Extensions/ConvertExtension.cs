﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegaDiscount.Utilities.Extensions
{
    public static class ConvertExtension
    {
        public static int ToInt32(this string value) {  return Convert.ToInt32(value); }
    }
}
