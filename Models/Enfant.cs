using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP2_Tanguay_Zachary.Models
{
    public class Enfant
    {
        #region Propriétés
        /// <summary>
        /// Retourne l'Id de l'enfant courant
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Retourne l'Id du parents de l'enfant courant
        /// </summary>
        public int IdParent { get; set; }

        /// <summary>
        /// Retourne le type du parents de l'enfant courant
        /// </summary>
        public Parent Parent { get; set; }

        /// <summary>
        /// Retourne l'url de l'image 1 de l'enfant courant
        /// </summary>
        public string ImageURL1 { get; set; }

        /// <summary>
        /// Retourne l'url de l'image 2 de l'enfant courant
        /// </summary>
        public string ImageURL2 { get; set; }

        /// <summary>
        /// Retourne l'url de l'image 3 de l'enfant courant
        /// </summary>
        public string ImageURL3 { get; set; }

        /// <summary>
        /// Retourne le nom complet de l'enfant courant
        /// </summary>
        public string NomComplet { get; set; }

        /// <summary>
        /// Retourne le nom de l'enfant courant
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Retourne le nom abrégé (surnom...) de l'enfant courant
        /// </summary>
        public string Surnom { get; set; }

        /// <summary>
        /// Retourne l'âge de l'enfant courant
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Retourne le sexe de l'enfant courant
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Retourne le race de l'enfant courant
        /// </summary>
        public string Race { get; set; }

        /// <summary>
        /// Retourne si oui ou non l'enfant courant est un personnage vedette
        /// </summary>
        public bool Vedette { get; set; }

        /// <summary>
        /// Retourne la description de l'enfant courant
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Retourne le role de l'enfant
        /// </summary>
        public string Role { get; set; }
        #endregion
    }
}
