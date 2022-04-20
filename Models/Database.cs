using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace TP1_Partie2_Tanguay_Zachary.Models
{
    public class Database
    {
        #region Champs
        /// <summary>
        /// Descripton Page d'accueil.
        /// </summary>
        public string DescRois = "La guerre et le conflit sont perméables à chaque instant, à travers le no man's land de Velen dévastée, la chasse aux magiciennes à Novigrad ou encore les problèmes de succession sur Skellige. Des réfugiés campent sur le bord des routes, des charniers parsèment le paysage et des corps pendent aux arbres tandis que des panonceaux égrènent les crimes de désertion ou de pillage dont les châtiés se sont rendus coupables. Dans ce monde, la guerre n'est pas un divertissement, elle se défini comme une période d'ennui et d'attente, ponctués par quelques périodes de folie furieuse.";

        public string DescMages = "La Loge des Magiciennes fut fondée après la révolte de Thanedd pour remplacer le Chapitre et le Conseil des Magiciens.L'objectif de ses fondatrices était de mettre fin à la guerre qui opposait Nilfgaard aux royaumes nordiques et de limiter l'influence des magiciens sur le destin du monde. Cette organisation est encore active aujourd'hui sous la forme d'une association regroupant les magiciennes les plus puissantes des royaumes du nord et du sud.La Loge a une grande influence politique, mais ses activités ne sont pas toutes comprises.";

        public string DescSorceleurs = "Les gens ont besoin des sorceleurs, mais ils les méprisent et ont peur d'eux. Leur altérité, leurs étranges talents, leurs yeux de chats et leurs pouvoirs magiques en font des parias qui sont traités comme tels, parfois même avec haine. Cette haine était manifeste lors de la tristement célèbre attaque de Kaer Morhen, qui entraîna la destruction de la forteresse et de la plupart des sorceleurs. Les survivants sont promis à l'extinction, car ils n'entraînent plus de successeurs.";

        /// <summary>
        /// Description des personnages.
        /// </summary>
        public string DescVesemir = "Il est le seul des anciens sorceleurs qui a survécu à l'assaut de Kaer Morhen, laissé pour mort parmi les cadavres de ses compagnons. Cependant, il n'était qu'un maître d'armes et donc ne possédait pas les connaissances nécessaires pour créer de nouveaux mutagènes pour muter de simples garçons en sorceleurs. Malgré son âge, Vesemir est robuste et vif.";

        public string DescGeralt = "Geralt de Riv est le fils de la magicienne Visenna et semble-t-il d’un guerrier nommé Korin. Peu de temps après sa naissance, Geralt fut amené par sa mère chez les Sorceleurs à la place forte de Kaer Morhen. Geralt survécut à de nombreuses mutations durant l’épreuve de l’herbe, grâce a laquelle il acquis des capacités physiques et mentales presque surhumaines (augmentation des réflexes, de la vitesse, de la force et de l’audition). Du fait de ce succès, comme peu d’élus il fut sélectionné pour d’autres expériences et fut le seul de ce petit groupe avec Eskel à y survivre. Ses cheveux blancs, sans aucune pigmentation, sont un effet secondaire de ces expériences. Après avoir achevé l’entraînement de sorceleur, il chevaucha à travers le monde sur son destrier Ablette (il donna ce nom à tous ses chevaux) pour devenir un tueur à gages de monstres. Bien que Geralt ne croie pas en la destinée, il réclama l’enfant à naître de la princesse Pavetta, fille de la reine Calanthe, et de son mari Duny en récompense de ses services. Lorsqu’il s’avéra que l’enfant était une fille, il ne la prit pas. Cependant le destin fit que Geralt et Ciri, la fille de Duny et Pavetta, croisèrent leurs routes à trois reprises et, après la mort de la reine Calanthe, grand-mère de Ciri, Geralt se décida à la protéger et finalement l’aima comme sa propre fille.";

        public string DescLambert = "Formé par Vesemir, il était connu pour sa langue mordante, et était souvent impoli dans la conversation, en particulier envers Triss Merigold, ne s'adressant à elle que par son nom de famille, ce qui irritait grandement la sorcière. Il n'avait pas beaucoup d'utilité pour la politique, un trait commun à la plupart des sorciers en raison de leur code de neutralité.";

        public string DescRadowid = "Radovid V le Stern (polonais : Radowid V Srogi ) était le roi de Redania de la dynastie Redanian dans le dernier quart du 13ème siècle. Son règne est devenu, avec les chasses aux sorcières , l'un des facteurs déterminants de l'après-guerre qui a suivi la paix de Cintra . Radovid était une figure polarisante : un brillant stratège et un superbe général pour certains, un fou paranoïaque pour d'autres. Il y avait aussi beaucoup de gens qui pensaient que sa politique était dure mais justifiée.";

        public string DescEmyr = "Son règne de Nilfgaard était très agressif, poursuivant souvent des politiques expansionnistes similaires à celles de ses prédécesseurs. Cela a conduit au déclenchement de deux guerres contre les royaumes du Nord , qu'il a toutes deux perdues. Emhyr var Emreis était un dirigeant intelligent et brillant. Il a bien choisi son peuple et a écrasé de nombreux complots contre lui. Il était impitoyable envers les traîtres et avançait vers ses objectifs avec une grande détermination.";

        public string DescEredin = "Eredin Bréacc Glas , également surnommé Épervier par les licornes , était un elfe Aen Elle et le commandant d'une cavalerie elfique connue sous le nom de Wild Hunt . En tant que chef, il était connu de la plupart comme le roi de la chasse sauvage . Eredin était un général de haut rang dans son monde jusqu'à ce qu'il tue le roi et devienne son successeur.";

        public string DescYennefer = "Yennefer de Vengerberg , née à Belleteyn en 1173 , était une sorcière qui vivait à Vengerberg , la capitale d' Aedirn . Elle était le véritable amour de Geralt de Riv et une figure maternelle pour Ciri , qu'elle considérait comme une fille au point qu'elle faisait tout ce qu'elle pouvait pour sauver la fille et la protéger du mal.";

        public string DescTriss = "Triss Merigold de Maribor était une sorcière légendaire de Temerian du 13ème siècle. Appelée Quatorzième de la Colline par ses contemporains parce qu'on pensait à tort qu'elle avait été tuée lors de la Bataille de Sodden Hill , elle est passée dans l'histoire sous le nom de Merigold l'Intrépide . Membre du conseil royal du roi Foltest avec Fercart et Keira Metz , ainsi que membre fondateur de la Loge des Sorcières , elle a été impliquée dans la politique pendant la majeure partie de sa vie.";

        public string DescKeira = "Keira Metz est une magicienne originaire de Carreras. Elle fut l'une des conseillères du roi Foltest de Temeria avant d'être contrainte d’émigrer, le roi ayant chassé toutes les magiciennes de Temeria. Elle est également une membre de la Loge des Magiciennes.";

        public string DescCiri = "Cirilla Fiona Elen Riannon (mieux connue sous le nom de Ciri ), est née en 1252 ou 1253 , et très probablement pendant les vacances de Belleteyn . Elle était la seule princesse de Cintra , la fille de Pavetta et Emhyr var Emreis (qui utilisait le pseudonyme Duny à l'époque) ainsi que la petite-fille de la reine Calanthe .";

        public string DescAvallac = "Crevan Espane aep Caomhan Macha , également connu sous le nom d' Avallac'h , était un elfe et Aen Saevherne qui avait la capacité de voyager entre les mondes de l' Aen Elle et de l' Aen Seidhe .";

        public string DescCerys = "Cerys an Craite , alias Sparrowhawk, était la fille de Crach an Craite et la sœur cadette de Hjalmar . La jeune femme était une insulaire courageuse comme son père et avait hérité de tout son entêtement. Elle était très sûre d'elle et toujours prête à prouver qu'elle pouvait accomplir n'importe quelle tâche aussi bien qu'un homme, ce qui l'a amenée, elle et Hjalmar, à avoir une rivalité constante, mais de bonne humeur. Cependant, contrairement à son frère, elle semblait plus pondérée, choisissant d'enquêter et de réfléchir d'abord avant de sauter aux conclusions.";

        /// <summary>
        /// Autres constantes utiles.
        /// </summary>
        public string ageInconnue = "inconnue!";
        #endregion

        #region Instanciation
        /// <summary>
        /// Instancie la liste des enfants dans la base de donnée
        /// </summary>
        public List<Enfant> Enfants { get; set; }

        /// <summary>
        /// Instancie la liste des parents dans la base de donnée
        /// </summary>
        public List<Parent> Parents { get; set; }
        #endregion Instanciation

        #region Database
        public Database()
        {
            // Créer une nouvelle liste de parents/enfants.
            Enfants = new List<Enfant>();
            Parents = new List<Parent>();

            //Liste des parents.
            Parents.Add(new Parent() { Id = 1, Nom = "Rois", ImageURL = "/images/Radowid_1.png", Description = DescRois});

            Parents.Add(new Parent() { Id = 2, Nom = "Magiciennes", ImageURL = "/images/Yen_1.jpg", Description = DescMages});

            Parents.Add(new Parent() { Id = 3, Nom = "Sorceleurs", ImageURL = "/images/Geralt_1.jpg", Description =  DescSorceleurs});
                
            //Listes des enfants.
            Enfants.Add(new Enfant() { Id = 1, NomComplet = "Vesemir", Nom = "Vesemir", Surnom = "Aucun", IdParent = 3 , ImageURL1 = "/images/Vesemir_1.jpg", ImageURL2 = "/images/Vesemir_2.jpg", ImageURL3 = "/images/Vesemir_3.jpg", Description = DescVesemir, Genre = "Masculin", Abilites = "Superhuman abilities, Swordsmanship, Alchemy, Signs", Race = "Human" });

            Enfants.Add(new Enfant() { Id = 2, NomComplet = "Geralt de Riv", Nom = "Geralt", Surnom = "White Wolf, Gwynbleidd, White One, Butcher of Blaviken", IdParent = 3, ImageURL1 = "/images/Geralt_2.jpg", ImageURL2 = "/images/Geralt_3.jpg", ImageURL3 = "/images/Geralt_4.jpg", Description = DescGeralt, Genre = "Masculin" });

            Enfants.Add(new Enfant() { Id = 3, NomComplet = "", Nom = "Lambert", Surnom = "Aucun" ,IdParent = 3, ImageURL1 = "/images/Lambert_1.jpg", ImageURL2 = "/images/Lambert_2.webp", ImageURL3 = "/images/Lambert_3.jpg", Description = DescLambert, Genre = "Masculin" });

            Enfants.Add(new Enfant() { Id = 4, NomComplet = "", Nom = "Radowid V", Surnom = "King of Redania", IdParent = 1, ImageURL1 = "/images/Radowid_2.jpg", ImageURL2 = "/images/Radowid_3.jpg", ImageURL3 = "/images/Radowid_4.jpg", Description = DescRadowid, Genre = "Masculin" });

            Enfants.Add(new Enfant() { Id = 5, NomComplet = "Emhyr var Emreis, Deithwen Addan yn Carn aep Morvudd", Nom = "Emhyr", Surnom = "Duny, Urcheon of Erlenwald", IdParent = 1, ImageURL1 = "/images/Emphyr_1.webp", ImageURL2 = "/images/Emphyr_2.webp", ImageURL3 = "/images/Emphyr_3.jpg", Description = DescEmyr, Genre = "Masculin" });

            Enfants.Add(new Enfant() { Id = 6, NomComplet = "Eredin Bréacc Glas", Nom = "Eredin", Surnom = "The Wild Hunt", IdParent = 1, ImageURL1 = " /images/Eredin_1.webp", ImageURL2 = "/images/Eredin_2.jpg", ImageURL3 = "/images/Eredin_3.jpg", Description = DescEredin, Genre = "Masculin" });

            Enfants.Add(new Enfant() { Id = 7, NomComplet = "Yennefer de Vengerberg", Nom = "Yennefer", Surnom = "Janka, Jenny, Yenna, Yen, Horsewoman of War", IdParent = 2, ImageURL1 = "/images/Yen_2.webp", ImageURL2 = "/images/Yen_3.jpg", ImageURL3 = "/images/Yen_4.jpg", Description = DescYennefer, Genre = "Féminin" });

            Enfants.Add(new Enfant() { Id = 8, NomComplet = "Triss Merigold", Nom = "Triss", Surnom = "Fourteenth of the Hill, Merigold the Fearless", IdParent = 2, ImageURL1 = " /images/Triss_1.jpg", ImageURL2 = "/images/Triss_2.jpg", ImageURL3 = "/images/Triss_3.jpg", Description = DescTriss, Genre = "Féminin" });

            Enfants.Add(new Enfant() { Id = 9, NomComplet = "Keira Metz", Nom = "Keira", Surnom = "Aucun", IdParent = 2, ImageURL1 = "/images/Keira_1.jpg", ImageURL2 = "/images/Keira_2.jpg", ImageURL3 = "/images/Keira_3.jpg", Description = DescKeira, Genre = "Féminin" });

            Enfants.Add(new Enfant() { Id = 10, NomComplet = "Cirilla Fiona Elen Riannon", Nom = "Ciri", Surnom = "Lion Cub of Cintra, Falka, Zireael, Swallow, Ashen one, Ugly one, Lady of Space and Time, Ciri of Vengerberg", IdParent = 3, ImageURL1 = " /images/Ciri_1.webp", ImageURL2 = "/images/Ciri_2.jpg", ImageURL3 = "/images/Ciri_3.jpg", Description = DescCiri, Genre = "Féminin" });

            Enfants.Add(new Enfant() { Id = 11, NomComplet = "Crevan Espane aep Caomhan Macha", Nom = "Avallac'h", Surnom = "Fox, The Mysterious Elf", IdParent = 2, ImageURL1 = "/images/Avallac_1.jpg", ImageURL2 = "/images/Avallac_2.webp", ImageURL3 = "/images/Avallac_3.jpg", Description = DescAvallac, Genre = "Masculin" });

            Enfants.Add(new Enfant() { Id = 12, NomComplet = "Cerys an Craite", Nom = "Cerys", Surnom = "Sparrowhawk", IdParent = 1, ImageURL1 = "/images/Cerys_1.jpg", ImageURL2 = "/images/Cerys_2.jpg", ImageURL3 = "/images/Cerys_3.jpg", Description = DescCerys, Genre = "Féminin" });

            //Lier les objets enfants aux différents parents.
            foreach (var p in Parents)
            {
                p.Enfants = new List<Enfant>();
                p.Enfants.AddRange(Enfants.Where(e => e.IdParent == p.Id));
            }

            //Lier les objets parents aux différents enfants.
            foreach (var e in Enfants)
            {
                e.Parent = Parents.Where(p => p.Id == e.IdParent).Single();
            }

        }
        #endregion Database
    }
}
