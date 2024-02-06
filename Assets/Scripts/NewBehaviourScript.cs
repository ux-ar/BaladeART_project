using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NewBehaviourScript : MonoBehaviour
{
    
    public int choix;
    public TextMeshProUGUI titre;
    public TextMeshProUGUI contenue;
    // Start is called before the first frame update
    void Start()
    {
        switch (choix)
        {
            case 1: //Arche de la défense
                titre.text = "L'arche de la Défense";
                contenue.text = "L’Arche vient d’une idée de Georges Pompidou, qui voulait créer une œuvre sur le grand axe parisien reliant l’arc de triomphe, l’obelisque, les tuileries et le Louvre. " +
            "\nPuis, le président Valéry Giscard d’Estaing revient sur cette idée et décide d’organiser un concours pour créer l’œuvre. " +
            "Mais c'est lorsque François Mitterrand devient président, que le concours avec pour nom 'Tête Défense' est lancé. C’est l’architecte danois Johan Otto von Spreckelsen accompagné de l’ingénieur français Erik Reitzel qui gagnent ce concours en 1985 en proposant la grande arche." +
            "\n\nSon inauguration a eu lieu en juillet 1989, pour fêter les 100 ans de la tour Eiffel et 200 ans de la révolution française. Aujourd’hui, la grande Arche abrite des locaux de grandes entreprise et il n’est malheureusement plus possible de la visiter." +
            "\n\nSur le plan architectural, cette œuvre du 20e siècle, évoquant l'Arc de Triomphe, mesure 112 mètres de long, 106.9 mètres de large et atteint une hauteur imposante de 110.9 mètres. " +
            "\n\nUne anecdote fascinante souligne que le vide à l'intérieur pourrait accueillir la cathédrale Notre-Dame de Paris. ";
                break;

            case 2: //CNIT
                titre.text = "CNIT";
                contenue.text = "Le Cnit, initialement dénommé Centre National des Industries et Techniques, voit le jour en 1958 à La Défense. Sa création découle de l'insatisfaction suscitée par le salon des constructeurs de machines-outils organisé en 1951 à Porte de Versailles, " +
                    "incitant le président du syndicat des constructeurs, Prouteau, à concevoir un vaste centre d'expositions industrielles. Choisi pour son emplacement idéal à Courbevoie, le Cnit nécessite l'achat de terrains auprès de 40 propriétaires distincts. Conçu par les " +
                    "architectes Robert Camelot, Jean de Mailly, et Bernard Zehrfuss, le bâtiment est inauguré en 1958 par le général de Gaulle." +
                    "\n\nPendant plus de deux décennies, le Cnit accueille d'importantes expositions avant que la construction de la dalle piétonnière du parvis de la Défense en 1978 ne réduise sa hauteur et modifie sa structure. Face à des contraintes d'espace et d'obsolescence, " +
                    "les grandes expositions se déplacent au Parc des Expositions à Porte de Versailles. En 1988, une restructuration double l'espace intérieur à 200 000m², marquant le changement de nom pour Centre des Nouvelles Industries et Technologies (Cnit). En 2009, une nouvelle " +
                    "restructuration inclut l'exploitation du niveau inférieur, une liaison avec la gare, et l'intégration de bureaux et hôtels." +
                    "\n\nLe bâtiment se caractérise par une voûte autoportante en béton armé de 22 500m², remarquable par son épaisseur de seulement 6 cm et une portée de 218 mètres, établissant ainsi un record mondial. ";
                break;

            case 3: //Tour Initiale
                titre.text = "La Tour Initiale";
                contenue.text = "Initialement désignée PB 31 (Puteaux/Bureaux, 31 niveaux), cette tour est rapidement rebaptisée Tour Nobel, puis Tour Roussel-Hoechst. En tandem avec la Tour Esso, elle constitue l'une des deux premières véritables tours de bureaux érigées dans le " +
                    "quartier d'affaires. Conçue par les architectes Jean de Mailly (à qui l'on doit le CNIT, la Tour France et la Tour Ariane) et Jacques Depussé, accompagnés de l'ingénieur Jean Prouvé et de l'architecte Robert Giudici, la tour est dotée d'une façade en verre unique. " +
                    "La construction de cette tour remarquable ne nécessite que 13 mois, s'étalant de 1964 à 1966. Pourtant ça consruction est l'élément déclencheur de la norme I.G.H (Immeuble Grande Hauteur) qui a pour but de réguler les constructions impactant le paysages urbains." +
                    "\n\nD'une hauteur de 109 mètres pour 206 mètres en longueur, offrant ainsi une superficie de 34,000 m², la Tour Nobel s'inspire de la Lever House avec des angles arrondis empruntés à la Tour Johnson à Racine. Pionnière en France, elle introduit l'utilisation " +
                    "de vitres courbes sur chacune de ses arêtes, nécessitant l'importation de ces éléments des États-Unis. Avec des façades dotées d'une double paroi et d'une circulation d'air, la tour expérimente un traitement thermique avant-gardiste pour l'époque. Cette conception " +
                    "novatrice, caractérisée par un noyau en béton et une charpente métallique, trouve ses origines dans les études de Jean Prouvé pour un projet à Nancy, et est concrétisée dans la réalisation de la Tour Nobel.";
                break;
              
            case 4: //Tour First
                titre.text = "La Tour First";
                contenue.text = "La Tour Axa, aussi nommée CB 31 (Courbevoie/Bureaux 31), se hisse en tant que plus haut gratte-ciel de France et occupe la septième place parmi les tours les plus élevées de l'Union européenne. Construite en 1974 sous le nom de Tour Azur, elle a " +
                    "été conçue par l'architecte Pierre Dufau pour l'Union des Assurances de Paris, construite par Bouygues. Mesurant initialement 159 mètres de hauteur avec 39 étages, elle adopte un plan en étoile à trois branches symbolisant la fusion de trois compagnies " +
                    "d'assurances formant l'UAP. Rebaptisée Tour Axa en 1998 après l'absorption de l'UAP par Axa, elle subit une transformation majeure entre 2007 et 2011 par le cabinet d'architectes américain Kohn Pedersen Fox Associates, atteignant ainsi 231 mètres avec 52 étages." +
                    "\n\nÀ noter que sa position de plus haut gratte-ciel de France pourrait être détrônée par la Tour The Link, en construction et prévue pour atteindre 242 mètres en 2025." +
                    "\n\nElle mesure 231 m de haut et est composée de trois ailes dont une a été écrêtée pour créer un dégradé sur dix niveaux. La moitié de ses façades est de type double peau, permettant de réduire les besoins de climatisation de moitié, ce qui lui a permis de " +
                    "recevoir la certification “NF bâtiment tertiaires haute qualité environnementale” et d’atteindre le niveau très haute performance énergétique (thpe)." +
                    "\n\nFun fact: Pas besoin de regarder une appli météo pour avoir la météo du lendemain, il suffit de regarder de quelle couleur est illuminée la tour.";
                break;
            case 5: //Tour Majunga
                titre.text = "La Tour Majunga";
                contenue.text = "La Tour Majunga, érigée à La Défense, Paris, est le résultat d'un projet ambitieux dans le domaine de l'architecture moderne. Les plans de cette tour ont été conçus par l'architecte français Jean-Paul Viguier, qui a voulu apporter une touche " +
                    "contemporaine et distinctive au paysage urbain de La Défense. La construction de la Tour Majunga a débuté en 2011 et s'est achevée en 2014. Son nom, emprunté au malgache, évoque le dynamisme d'un port, rappelant ainsi les liens historiques entre la France " +
                    "et Madagascar. Cette tour de 195 mètres de hauteur et 45 étages incarne l'innovation architecturale et la fonctionnalité, tout en contribuant à la renommée de La Défense en tant que quartier d'affaires à la pointe de la modernité. La Tour Majunga fait partie " +
                    "intégrante de la trilogie de gratte-ciels, aux côtés des tours Alicante et Chassagne, formant ainsi un ensemble harmonieux au cœur du paysage urbain parisien." +
                    "\n\nMajunga est la 1re tour en France à disposer d'une loggia ou d'un balcon offrant un accès à l'extérieur à chaque étage. La tour est également équipée d'ouvrants permettant d'accéder à l'air libre dans chaque bureau. De plus, les plafonds élevés et les " +
                    "façades bioclimatiques adaptées à l'orientation de la tour permettent de maximiser la pénétration de la lumière naturelle. Elle est aussi labellisé par différent organismes comme un excellent par la BREEAM et HQE qui sont des organismes qui évaluent le " +
                    "comportement environnemental des bâtiments";
                break;
            case 6: //Pouce de César
                titre.text = "Le Pouce de César";
                contenue.text = "Le Pouce de César, une sculpture emblématique créée par l'artiste français César Baldaccini, s'impose comme une œuvre d'art exceptionnelle au sein du paysage parisien. Inaugurée en 1965, cette sculpture monumentale a rapidement captivé l'attention " +
                    "des amateurs d'art et des passants. Située au cœur du quartier d'affaires de La Défense, Le Pouce de César devient une représentation saisissante du génie créatif de l'artiste." +
                    "\n\nCette sculpture audacieuse, mesurant près de 12 mètres de haut, représente un pouce humain agrandi de manière spectaculaire. Créé à partir de multiples empreintes de pouces en bronze, ce chef-d'œuvre offre une perspective unique sur la forme et la fonction " +
                    "de cet élément anatomique. César a su donner à cette œuvre une présence imposante tout en conservant une précision anatomique captivante." +
                    "\n\nL'emplacement stratégique de cette œuvre, au croisement de l'art et de l'architecture moderne, en fait un point focal du quartier de La Défense. En tant que symbole de la créativité et de l'expression artistique, Le Pouce de César témoigne de l'impact de " +
                    "l'art dans l'espace public, invitant les spectateurs à réfléchir sur la relation entre l'homme, l'art et l'environnement urbain. À travers ses dimensions imposantes et son design novateur, cette sculpture reste une icône qui continue d'inspirer et d'émerveiller " +
                    "les générations successives.";
                break;
            case 7: //Le Moretti
                titre.text = "Le Moretti";
                contenue.text = "Aussi étonnant que cela soit, cette œuvre, une cheminée déguisée signée Raymond Moretti, trône au cœur du quartier d'affaires parisien depuis son inauguration en 1976. Mesurant près de 15 mètres de haut, cette sculpture métamorphosée dissimule une " +
                    "cheminée d'aération de 32 mètres. Utilisant ingénieusement 672 tubes de fibres de verre de différents diamètres, l'artiste les a peints de 19 couleurs distinctes. Résultat : un cache-cheminée imposant de 27.5 tonnes, constitué de 22 kilomètres de tubes." +
                    "\n\nChaque colonne, unique, offre une expérience visuelle riche. Inspirée du mouvement et de l'énergie, l'œuvre évoque l'harmonie entre la rigueur architecturale et la créativité artistique. Stratégiquement placée au centre d'une esplanade, elle devient un " +
                    "point de convergence, un repère visuel au sein du quartier d'affaires animé." +
                    "\n\n La nuit, cette cheminée déguisée s'illumine, projetant sur les immeubles voisins ses différentes couleurs et ajoutant une dimension spectaculaire à l'ensemble. Le Moretti de la Défense, bien plus qu'une sculpture, est devenu une icône qui incarne " +
                    "la fusion réussie de l'art contemporain et de l'architecture moderne. À travers ses formes vibrantes, l'œuvre continue de fasciner et d'inspirer, soulignant l'importance de l'art dans la vie quotidienne de cet espace urbain dynamique.";
                break;
            case 8: //La Défense de Paris 
                titre.text = "La Défense de Paris";
                contenue.text = "Au cœur de l'histoire du quartier de la Défense réside une sculpture emblématique, autrefois trônant sur le rond-point central de Courbevoie, qui a donné son nom à ce quartier dynamique. Initialement érigée à cet endroit, la statue a été retirée " +
                    "en 1971 lors de travaux d'aménagement du quartier. Son importance est telle qu'elle est à l'origine du nom même de la Défense. " +
                    "\n\nCette œuvre remarquable a vu le jour grâce à une commande de la ville de Paris lors d'un concours visant à rendre hommage aux soldats et civils qui ont défendu la capitale pendant la guerre de 1970. L'artiste choisi pour cette tâche cruciale était " +
                    "Louis-Ernest Barrias. Sa création captivante dépeint une femme vêtue de l'uniforme de la garde nationale, symbolisant la ville de Paris, aux côtés d'un jeune homme plaçant une cartouche dans son fusil pour représenter les défenseurs de la ville. Une " +
                    "fillette prostrée et triste complète le tableau, symbolisant la population civile ayant également souffert des ravages de la guerre. Notablement, la femme et le jeune homme dirigent leur regard vers Buzenval, lieu des derniers combats." +
                    "\n\nRéalisée en bronze par le fondeur Henri Léon Thiébault, la statue de 5.5 mètres de haut et pesant 3.5 tonnes témoigne de manière durable des événements historiques et de la résilience de la population parisienne durant cette période troublée.";                   
                break;
            case 9: //La voiture lampadaire
                titre.text = "La voiture lampadaire";
                contenue.text = "Dans le cadre de l'édition 2019 des Extatiques, une manifestation d'art contemporain en plein air, l'artiste Benedetto Buffalino a créé une œuvre d'art singulière à partir d'une Peugeot 406 blanche. Loin d'être une simple voiture abandonnée par un " +
                    "conducteur maladroit, cette création artistique a été conçue pour célébrer les 60 ans du quartier de la Défense. L'installation était initialement prévue comme temporaire pour l'exposition, mais en raison de son immense popularité auprès du public, la décision" +
                    " a été prise de l'intégrer de manière permanente dans le paysage du quartier." +
                    "\n\nLe 12 juin 2020, cette voiture artistique a été officiellement relogée, devenant ainsi une pièce incontournable du quartier de la Défense. Ce projet, initié dans le cadre des Extatiques, vise à transformer l'espace urbain en une galerie d'art à ciel ouvert," +
                    " offrant aux visiteurs une expérience esthétique inédite." +
                    "\n\nUn détail fascinant à noter est que cette œuvre d'art mobile n'est pas simplement une sculpture statique. La Peugeot 406 fonctionne réellement comme un lampadaire, ajoutant une dimension fonctionnelle à sa présence artistique. Pendant la nuit, l'intérieur de " +
                    "la voiture et ses phares s'allument, créant un spectacle lumineux qui contribue à illuminer la ville et à offrir une atmosphère unique au quartier de la Défense." +
                    "\n\nAinsi, cette voiture transformée en œuvre d'art devient bien plus qu'un simple élément visuel ; elle représente une intégration réussie de l'art contemporain dans l'environnement urbain, témoignant de l'impact positif de l'expression artistique sur la vie " +
                    "quotidienne et le paysage citadin.";
                break;
            case 10: //Fragment du mur de Berlin
                titre.text = "Un Fragment du Mur de Berlin";
                contenue.text = "Après la Seconde Guerre mondiale, l'Allemagne est divisée en deux entités distinctes : la République fédérale d'Allemagne (RFA) à l'ouest, influencée par le capitalisme et la démocratie, et la République démocratique allemande (RDA) à l'est," +
                    " sous l'influence du communisme soviétique. Cette division s'étend jusqu'à la capitale, Berlin, qui est également partagée entre Berlin-Ouest, géré par la RFA, et Berlin-Est, par la RDA. Dans le but de séparer les deux régimes et d'empêcher les Berlinois " +
                    "de se rendre à l'ouest, la RDA érige un mur dans la nuit du 12 au 13 août 1961. Initialement constitué de barbelés, il évolue par la suite en un mur de béton afin de rendre toute traversée impossible." +
                    "\n\nCe mur est bien plus qu'une simple barrière,il devient un dispositif militaire complexe comprenant deux murs de 3,6 mètres de haut, entourant totalement la partie ouest de la ville sur 155 km. Entre ces deux murs, on trouve 302 miradors, " +
                    "des dispositifs d'alarmes, 14 000 gardes, 600 chiens et des barbelés surplombant la structure. " +
                    "\n\nCette frontière infranchissable dure 28 ans. Le 9 novembre 1989, avec l'affaiblissement de l'Union soviétique, les Allemands de l'Est, déterminés, organisent d'importantes manifestations et détruisent une partie du mur pendant la nuit, permettant ainsi " +
                    "la réunification des deux Allemagnes." +
                    "Face à vous, ce fragment de mur, présentant les graffitis d'époques du coté de la RFA, mesure 20 mètres de long 3.2 mètres de large et 20 cm d'épaisseur. \n\nIl fait partie des 12 autres fragments du mur de Berlin dipersés en France, dont un se trouve sur " +
                    "l'esplanade du Neuf-Novembre 1989 à Paris.";
                break;
            default : //Normalement jamais montré mais au cas ou 
                titre.text = "Monuments";
                contenue.text = "Définition : \n1. Ouvrage d'architecture, de sculpture, ou inscription destinés à perpétuer la mémoire d'un homme ou d'un événement remarquable. " +
                    "\n2. Ouvrage d'architecture remarquable d'un point de vue esthétique ou historique.";
                break;

        }
      
    }
        
}
