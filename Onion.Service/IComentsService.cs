using System;
using System.Collections.Generic;
using System.Text;
using Onion.Data;


namespace Onion.Service
{
   public interface IComentsService
    {
        Coments GetComents(long id);
    }
}
