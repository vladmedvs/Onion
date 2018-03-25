using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onion.Data
{
    public class Post:BaseEntity
    {
        public string UserName { get; set; }
        public string UserPost { get; set; }
        public virtual Coments Coments { get; set; }

    }
}
