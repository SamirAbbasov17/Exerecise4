namespace Project
{
    class Employee : Person
    {
        Employee(string name, string surName, int age, int salaryHour, int workingHour) {

            Name = name;
            SurName = surName;
            Age = age;
            SalaryHour = salaryHour;
            WorkingHour = workingHour;
        }
        
        private int workingHour;
        private int salaryHour;
        private int age;
        static DateTime now = DateTime.Now;
        
        int month = DateTime.DaysInMonth(now.Year, now.Month);

        public override int Age { get { return age; } set { if (value < 18) { throw new Exception("Iscinin yasi uygun deyl"); } else { age = value; } } }
        public int WorkingHour { get { return workingHour; } set { if (value >= 8) { workingHour = 8; } else { workingHour = value; } } }
        public int SalaryHour { get { return salaryHour; } set { if ((workingHour * value) * month <= 250) { salaryHour = (250 / month) / workingHour; } else { salaryHour = value; } } }

        public int CalculateSalary(int salaryHour)
        {
            return (workingHour * salaryHour)*month;
        }
    }
}
