using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using FoodWeb.API.Database;
using FoodWeb.API.Database.Entities;
using FoodWeb.API.Database.IRepositories;
using FoodWeb.API.DTOs;

namespace FoodWeb.API.Database.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext _context;

        public AccountRepository(DataContext context){
            this._context = context;
        }

        public void CreateAccount(RegisterDTO registerDTO)
        {
            using var hmac = new HMACSHA512();
            var account = new Account(){
                Email = registerDTO.Email,
                Password = registerDTO.Password,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDTO.Password)),
                PasswordSalt = hmac.Key,
                UserId = _context.Users.FirstOrDefault(s => s.NameUser == registerDTO.NameUser).IdUser
            };

            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public IEnumerable<Account> GetAllAccounts(){
            return _context.Accounts;
        }

        public Account GetAccountByEmail(string email){
            return _context.Accounts.FirstOrDefault(s => s.Email == email);
        }
    }
}