using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Training training = new Training();
            Trainer trainer = new Trainer();
            training.theTrainer = trainer;

            Organisation org = new Organisation();
            org.Name = "Partian Technologies";

            trainer.TheOrganisation = org;
            Console.WriteLine(training.GetOrganisationName());

            //Training[] trainings = new Training[5];
            //Trainee[] trainee = new Trainee[4] {new Trainee(){ TheTrainer = new Trainer(){ TheOrganisation = new Organisation(){ Name = "Partian Techonolgy"} }, Trainings = new List<Training>() },
            //                                    new Trainee(){ TheTrainer = new Trainer(){ TheOrganisation = new Organisation(){ Name = "Eurofins"} }, Trainings = new List<Training>() },
            //                                    new Trainee(){ TheTrainer = new Trainer(){ TheOrganisation = new Organisation(){ Name = "Amazon"} }, Trainings = new List<Training>() },
            //                                    new Trainee(){ TheTrainer = new Trainer(){ TheOrganisation = new Organisation(){ Name = "Google"} }, Trainings = new List<Training>() }};


            for(int i=0;i<3;i++)
            {
                training.Trainees.Add(new Trainee());
            }

            Console.WriteLine(training.GetNumberOfTrinees());

            Unit unit1 = new Unit();
            unit1.DurationHrs = 10;

            Unit unit2 = new Unit();
            unit2.DurationHrs = 20;

            Module module1 = new Module();
            module1.Units.Add(unit1);
            module1.Units.Add(unit2);

            Course course = new Course();
            training.TheCourse = course;
            //course.Modules.Add(module1);
            training.TheCourse.Modules.Add(module1);
           
            Console.WriteLine(training.GetTrainingDurationHrs());
        }
    }
}
