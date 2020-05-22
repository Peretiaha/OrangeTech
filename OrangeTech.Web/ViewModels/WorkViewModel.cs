using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeTech.Web.ViewModels
{
    public class WorkViewModel
    {
        public Guid WorkId { get; set; }

        [Required]
        [MaxLength(45), MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MaxLength(150), MinLength(30)]
        public string ShortDescription { get; set; }

        [Required]
        [MaxLength(600), MinLength(30)]
        public string FullDescription { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        public List<IFormFile> Images { get; set; }
    }
}
