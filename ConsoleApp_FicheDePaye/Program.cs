namespace FicheDePaye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est le nom de votre entreprise?");
            string entreprise = Console.ReadLine();

            Console.WriteLine("Quel est votre nom?");
            string nom = Console.ReadLine();

            Console.WriteLine("Quel est votre prénom?");
            string prenom = Console.ReadLine();

            Console.WriteLine("Quel est le mois de votre fiche de paye?");
            string mois = Console.ReadLine();

            Console.WriteLine("Quel est l'année de votre fiche de paye?");
            int annee = int.Parse(Console.ReadLine());

            Console.WriteLine("Combien d'heures avez-vous travaillé ce mois-ci?");
            double heuresTravaillees = double.Parse(Console.ReadLine());

            Console.WriteLine("Quel est votre taux horaire?");
            decimal tauxHoraire = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Quel est votre salaire brut?");
            decimal salaireBrut = decimal.Parse(Console.ReadLine());

            decimal complementSante = 20.00m;
            decimal vieillesse = salaireBrut * (7.3m / 100m);
            decimal retraiteComplement = salaireBrut * (3.15m / 100m);
            decimal contribEquilibreGene = salaireBrut * (0.86m / 100m);
            decimal CSGdedu = salaireBrut * (6.8m / 100m);
            decimal CSGnonDedu = salaireBrut * (2.4m / 100m);
            decimal CRDS = salaireBrut * (0.5m / 100m);
            decimal totalCotisSalar = complementSante + vieillesse + retraiteComplement + contribEquilibreGene + CSGdedu + CSGnonDedu + CRDS;

            decimal patronSante = 20.00m;
            decimal maladie = salaireBrut * (7.3m / 100m);
            decimal accident = salaireBrut * (2.24m / 100m);
            decimal vieillesseRetraite = salaireBrut * (10.45m / 100m);
            decimal patronRetraite = salaireBrut * (4.72m / 100m);
            decimal CEG = salaireBrut * (1.29m / 100m);
            decimal allocFamille = salaireBrut * (3.45m / 100m);
            decimal CFNAL = salaireBrut * (0.1m / 100m); // Contribution au Fonds National d'Aide au Logement
            decimal chomage = salaireBrut * (4.05m / 100m);
            decimal CRGS = salaireBrut * (0.15m / 100m); // Cotisation au Régime de Garantie des Salaires
            decimal formatProfession = salaireBrut * (0.55m / 100m);
            decimal taxe = salaireBrut * (0.68m / 100m);
            decimal contribSociales = salaireBrut * (0.02m / 100m);
            decimal SMIC = salaireBrut * (32.00m / 100m); // Exonérations de cotisations patronales
            decimal totalCotisPatron = patronSante + maladie + accident + vieillesseRetraite + patronRetraite + CEG + allocFamille + CFNAL + chomage + CRGS + formatProfession + taxe + contribSociales + SMIC;

            decimal salaireNet = salaireBrut - totalCotisSalar;
            decimal montantTotal = salaireNet + totalCotisPatron;

            Console.WriteLine(" ");
            Console.WriteLine("**** Fiche de Paye {0} ****", entreprise);
            Console.WriteLine("Nom : {0}", nom);
            Console.WriteLine("Prénom : {0}", prenom);
            Console.WriteLine("Mois : {0}", mois);
            Console.WriteLine("Année : {0}", annee);
            Console.WriteLine("Nombre d'heures travaillées : {0}", heuresTravaillees);
            Console.WriteLine("Taux horaire : {0}", tauxHoraire);
            Console.WriteLine(" ");
            Console.WriteLine("Salaire brut : {0}", salaireBrut);
            Console.WriteLine(" ");
            Console.WriteLine("Cotisations salariales :");
            Console.WriteLine("Complémentaire santé : {0}", complementSante);
            Console.WriteLine("Vieillesse : {0}", vieillesse);
            Console.WriteLine("Retraite complémentaire : {0}", retraiteComplement);
            Console.WriteLine("Contribution à l'équilibre général : {0}", contribEquilibreGene);
            Console.WriteLine("CSG déduite : {0}", CSGdedu);
            Console.WriteLine("CSG non déduite : {0}", CSGnonDedu);
            Console.WriteLine("CRDS : {0}", CRDS);
            Console.WriteLine("Total cotisations salariales : {0}", totalCotisSalar);
            Console.WriteLine(" ");
            Console.WriteLine("Cotisations patronales :");
            Console.WriteLine("Complémentaire santé : {0}", patronSante);
            Console.WriteLine("Maladie : {0}", maladie);
            Console.WriteLine("Accidents du travail et Maladies professionnelles : {0}", accident);
            Console.WriteLine("Vieillesse : {0}", vieillesseRetraite);
            Console.WriteLine("Retraite complémentaire : {0}", patronRetraite);
            Console.WriteLine("Contribution à l'équilibre général : {0}", CEG);
            Console.WriteLine("Allocations familiales : {0}", allocFamille);
            Console.WriteLine("Contribution au Fonds National d'Aide au Logement : {0}", CFNAL);
            Console.WriteLine("Chômage : {0}", chomage);
            Console.WriteLine("Cotisation au Régime de Garantie des Salaires : {0}", CRGS);
            Console.WriteLine("Formation professionnelle : {0}", formatProfession);
            Console.WriteLine("Taxe d'apprentissage : {0}", taxe);
            Console.WriteLine("Contribution au dialogue social : {0}", contribSociales);
            Console.WriteLine("Exonération cotisations patronales : {0}", SMIC);
            Console.WriteLine("Total cotisations patronales : {0}", totalCotisPatron);
            Console.WriteLine(" ");
            Console.WriteLine("Salaire net : {0}", salaireNet);
            Console.WriteLine("Montant total employeur : {0}", montantTotal);

        }
    }
}