using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Onion.Web.Code;

namespace Onion.Web.Models
{
    public class BootstrapModel
    {
        public string ID { get; set; }
        public string AreaLabeledId { get; set; }
        public ModelSize Size { get; set; }
        public string Message { get; set; }
        public string ModalSizeClass
        {
            get
            {
                switch (this.Size)
                {
                    case ModelSize.Small:
                        return "modal-sm";
                    case ModelSize.Large:
                        return "modal-lg";
                    case ModelSize.Medium:
                    default:
                        return "";
                }
            }
        }
    }
}
