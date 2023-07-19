using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication59
{
    public class CreateActorDTO
    {
        public string Name { get; set; } = null!;
        public IFormFile? Picture { get; set; }
    }
}
