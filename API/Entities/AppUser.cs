// using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class AppUser
    {
        //use this if u don t use Id 
        // [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}