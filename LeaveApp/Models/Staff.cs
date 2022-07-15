namespace LeaveApp.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Department { get; set; }
        
        public DateTime DateJoined { get; set; }

        public string? Designation { get; set; }
        public int LeaveDays { get; set; }
        public int Sickoffs { get; set; }

        public void ApplyLeave(int NoOfDays, DateTime Date, string? Note)
        {

        }

        public void ApplySickOff(int NoOfDays, DateTime Date, string? Note) 
        {
        
        }
    }
}
