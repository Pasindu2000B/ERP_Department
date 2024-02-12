using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Domain.Core.Entity.StudentEntity;

namespace ERP.Domain.Core.Entity.DepartmentEntity.LabEntity
{
    public class LabSession
    {
        public required Batch Batch { get; set; }
        public required Module Module { get; set; }

       

        public DateTime LabDate { get; set; }

        public required Person LabInstructor { get; set; }

        public bool LabWillBeHeld { get; set; }







    }
}
