using System;
using System.Collections.Generic;

#nullable disable

namespace AutoWay.Models
{
    public partial class TbVhclImg
    {
        public int Id { get; set; }
        public int VhclId { get; set; }
        public string FilePath { get; set; }
    }
}
