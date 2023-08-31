using System.ComponentModel.DataAnnotations.Schema;

namespace fitflexBackend.Models
{
    // Models/Member.cs
    [Table("Members")] // Specify the correct table name
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Add more properties as needed
    }

}
