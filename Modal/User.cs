using System.ComponentModel.DataAnnotations;

namespace Incident.Modal
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Tellphone { get; set; }
        public string EmployeeId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
        public bool Status { get; set; }
    }
}