using Core.Entities;
using Data.Contexts;
using Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Concrete
{
    public class GroupRepository : IGroupRepository
    {
        static int id;
        public List<Group> GetAll()
        {
            return DbContext.Groups;
        }
        public Group Get(int id)
        {
            return DbContext.Groups.FirstOrDefault(g => g.ID == id);
        }

        public void Add(Group group)
        {
            id++;
            group.ID = id;
            DbContext.Groups.Add(group);

        }

        public void Update(Group group)
        {
            throw new NotImplementedException();
        }
        public void Delete(Group group)
        {
            DbContext.Groups.Remove(group);
        }

    }
}
