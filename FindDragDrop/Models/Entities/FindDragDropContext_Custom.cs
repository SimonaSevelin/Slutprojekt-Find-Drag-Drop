using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FindDragDrop.Models.Entities
{
    public partial class FindDragDropContext
    {
        public FindDragDropContext(DbContextOptions<FindDragDropContext> c) : base(c)
        {

        }
    }
}
