using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesign
{
    public class Training
    {
        public Trainer theTrainer { get; set; }

        public List<Trainee> Trainees { get; set; } = new List<Trainee>();

        public Course TheCourse { get; set; }

        public int GetNumberOfTrinees() 
        {
            return Trainees.Count;
        }
        public string GetOrganisationName() 
        {
            return theTrainer.TheOrganisation.Name;
        }
        public int GetTrainingDurationHrs() 
        {
            int total = 0;

            // iterate  modules
            foreach(var mod in TheCourse.Modules)
            {
                // iterate units
                foreach(var un in mod.Units)
                {
                    total += un.DurationHrs;
                }
            }
            return total;
        }
    }
}
