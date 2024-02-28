using System;
namespace ClubInterface
{
    interface IClub
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname();
    }
    class Program
    {
        class ClubMember : IClub
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public DateTime JoinDate { get; set; }
            public bool IsActive { get; set; }

            public ClubMember()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
                Email = string.Empty;
            }
            public ClubMember(int id, string firstName, string lastName, string email, DateTime joinDate, bool isActive)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Email = email;
                JoinDate = joinDate;
                IsActive = isActive;
            }
            public string Fullname()
            {
                return FirstName + " " + LastName;
            }
            public void DisplayAdditionalFields()
            {
                Console.WriteLine($"Email: {Email}");
                Console.WriteLine($"Join Date: {JoinDate.ToShortDateString()}");
                Console.WriteLine($"Is Active: {IsActive}");
            }
        }

        static void Main(string[] args)
        {
            ClubMember member = new ClubMember();
            member.Id = 10;
            member.FirstName = "Bruce";
            member.LastName = "Wayne";
            member.Email = "bruce.wayne@gmail.com";
            member.JoinDate = DateTime.Parse("2024-02-26");
            member.IsActive = true;
            Console.WriteLine(member.Fullname());
            member.DisplayAdditionalFields();
        }
    }
}