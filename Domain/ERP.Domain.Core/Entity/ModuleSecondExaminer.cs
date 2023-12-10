namespace ERP.Domain.Core.Entity
{
    public class ModuleSecondExaminer
    {
        public int ModuleId { get; set; }
        public Module Module { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}