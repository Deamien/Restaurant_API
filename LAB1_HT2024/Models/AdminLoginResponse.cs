namespace LAB1_HT2024.Models
{
    public class AdminLoginResponse
    {
        public string UserName { get; set; }
        public string AccessToken { get; set; }
        public int ExpiresIn { get; set; }
    }
}
