using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTech.Models.Models
{
    public class Image
    {
        public Guid ImageId { get; set; }

        public byte[] Img { get; set; }

        public Work Work { get; set; }

        public Guid? WorkId { get; set; }

        public Service Service { get; set; }

        public Guid? ServiceId { get; set; }

    }
}
