using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTech.Models.Models
{
    public class Service
    {
        public Guid ServiceId { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public List<Image> Images { get; set; }
    }
}
