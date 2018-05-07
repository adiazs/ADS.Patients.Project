﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADS.Health.WEB.Models
{
       public class Alert
        {
            public const string TempDataKey = "TempDataAlerts";

            public string AlertStyle { get; set; }
            public string Message { get; set; }
            public bool Dismissable { get; set; }
        }
    }