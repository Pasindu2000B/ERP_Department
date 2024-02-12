using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Domain.Core.Entity.StudentEntity;

namespace ERP.Domain.Core.Entity.DepartmentEntity.WorkLoadEntity
{
    public class LectureSchedule
    {
        public int LectureScheduleID { get; set; }
        public required ModuleOffering moduleOffering { get; set; }

        public DateTime Starttime { get; set; }

        public DateTime Endtime { get; set; }

        public required Batch batch { get; set; }





    }
}
