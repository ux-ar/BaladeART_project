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
            case 1: //Arche de la d�fense
                titre.text = "L'arche de la D�fense";
                contenue.text = "L�Arche vient d�une id�e de Georges Pompidou, qui voulait cr�er une �uvre sur le grand axe parisien reliant l�arc de triomphe, l�obelisque, les tuileries et le Louvre. " +
            "\nPuis, le pr�sident Val�ry Giscard d�Estaing revient sur cette id�e et d�cide d�organiser un concours pour cr�er l��uvre. " +
            "Mais c'est lorsque Fran�ois Mitterrand devient pr�sident, que le concours avec pour nom 'T�te D�fense' est lanc�. C�est l�architecte danois Johan Otto von Spreckelsen accompagn� de l�ing�nieur fran�ais Erik Reitzel qui gagnent ce concours en 1985 en proposant la grande arche." +
            "\n\nSon inauguration a eu lieu en juillet 1989, pour f�ter les 100 ans de la tour Eiffel et 200 ans de la r�volution fran�aise. Aujourd�hui, la grande Arche abrite des locaux de grandes entreprise et il n�est malheureusement plus possible de la visiter." +
            "\n\nSur le plan architectural, cette �uvre du 20e si�cle, �voquant l'Arc de Triomphe, mesure 112 m�tres de long, 106.9 m�tres de large et atteint une hauteur imposante de 110.9 m�tres. " +
            "\n\nUne anecdote fascinante souligne que le vide � l'int�rieur pourrait accueillir la cath�drale Notre-Dame de Paris. ";
                break;

            case 2: //CNIT
                titre.text = "CNIT";
                contenue.text = "Le Cnit, initialement d�nomm� Centre National des Industries et Techniques, voit le jour en 1958 � La D�fense. Sa cr�ation d�coule de l'insatisfaction suscit�e par le salon des constructeurs de machines-outils organis� en 1951 � Porte de Versailles, " +
                    "incitant le pr�sident du syndicat des constructeurs, Prouteau, � concevoir un vaste centre d'expositions industrielles. Choisi pour son emplacement id�al � Courbevoie, le Cnit n�cessite l'achat de terrains aupr�s de 40 propri�taires distincts. Con�u par les " +
                    "architectes Robert Camelot, Jean de Mailly, et Bernard Zehrfuss, le b�timent est inaugur� en 1958 par le g�n�ral de Gaulle." +
                    "\n\nPendant plus de deux d�cennies, le Cnit accueille d'importantes expositions avant que la construction de la dalle pi�tonni�re du parvis de la D�fense en 1978 ne r�duise sa hauteur et modifie sa structure. Face � des contraintes d'espace et d'obsolescence, " +
                    "les grandes expositions se d�placent au Parc des Expositions � Porte de Versailles. En 1988, une restructuration double l'espace int�rieur � 200 000m�, marquant le changement de nom pour Centre des Nouvelles Industries et Technologies (Cnit). En 2009, une nouvelle " +
                    "restructuration inclut l'exploitation du niveau inf�rieur, une liaison avec la gare, et l'int�gration de bureaux et h�tels." +
                    "\n\nLe b�timent se caract�rise par une vo�te autoportante en b�ton arm� de 22 500m�, remarquable par son �paisseur de seulement 6 cm et une port�e de 218 m�tres, �tablissant ainsi un record mondial. ";
                break;

            case 3: //Tour Initiale
                titre.text = "La Tour Initiale";
                contenue.text = "Initialement d�sign�e PB 31 (Puteaux/Bureaux, 31 niveaux), cette tour est rapidement rebaptis�e Tour Nobel, puis Tour Roussel-Hoechst. En tandem avec la Tour Esso, elle constitue l'une des deux premi�res v�ritables tours de bureaux �rig�es dans le " +
                    "quartier d'affaires. Con�ue par les architectes Jean de Mailly (� qui l'on doit le CNIT, la Tour France et la Tour Ariane) et Jacques Depuss�, accompagn�s de l'ing�nieur Jean Prouv� et de l'architecte Robert Giudici, la tour est dot�e d'une fa�ade en verre unique. " +
                    "La construction de cette tour remarquable ne n�cessite que 13 mois, s'�talant de 1964 � 1966. Pourtant �a consruction est l'�l�ment d�clencheur de la norme I.G.H (Immeuble Grande Hauteur) qui a pour but de r�guler les constructions impactant le paysages urbains." +
                    "\n\nD'une hauteur de 109 m�tres pour 206 m�tres en longueur, offrant ainsi une superficie de 34,000 m�, la Tour Nobel s'inspire de la Lever House avec des angles arrondis emprunt�s � la Tour Johnson � Racine. Pionni�re en France, elle introduit l'utilisation " +
                    "de vitres courbes sur chacune de ses ar�tes, n�cessitant l'importation de ces �l�ments des �tats-Unis. Avec des fa�ades dot�es d'une double paroi et d'une circulation d'air, la tour exp�rimente un traitement thermique avant-gardiste pour l'�poque. Cette conception " +
                    "novatrice, caract�ris�e par un noyau en b�ton et une charpente m�tallique, trouve ses origines dans les �tudes de Jean Prouv� pour un projet � Nancy, et est concr�tis�e dans la r�alisation de la Tour Nobel.";
                break;
              
            case 4: //Tour First
                titre.text = "La Tour First";
                contenue.text = "La Tour Axa, aussi nomm�e CB 31 (Courbevoie/Bureaux 31), se hisse en tant que plus haut gratte-ciel de France et occupe la septi�me place parmi les tours les plus �lev�es de l'Union europ�enne. Construite en 1974 sous le nom de Tour Azur, elle a " +
                    "�t� con�ue par l'architecte Pierre Dufau pour l'Union des Assurances de Paris, construite par Bouygues. Mesurant initialement 159 m�tres de hauteur avec 39 �tages, elle adopte un plan en �toile � trois branches symbolisant la fusion de trois compagnies " +
                    "d'assurances formant l'UAP. Rebaptis�e Tour Axa en 1998 apr�s l'absorption de l'UAP par Axa, elle subit une transformation majeure entre 2007 et 2011 par le cabinet d'architectes am�ricain Kohn Pedersen Fox Associates, atteignant ainsi 231 m�tres avec 52 �tages." +
                    "\n\n� noter que sa position de plus haut gratte-ciel de France pourrait �tre d�tr�n�e par la Tour The Link, en construction et pr�vue pour atteindre 242 m�tres en 2025." +
                    "\n\nElle mesure 231 m de haut et est compos�e de trois ailes dont une a �t� �cr�t�e pour cr�er un d�grad� sur dix niveaux. La moiti� de ses fa�ades est de type double peau, permettant de r�duire les besoins de climatisation de moiti�, ce qui lui a permis de " +
                    "recevoir la certification �NF b�timent tertiaires haute qualit� environnementale� et d�atteindre le niveau tr�s haute performance �nerg�tique (thpe)." +
                    "\n\nFun fact: Pas besoin de regarder une appli m�t�o pour avoir la m�t�o du lendemain, il suffit de regarder de quelle couleur est illumin�e la tour.";
                break;
            case 5: //Tour Majunga
                titre.text = "La Tour Majunga";
                contenue.text = "La Tour Majunga, �rig�e � La D�fense, Paris, est le r�sultat d'un projet ambitieux dans le domaine de l'architecture moderne. Les plans de cette tour ont �t� con�us par l'architecte fran�ais Jean-Paul Viguier, qui a voulu apporter une touche " +
                    "contemporaine et distinctive au paysage urbain de La D�fense. La construction de la Tour Majunga a d�but� en 2011 et s'est achev�e en 2014. Son nom, emprunt� au malgache, �voque le dynamisme d'un port, rappelant ainsi les liens historiques entre la France " +
                    "et Madagascar. Cette tour de 195 m�tres de hauteur et 45 �tages incarne l'innovation architecturale et la fonctionnalit�, tout en contribuant � la renomm�e de La D�fense en tant que quartier d'affaires � la pointe de la modernit�. La Tour Majunga fait partie " +
                    "int�grante de la trilogie de gratte-ciels, aux c�t�s des tours Alicante et Chassagne, formant ainsi un ensemble harmonieux au c�ur du paysage urbain parisien." +
                    "\n\nMajunga est la 1re tour en France � disposer d'une loggia ou d'un balcon offrant un acc�s � l'ext�rieur � chaque �tage. La tour est �galement �quip�e d'ouvrants permettant d'acc�der � l'air libre dans chaque bureau. De plus, les plafonds �lev�s et les " +
                    "fa�ades bioclimatiques adapt�es � l'orientation de la tour permettent de maximiser la p�n�tration de la lumi�re naturelle. Elle est aussi labellis� par diff�rent organismes comme un excellent par la BREEAM et HQE qui sont des organismes qui �valuent le " +
                    "comportement environnemental des b�timents";
                break;
            case 6: //Pouce de C�sar
                titre.text = "Le Pouce de C�sar";
                contenue.text = "Le Pouce de C�sar, une sculpture embl�matique cr��e par l'artiste fran�ais C�sar Baldaccini, s'impose comme une �uvre d'art exceptionnelle au sein du paysage parisien. Inaugur�e en 1965, cette sculpture monumentale a rapidement captiv� l'attention " +
                    "des amateurs d'art et des passants. Situ�e au c�ur du quartier d'affaires de La D�fense, Le Pouce de C�sar devient une repr�sentation saisissante du g�nie cr�atif de l'artiste." +
                    "\n\nCette sculpture audacieuse, mesurant pr�s de 12 m�tres de haut, repr�sente un pouce humain agrandi de mani�re spectaculaire. Cr�� � partir de multiples empreintes de pouces en bronze, ce chef-d'�uvre offre une perspective unique sur la forme et la fonction " +
                    "de cet �l�ment anatomique. C�sar a su donner � cette �uvre une pr�sence imposante tout en conservant une pr�cision anatomique captivante." +
                    "\n\nL'emplacement strat�gique de cette �uvre, au croisement de l'art et de l'architecture moderne, en fait un point focal du quartier de La D�fense. En tant que symbole de la cr�ativit� et de l'expression artistique, Le Pouce de C�sar t�moigne de l'impact de " +
                    "l'art dans l'espace public, invitant les spectateurs � r�fl�chir sur la relation entre l'homme, l'art et l'environnement urbain. � travers ses dimensions imposantes et son design novateur, cette sculpture reste une ic�ne qui continue d'inspirer et d'�merveiller " +
                    "les g�n�rations successives.";
                break;
            case 7: //Le Moretti
                titre.text = "Le Moretti";
                contenue.text = "Aussi �tonnant que cela soit, cette �uvre, une chemin�e d�guis�e sign�e Raymond Moretti, tr�ne au c�ur du quartier d'affaires parisien depuis son inauguration en 1976. Mesurant pr�s de 15 m�tres de haut, cette sculpture m�tamorphos�e dissimule une " +
                    "chemin�e d'a�ration de 32 m�tres. Utilisant ing�nieusement 672 tubes de fibres de verre de diff�rents diam�tres, l'artiste les a peints de 19 couleurs distinctes. R�sultat : un cache-chemin�e imposant de 27.5 tonnes, constitu� de 22 kilom�tres de tubes." +
                    "\n\nChaque colonne, unique, offre une exp�rience visuelle riche. Inspir�e du mouvement et de l'�nergie, l'�uvre �voque l'harmonie entre la rigueur architecturale et la cr�ativit� artistique. Strat�giquement plac�e au centre d'une esplanade, elle devient un " +
                    "point de convergence, un rep�re visuel au sein du quartier d'affaires anim�." +
                    "\n\n La nuit, cette chemin�e d�guis�e s'illumine, projetant sur les immeubles voisins ses diff�rentes couleurs et ajoutant une dimension spectaculaire � l'ensemble. Le Moretti de la D�fense, bien plus qu'une sculpture, est devenu une ic�ne qui incarne " +
                    "la fusion r�ussie de l'art contemporain et de l'architecture moderne. � travers ses formes vibrantes, l'�uvre continue de fasciner et d'inspirer, soulignant l'importance de l'art dans la vie quotidienne de cet espace urbain dynamique.";
                break;
            case 8: //La D�fense de Paris 
                titre.text = "La D�fense de Paris";
                contenue.text = "Au c�ur de l'histoire du quartier de la D�fense r�side une sculpture embl�matique, autrefois tr�nant sur le rond-point central de Courbevoie, qui a donn� son nom � ce quartier dynamique. Initialement �rig�e � cet endroit, la statue a �t� retir�e " +
                    "en 1971 lors de travaux d'am�nagement du quartier. Son importance est telle qu'elle est � l'origine du nom m�me de la D�fense. " +
                    "\n\nCette �uvre remarquable a vu le jour gr�ce � une commande de la ville de Paris lors d'un concours visant � rendre hommage aux soldats et civils qui ont d�fendu la capitale pendant la guerre de 1970. L'artiste choisi pour cette t�che cruciale �tait " +
                    "Louis-Ernest Barrias. Sa cr�ation captivante d�peint une femme v�tue de l'uniforme de la garde nationale, symbolisant la ville de Paris, aux c�t�s d'un jeune homme pla�ant une cartouche dans son fusil pour repr�senter les d�fenseurs de la ville. Une " +
                    "fillette prostr�e et triste compl�te le tableau, symbolisant la population civile ayant �galement souffert des ravages de la guerre. Notablement, la femme et le jeune homme dirigent leur regard vers Buzenval, lieu des derniers combats." +
                    "\n\nR�alis�e en bronze par le fondeur Henri L�on Thi�bault, la statue de 5.5 m�tres de haut et pesant 3.5 tonnes t�moigne de mani�re durable des �v�nements historiques et de la r�silience de la population parisienne durant cette p�riode troubl�e.";                   
                break;
            case 9: //La voiture lampadaire
                titre.text = "La voiture lampadaire";
                contenue.text = "Dans le cadre de l'�dition 2019 des Extatiques, une manifestation d'art contemporain en plein air, l'artiste Benedetto Buffalino a cr�� une �uvre d'art singuli�re � partir d'une Peugeot 406 blanche. Loin d'�tre une simple voiture abandonn�e par un " +
                    "conducteur maladroit, cette cr�ation artistique a �t� con�ue pour c�l�brer les 60 ans du quartier de la D�fense. L'installation �tait initialement pr�vue comme temporaire pour l'exposition, mais en raison de son immense popularit� aupr�s du public, la d�cision" +
                    " a �t� prise de l'int�grer de mani�re permanente dans le paysage du quartier." +
                    "\n\nLe 12 juin 2020, cette voiture artistique a �t� officiellement relog�e, devenant ainsi une pi�ce incontournable du quartier de la D�fense. Ce projet, initi� dans le cadre des Extatiques, vise � transformer l'espace urbain en une galerie d'art � ciel ouvert," +
                    " offrant aux visiteurs une exp�rience esth�tique in�dite." +
                    "\n\nUn d�tail fascinant � noter est que cette �uvre d'art mobile n'est pas simplement une sculpture statique. La Peugeot 406 fonctionne r�ellement comme un lampadaire, ajoutant une dimension fonctionnelle � sa pr�sence artistique. Pendant la nuit, l'int�rieur de " +
                    "la voiture et ses phares s'allument, cr�ant un spectacle lumineux qui contribue � illuminer la ville et � offrir une atmosph�re unique au quartier de la D�fense." +
                    "\n\nAinsi, cette voiture transform�e en �uvre d'art devient bien plus qu'un simple �l�ment visuel ; elle repr�sente une int�gration r�ussie de l'art contemporain dans l'environnement urbain, t�moignant de l'impact positif de l'expression artistique sur la vie " +
                    "quotidienne et le paysage citadin.";
                break;
            case 10: //Fragment du mur de Berlin
                titre.text = "Un Fragment du Mur de Berlin";
                contenue.text = "Apr�s la Seconde Guerre mondiale, l'Allemagne est divis�e en deux entit�s distinctes : la R�publique f�d�rale d'Allemagne (RFA) � l'ouest, influenc�e par le capitalisme et la d�mocratie, et la R�publique d�mocratique allemande (RDA) � l'est," +
                    " sous l'influence du communisme sovi�tique. Cette division s'�tend jusqu'� la capitale, Berlin, qui est �galement partag�e entre Berlin-Ouest, g�r� par la RFA, et Berlin-Est, par la RDA. Dans le but de s�parer les deux r�gimes et d'emp�cher les Berlinois " +
                    "de se rendre � l'ouest, la RDA �rige un mur dans la nuit du 12 au 13 ao�t 1961. Initialement constitu� de barbel�s, il �volue par la suite en un mur de b�ton afin de rendre toute travers�e impossible." +
                    "\n\nCe mur est bien plus qu'une simple barri�re,il devient un dispositif militaire complexe comprenant deux murs de 3,6 m�tres de haut, entourant totalement la partie ouest de la ville sur 155 km. Entre ces deux murs, on trouve 302 miradors, " +
                    "des dispositifs d'alarmes, 14 000 gardes, 600 chiens et des barbel�s surplombant la structure. " +
                    "\n\nCette fronti�re infranchissable dure 28 ans. Le 9 novembre 1989, avec l'affaiblissement de l'Union sovi�tique, les Allemands de l'Est, d�termin�s, organisent d'importantes manifestations et d�truisent une partie du mur pendant la nuit, permettant ainsi " +
                    "la r�unification des deux Allemagnes." +
                    "Face � vous, ce fragment de mur, pr�sentant les graffitis d'�poques du cot� de la RFA, mesure 20 m�tres de long 3.2 m�tres de large et 20 cm d'�paisseur. \n\nIl fait partie des 12 autres fragments du mur de Berlin dipers�s en France, dont un se trouve sur " +
                    "l'esplanade du Neuf-Novembre 1989 � Paris.";
                break;
            default : //Normalement jamais montr� mais au cas ou 
                titre.text = "Monuments";
                contenue.text = "D�finition : \n1. Ouvrage d'architecture, de sculpture, ou inscription destin�s � perp�tuer la m�moire d'un homme ou d'un �v�nement remarquable. " +
                    "\n2. Ouvrage d'architecture remarquable d'un point de vue esth�tique ou historique.";
                break;

        }
      
    }
        
}
