using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesign
{
    public class Trainee
    {
        public Trainer TheTrainer { get; set; }

        public List<Training> Trainings { get; set; } = new List<Training>();
    }
}
