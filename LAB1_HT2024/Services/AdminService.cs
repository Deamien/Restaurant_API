using LAB1_HT2024.Data.Repository.IRepository;
using LAB1_HT2024.Services.IServices;
using LAB1_HT2024.Models.DTOs.AdminDTO;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using LAB1_HT2024.Models;
using System.Text;
using Azure.Core;

namespace LAB1_HT2024.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IConfiguration _config;

        public AdminService(IAdminRepository adminRepository, IConfiguration config)
        {
            _adminRepository = adminRepository;
            _config = config;

        }

        public async Task<AdminLoginResponse> Authenticate(AdminDTO adminDTO)
        {
            var isValid = await _adminRepository.ValidateAdminCredentials(adminDTO.username, adminDTO.password);


            if (!isValid)
                return null;

            return new AdminLoginResponse
            {
                UserName = adminDTO.username,
                AccessToken = GenerateToken(adminDTO.username),
                ExpiresIn = int.Parse(_config["JwtConfig:TokenValidityMins"])
            };
        }

        public async Task RegisterAdmin(AdminDTO adminDTO)
        {

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(adminDTO.password);

            await _adminRepository.RegisterAdmin(adminDTO.username, passwordHash);
        }

        public string GenerateToken(string username)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_config["JwtConfig:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, "Admin")
            }),
                Expires = DateTime.UtcNow.AddMinutes(int.Parse(_config["JwtConfig:TokenValidityMins"])),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = _config["JwtConfig:Issuer"],
                Audience = _config["JwtConfig:Audience"]
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}   


