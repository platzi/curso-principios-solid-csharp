namespace OpenClose
{
    public class EmployeeFullTime
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }  
    }
}