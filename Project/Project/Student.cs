namespace Project
{
    class Student : Person
    {
        Student(string name, string surName, int age, int iqRank, int languageRank)
        {

            Name = name;
            SurName = surName;
            Age = age;
            IQRank = iqRank;
            LanguageRank = languageRank;
        }

        private int iqRank;
        private int languageRank;
        private int age;

        public override int Age { get { return age; } set { if (value > 20 || value < 6) { throw new Exception("Telebenin yasi uygun deyl"); } else { age = value; } } }
        public int IQRank { get { return iqRank; } set { if (value >= 100) { iqRank = 100; } else { iqRank = value; } } }
        public int LanguageRank { get { return languageRank; } set { if (value >= 100) { languageRank = 100; } else { languageRank = value; } } }

        public string ExamResult()
        {
            if (iqRank + languageRank < 120)
            {
                return "Sinifde qaldin";
            }
            return (iqRank + languageRank).ToString();
        }
    }
}
