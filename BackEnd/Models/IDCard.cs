namespace BackEnd.Models
{
    public class IDCard
    {
        public IDCard() { }

        public IDCard(
            Guid id,
            string userId,
            string expireDate,
            string issueDate,
            string name,
            string sex,
            string address,
            string nationality,
            string idNumber,
            string birthday
        )
        {
            Id = id;
            UserId = userId;
            ExpireDate = expireDate;
            IssueDate = issueDate;
            Name = name;
            Sex = sex;
            Address = address;
            Nationality = nationality;
            IdNumber = idNumber;
            Birthday = birthday;
        }

        public Guid Id { get; set; }
        public required string UserId { get; set; }
        public required string ExpireDate { get; set; }
        public required string IssueDate { get; set; }
        public required string Name { get; set; }
        public required string Sex { get; set; }
        public required string Address { get; set; }
        public required string Nationality { get; set; }
        public required string IdNumber { get; set; }
        public required string Birthday { get; set; }
    }
}
