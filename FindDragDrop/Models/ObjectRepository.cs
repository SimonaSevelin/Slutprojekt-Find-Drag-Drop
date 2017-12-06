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

        //List<ObjectVM> ObjectList = new List<ObjectVM>();

        public IndexVM GetAllObjects()
        {
            return new IndexVM
            {
                ObjectList = context.Object
                .Select(w => new ObjectVM
                {
                    Image = w.Image,
                    Word = w.Word
                })
                .ToArray()
            };
        }

      

    }
}
