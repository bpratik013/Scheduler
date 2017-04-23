using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scheduler.Model
{
    //It will hold the base interface for our entities
    public interface IEntityBase
    {
        int Id { get; set; }
    }
}
