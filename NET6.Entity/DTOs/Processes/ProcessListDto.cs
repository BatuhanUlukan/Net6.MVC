using NET6.Entity.Entities;


namespace NET6.Entity.DTOs.Processes
{
    public class ProcessListDto
    {
        public IList<Process> Processes { get; set; }

        public Image Image { get; set; }
        public virtual bool IsAscending { get; set; } = false;


    }
}
