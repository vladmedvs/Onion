using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onion.Data
{
    public class BaseEntity
    {
        public Int32 Id { get; set; }
        public DateTime AddData { get; set; }
        public DateTime ModData { get; set; }
        public string IPAddress { get; set; }

    }
}
