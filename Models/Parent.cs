using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP1_Partie2_Tanguay_Zachary.Models
{
    public class Parent
    {
        #region Propriétés
        /// <summary>
        /// Retourne l'Id du parent courant
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Retourne la description du parent courant
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Retourne la liste de tous les enfants
        /// </summary>
        public List<Enfant> Enfants { get; set; }

        /// <summary>
        /// Retourne l'image du parent courant
        /// </summary>
        public string ImageURL { get; set; }

        /// <summary>
        /// Retourne le nom du parent courant
        /// </summary>
        public string Nom { get; set; }
        #endregion
    }
}
