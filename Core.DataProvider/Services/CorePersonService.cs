﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutofacResearch.Core.Interfaces;

namespace Core.DataProvider.Services
{
    public class CorePersonService: IPersonService
    {
        public string GetProviderName()
        {
            return "Core";
        }
    }
}
