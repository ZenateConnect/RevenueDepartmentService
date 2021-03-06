﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace RevenueService.Api.Controllers
{
    [Produces("application/json")]
    public class BaseApiController : ControllerBase
    {
        // คู่มือ SOAP Service กรมสรรพากร (The Revenue Department): http://www.rd.go.th/publish/42545.0.html
        public const string soapUsername = "anonymous";
        public const string soapPassword = "anonymous";
    }
}
