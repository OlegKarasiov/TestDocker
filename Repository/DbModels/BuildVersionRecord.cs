using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.DbModels
{
    public class BuildVersionRecord
    {
        public byte SystemInformationID { get; }

       [Column("Database Version")]
       public string DatabaseVersion {get; }

        public DateTime VersionDate { get; }

        public DateTime ModifiedDate { get; }

        

    }
}
