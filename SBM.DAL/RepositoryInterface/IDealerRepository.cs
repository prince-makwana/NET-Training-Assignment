﻿using SBM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBM.DAL.RepositoryInterface
{
    public interface IDealerRepository
    {
        string createDealer(Dealers model);
        string updateDealer(Dealers model);
        string deleteDealer(int id);

        Dealers GetDealerByEmailId(string emailId);
    }
}
