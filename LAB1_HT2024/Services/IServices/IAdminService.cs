using LAB1_HT2024.Models.DTOs.AdminDTO;
using LAB1_HT2024.Models;

namespace LAB1_HT2024.Services.IServices
{
    public interface IAdminService
    {
        Task<AdminLoginResponse> Authenticate(AdminDTO adminDTO);

        Task RegisterAdmin(AdminDTO adminDTO);
    }
}
