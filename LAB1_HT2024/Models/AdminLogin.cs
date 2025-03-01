using System.ComponentModel.DataAnnotations;

namespace LAB1_HT2024.Models
{
    public class AdminLogin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }
}
