namespace PrimaryConstructor.Models
{
    public class User(string name, string surname)
    {
        public User(string name, string surname, DateTime? birthDate) : 
            this(name, surname) { BirthDate = birthDate; }
        public string Name => name;
        public string Surname => surname;
        public DateTime? BirthDate { get; set; }
        public int? Age => BirthDate.HasValue ? (int?)((DateTime.Now - BirthDate.Value).Days / 365) : null;
        public string FullName => $"{Name} {Surname}";

        public void UserInfo()
        {
            System.Diagnostics.Debug.WriteLine($"Full Name: {FullName}");
            System.Diagnostics.Debug.WriteLine($"Surname: {Surname}");
            System.Diagnostics.Debug.WriteLine($"Birth Date: {BirthDate}");
            System.Diagnostics.Debug.WriteLine($"Age: {Age}");
        }
    }
}


//namespace PrimaryConstructor.Models
//{
//    public class User
//    {
//        public User(string name, string surname)
//        {
//            this.Name = name;
//            this.Surname = surname;
//        }
//        public string Name { get; set; }
//        public string Surname { get; set; }
//    }
//}

