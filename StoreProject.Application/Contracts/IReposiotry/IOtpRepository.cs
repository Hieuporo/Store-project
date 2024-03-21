﻿using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Contracts.IReposiotry
{
    public interface IOtpRepository : IGenericRepository<Otp>
    {
        Otp FindPendingOtpByCodeAndEmail(int code, string email);
        Otp FindPendingOtpByEmail(string email);


    }
}
