namespace CoreL
{
    public class FPlayer
    {
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string Sex { get; set; }
        public required string DateOfBirthday { get; set; }
        public required string Country { get; set; }

        public FPlayer() {}

        public FPlayer(string name, string surname, string sex, string dateOfBirthday, string country)
        {
            Name = name;
            Surname = surname;
            Sex = sex;
            DateOfBirthday = dateOfBirthday;
            Country = country;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Sex: {Sex}, Date of Birthday: {DateOfBirthday}, Country: {Country}";
        }
    }
}
