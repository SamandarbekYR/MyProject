using MyProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DataAccess.Interfaces
{
    public interface IRepository<TEntiy> where TEntiy: BaseEntity
    {
        TEntiy GetById(Guid id);
        void Add (TEntiy tentiy);
    }
}
