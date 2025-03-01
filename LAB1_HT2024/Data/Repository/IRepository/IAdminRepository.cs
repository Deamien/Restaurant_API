namespace LAB1_HT2024.Data.Repository.IRepository
{
    public interface IAdminRepository
    {
        Task<bool> ValidateAdminCredentials(string username, string password);

        Task RegisterAdmin(string username, string passwordHash);
    }
}
