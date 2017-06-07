using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GestionLogin2.Models
{
    public class Salle
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class SalleManager
    {
        public static List<Salle> GetSalles()
        {
            var salles = new List<Salle>();





            salles.Add(new Salle() { Id = 1, Name = "B01" });
            salles.Add(new Salle() { Id = 2, Name = "B02" });
            salles.Add(new Salle() { Id = 3, Name = "B03" });
            salles.Add(new Salle() { Id = 4, Name = "B04" });
            salles.Add(new Salle() { Id = 5, Name = "B05" });
            salles.Add(new Salle() { Id = 6, Name = "B06" });
            salles.Add(new Salle() { Id = 7, Name = "B07" });
            salles.Add(new Salle() { Id = 8, Name = "B08" });
            salles.Add(new Salle() { Id = 9, Name = "B09" });
            salles.Add(new Salle() { Id = 10, Name = "B10" });
            salles.Add(new Salle() { Id = 11, Name = "B11" });
            salles.Add(new Salle() { Id = 12, Name = "B12" });
            salles.Add(new Salle() { Id = 13, Name = "B13" });
            salles.Add(new Salle() { Id = 14, Name = "B14" });
            salles.Add(new Salle() { Id = 15, Name = "B15" });
            salles.Add(new Salle() { Id = 16, Name = "B16" });
            salles.Add(new Salle() { Id = 17, Name = "B17" });
            salles.Add(new Salle() { Id = 18, Name = "B18" });
            salles.Add(new Salle() { Id = 19, Name = "B19" });
            salles.Add(new Salle() { Id = 20, Name = "B20" });
            salles.Add(new Salle() { Id = 21, Name = "B21" });
            salles.Add(new Salle() { Id = 22, Name = "B22" });
            salles.Add(new Salle() { Id = 23, Name = "B23" });
            salles.Add(new Salle() { Id = 24, Name = "B24" });
            salles.Add(new Salle() { Id = 25, Name = "B25" });
            salles.Add(new Salle() { Id = 26, Name = "B26" });
            salles.Add(new Salle() { Id = 27, Name = "B27" });
            salles.Add(new Salle() { Id = 28, Name = "B28" });
            salles.Add(new Salle() { Id = 29, Name = "B29" });
            salles.Add(new Salle() { Id = 30, Name = "B30" });
            salles.Add(new Salle() { Id = 31, Name = "B31" });


            return salles;

        }
    }
}
