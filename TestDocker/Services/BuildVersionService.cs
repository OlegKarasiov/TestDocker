using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.DbModels;
using Repository.Interfaces;

namespace TestDocker.Services
{
    public class BuildVersionService : IBuildVersionRepository
    {

        private DbSet<BuildVersionRecord> _dbSet;
        public BuildVersionService(AppDbContext context)
        {
            _dbSet = context.BuildVersion;
            
        }
        public async Task<BuildVersionRecord> GetBuildVersion()
        {
            var result = await _dbSet.FirstOrDefaultAsync();
            return result;
        }
    }
}
