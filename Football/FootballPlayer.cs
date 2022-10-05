namespace Football
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public override string ToString()
        {
            return "The player with id " + Id + " has name " + Name + " age is " + Age + " and wears a shirt number "+ ShirtNumber;
        }

        public void ValidateName()
        {
            if (Name == null)
                throw new ArgumentNullException(nameof(Name));

            if (Name.Length < 2)
                throw new ArgumentException(nameof(Name));
        }

        public void ValidateAge()
        {
            if (Age < 1)
                throw new ArgumentOutOfRangeException(nameof(Age));
        }
        public void ValidateShirtNumber()
        {
            if (ShirtNumber <= 1 || ShirtNumber >= 99)
                throw new ArgumentOutOfRangeException(nameof(Age));
        }
    }
}