﻿using AccountLibrary.API.Entities;
using System;
using System.Collections.Generic;

namespace AccountLibrary.API.Services
{
    public interface IAccountLibraryRepository
    {  
        IEnumerable<Account> GetAccounts(string customerId);
        Account GetAccountDetailsByID(string accountNumber);

    }
}
