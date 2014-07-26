﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library.Interfaces.Entities;

namespace Library.Interfaces.Helpers
{
    interface IMemberHelper
    {
        IMember makeMember(string firstName, string lastName, string contactPhone, string emailAddress, int id);

    }
}
