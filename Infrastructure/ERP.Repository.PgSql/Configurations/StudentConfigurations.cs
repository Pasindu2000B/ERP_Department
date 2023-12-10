using ERP.Domain.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.PgSql.Configurations
{
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(

               Enumerable.Range(1, 10).Select(index => new Student
               {
                   StudentId = index + 1000,
                   FirstName = Faker.Name.First(),
                   LastName = Faker.Name.Last(),
                   Phone = Faker.Phone.Number(),
                   Address1 = Faker.Address.StreetAddress()

               })
            );

        }
    }
}
