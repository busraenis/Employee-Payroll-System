namespace Employee_Payroll_System.Models
{
    public class Employee:UserActivity
    {
        public int Id { get; set; }
        public string EmpNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName=>$"{FirstName}{LastName}";
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int DailySalary {  get; set; }
        public int DayToWork { get; set; }
        public int TotalSalary => DailySalary * DayToWork;
        public string Department {  get; set; }
        public string Address {  get; set; }

        public string Designation { get; set; }

    }
}
