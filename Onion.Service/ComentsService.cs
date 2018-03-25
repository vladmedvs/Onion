using System;
using System.Collections.Generic;
using System.Text;
using Onion.Data;
using Onion.Repository;

namespace Onion.Service
{
    public class ComentsService : IComentsService
    {
        private IRepository<Coments> ComentsRepository;
        public ComentsService(IRepository<Coments> ComentsRepository)
        {
            this.ComentsRepository = ComentsRepository;
        }
        public Coments GetComents(long id)
        {
            return ComentsRepository.Get(id);
        }

    }
}
