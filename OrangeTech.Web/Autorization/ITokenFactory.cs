﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OrangeTech.Web.Autorization
{
    public interface ITokenFactory
    {
        string Create(IList<Claim> claims);
    }
}
