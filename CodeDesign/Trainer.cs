using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesign
{
    public class Trainer
    {
        public Organisation TheOrganisation { get; set; }
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();

        public List<Training> Trainings { get; set; } = new List<Training>();
    }
}
