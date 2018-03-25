using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Data
{
    public class Coments:BaseEntity
    {
        public string User { get; set; }
        public string Text { get; set; }
        public virtual Post Post { get; set; }
    }
}
