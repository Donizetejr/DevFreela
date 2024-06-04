using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.InputModels
{
    public class NewProjectInputModel : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int IdClient { get; private set; }
        public int IdFreelancer { get; set; }
        public decimal TotalCost { get; set; }
    }
}
