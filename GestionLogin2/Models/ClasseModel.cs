using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogin2.Models
{
    public class ClasseModel
    {
        public string Nom { get; set; }

        public List<EleveModel> Eleves { get; set; }
    }

    public class ClasseManager
    {
        public static List<ClasseModel> GetClasses()
        {
            var classes = new List<ClasseModel>();

            var classe = new ClasseModel
            {
                Nom = "SNIR 2",
                Eleves = new List<EleveModel>()
            };

            classe.Eleves.Add(new EleveModel
            {
                Nom = "Fake nom 1",
                Prenom = "Fake prénom 1"
            });

            classe.Eleves.Add(new EleveModel
            {
                Nom = "Fake nom 2",
                Prenom = "Fake prénom 2"
            });

            classe.Eleves.Add(new EleveModel
            {
                Nom = "Fake nom 3",
                Prenom = "Fake prénom 3"
            });

            classes.Add(classe);

            classe = new ClasseModel
            {
                Nom = "SNIR 1",
                Eleves = new List<EleveModel>()
            };

            classe.Eleves.Add(new EleveModel
            {
                Nom = "Fake nom 21",
                Prenom = "Fake prénom 21"
            });

            classe.Eleves.Add(new EleveModel
            {
                Nom = "Fake nom 22",
                Prenom = "Fake prénom 22"
            });

            classe.Eleves.Add(new EleveModel
            {
                Nom = "Fake nom 23",
                Prenom = "Fake prénom 23"
            });

            classes.Add(classe);

            classe = new ClasseModel
            {
                Nom = "Photos 1",
                Eleves = new List<EleveModel>()
            };

            classe.Eleves.Add(new EleveModel
            {
                Nom = "Fake nom 31",
                Prenom = "Fake prénom 31"
            });

            classe.Eleves.Add(new EleveModel
            {
                Nom = "Fake nom 32",
                Prenom = "Fake prénom 32"
            });

            classe.Eleves.Add(new EleveModel
            {
                Nom = "Fake nom 33",
                Prenom = "Fake prénom 33"
            });

            classes.Add(classe);

            return classes;
        }
    }
}
