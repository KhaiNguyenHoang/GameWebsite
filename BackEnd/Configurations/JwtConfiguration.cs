using Microsoft.Extensions.Configuration;
using System.Text;

namespace BackEnd.Configurations
{
    public class JwtConfiguration
    {
        public string Key { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public int DurationInMinutes { get; set; }

        public static JwtConfiguration GetConfiguration(IConfiguration configuration)
        {
            var jwtSettings = configuration.GetSection("Jwt");
            var jwtConfig = new JwtConfiguration
            {
                Key = jwtSettings.GetValue<string>("Key") ?? string.Empty,
                Issuer = jwtSettings.GetValue<string>("Issuer") ?? string.Empty,
                Audience = jwtSettings.GetValue<string>("Audience") ?? string.Empty,
                DurationInMinutes = jwtSettings.GetValue<int>("DurationInMinutes")
            };

            return jwtConfig;
        }

        public string GetSymmetricSecurityKey()
        {
            var key = Encoding.UTF8.GetBytes(Key);
            return Convert.ToBase64String(key);
        }
    }
}

