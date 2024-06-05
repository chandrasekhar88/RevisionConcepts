using BookStoreAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace BookStoreAPI.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IConfiguration configuration;

        public AccountRepository(UserManager<ApplicationUser> user, 
            SignInManager<ApplicationUser> signIn, IConfiguration iConfiguration)
        {
            userManager = user;
            signInManager = signIn;
            configuration = iConfiguration;
        }


        public async Task<IdentityResult> SignUpAsync(SignUpModel signUpModel)
        {
            var user = new ApplicationUser()
            {
                firstName = signUpModel.firstName,
                lastName = signUpModel.lastName,
                Email = signUpModel.email,
                UserName = signUpModel.email
            };

            return await userManager.CreateAsync(user, signUpModel.password);
        }

        public async Task<string> LoginAsync(SignInModel signInModel)
        {
            var result = await signInManager.PasswordSignInAsync(signInModel.email, signInModel.password, false, false);

            if (!result.Succeeded)
            {
                return null;
            }

            var authenticationClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, signInModel.email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var authenticationSignInKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: configuration["JWT:ValidIssuer"],
                audience: configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(1),
                claims: authenticationClaims,
                signingCredentials: new SigningCredentials(authenticationSignInKey, SecurityAlgorithms.HmacSha256Signature)
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
