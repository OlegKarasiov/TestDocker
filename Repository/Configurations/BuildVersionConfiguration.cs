using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.DbModels;


namespace Repository.Configurations
{
    class BuildVersionConfiguration : IEntityTypeConfiguration<BuildVersionRecord>
    {
        public void Configure(EntityTypeBuilder<BuildVersionRecord> builder)
        {
            builder.ToTable("BuildVersion");

            builder.HasKey(p => p.SystemInformationID);

            builder.Property(p => p.DatabaseVersion).IsRequired();

            builder.Property(p => p.VersionDate).IsRequired();

            builder.Property(p => p.ModifiedDate).IsRequired();

        }
    }
}
