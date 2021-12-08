using DevelopersBlog.Entities.Concrete;
using DevelopersBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopersBlog.Data.Abstract
{
    public interface ICommentRepository : IEntityRepository<Comment>
    {
    }
}
