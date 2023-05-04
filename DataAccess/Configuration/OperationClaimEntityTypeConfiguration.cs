using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configuration
{
    public class OperationClaimEntityTypeConfiguration : IEntityTypeConfiguration<OperationClaim>
    {
        public void Configure(EntityTypeBuilder<OperationClaim> operationClaim)
        {
            operationClaim.HasKey(x => x.Id);
            operationClaim.Property(x => x.Name).IsRequired().HasColumnType("nvarchar(25)");

        }
    }
}
