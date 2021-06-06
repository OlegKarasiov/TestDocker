﻿using Repository.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IBuildVersionRepository
    {
        Task<BuildVersionRecord> GetBuildVersion();
    }
}
