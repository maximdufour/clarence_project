using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Joueur
    {
        public int ID { get; set; }
        public string nom { get; set; }
        public int solde { get; set; }
        public int stat_perte { get; set; }
        public string usager { get; set; }
        public string mdp { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
