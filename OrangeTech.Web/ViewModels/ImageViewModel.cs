using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeTech.Web.ViewModels
{
    public class ImageViewModel
    {
        public Guid ImageId { get; set; }

        public IFormFile Img { get; set; }
    }
}
