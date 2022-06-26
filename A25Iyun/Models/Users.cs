using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace A25Iyun.Models
{
    public class Users
    {
        public int Id { get; set; }
        public int Raiting { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public string  ImageUrl { get; set; }
        public string Name { get; set; }
    }
}
