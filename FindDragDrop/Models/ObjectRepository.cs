using FindDragDrop.Models.Entities;
using FindDragDrop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindDragDrop.Models
{
    public class ObjectRepository
    {
        FindDragDropContext context;

        public ObjectRepository(FindDragDropContext context)
        {
            this.context = context;
        }

        
    }
}
