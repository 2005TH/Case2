using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Øvelse;

namespace Case2;

interface H
{
    internal class H1
    {
        public PersonModel[] StudieTeknikElever { get; set; }

        public PersonModel[] GrundlæggendeProgrammeringElever { get; set; }

        public PersonModel[] DatabaseProgrammeringElever { get; set; }

        public PersonModel[] OOPElever { get; set; }

        public PersonModel[] ComputerteknologiElever { get; set; }

        public PersonModel[] ClientsideprogrammeringElever { get; set; }

        public PersonModel[] NetværkElever { get; set; }

        public FagModel[] Fag { get; set; }

        public PersonModel[][] AlleElever { get; set; }

        public H1()
        {
            StudieTeknikElever = new PersonModel[]
            {
            new PersonModel() { Fornavn = "Alexander", Efternavn = "Thamdru"},
            new PersonModel() { Fornavn = "Allan", Efternavn = "Gawron"},
            new PersonModel() { Fornavn = "Andreas", Efternavn = "Balle"},
            new PersonModel() { Fornavn = "Darab", Efternavn = "Haqnazar"},
            new PersonModel() { Fornavn = "Felix", Efternavn = "Beger"},
            new PersonModel() { Fornavn = "Jamie", Efternavn = "D"},
            new PersonModel() { Fornavn = "Jeppe", Efternavn = "Pedersen"},
            new PersonModel() { Fornavn = "Joseph", Efternavn = "Hale"},
            new PersonModel() { Fornavn = "Kamil", Efternavn = "Kulpa"},
            new PersonModel() { Fornavn = "Loke", Efternavn = "Bendtsen"},
            new PersonModel() { Fornavn = "Mark", Efternavn = "Larsen"},
            new PersonModel() { Fornavn = "Niklas", Efternavn = "Jensen"},
            new PersonModel() { Fornavn = "Rasmus", Efternavn = "Hjorth"},
            new PersonModel() { Fornavn = "Sammy", Efternavn = "Damiri"},
            new PersonModel() { Fornavn = "Thomas", Efternavn = "Holmberg"},
            new PersonModel() { Fornavn = "Tobias", Efternavn = "Besser"}
            };

            GrundlæggendeProgrammeringElever = new PersonModel[]
            {
            new PersonModel() { Fornavn = "Alexander", Efternavn = "Thamdru"},
            new PersonModel() { Fornavn = "Allan", Efternavn = "Gawron"},
            new PersonModel() { Fornavn = "Andreas", Efternavn = "Balle"},
            new PersonModel() { Fornavn = "Darab", Efternavn = "Haqnazar"},
            new PersonModel() { Fornavn = "Felix", Efternavn = "Beger"},
            new PersonModel() { Fornavn = "Jamie", Efternavn = "D"},
            new PersonModel() { Fornavn = "Jeppe", Efternavn = "Pedersen"},
            new PersonModel() { Fornavn = "Joseph", Efternavn = "Hale"},
            new PersonModel() { Fornavn = "Kamil", Efternavn = "Kulpa"},
            new PersonModel() { Fornavn = "Loke", Efternavn = "Bendtsen"},
            new PersonModel() { Fornavn = "Mark", Efternavn = "Larsen"},
            new PersonModel() { Fornavn = "Niklas", Efternavn = "Jensen"},
            new PersonModel() { Fornavn = "Rasmus", Efternavn = "Hjorth"},
            new PersonModel() { Fornavn = "Sammy", Efternavn = "Damiri"},
            new PersonModel() { Fornavn = "Thomas", Efternavn = "Holmberg"},
            new PersonModel() { Fornavn = "Tobias", Efternavn = "Besser"}
            };

            DatabaseProgrammeringElever = new PersonModel[]
    {
            new PersonModel() { Fornavn = "Alexander", Efternavn = "Thamdru"},
            new PersonModel() { Fornavn = "Allan", Efternavn = "Gawron"},
            new PersonModel() { Fornavn = "Andreas", Efternavn = "Balle"},
            new PersonModel() { Fornavn = "Darab", Efternavn = "Haqnazar"},
            new PersonModel() { Fornavn = "Felix", Efternavn = "Beger"},
            new PersonModel() { Fornavn = "Jamie", Efternavn = "D"},
            new PersonModel() { Fornavn = "Jeppe", Efternavn = "Pedersen"},
            new PersonModel() { Fornavn = "Joseph", Efternavn = "Hale"},
            new PersonModel() { Fornavn = "Kamil", Efternavn = "Kulpa"},
            new PersonModel() { Fornavn = "Loke", Efternavn = "Bendtsen"},
            new PersonModel() { Fornavn = "Mark", Efternavn = "Larsen"},
            new PersonModel() { Fornavn = "Niklas", Efternavn = "Jensen"},
            new PersonModel() { Fornavn = "Rasmus", Efternavn = "Hjorth"},
            new PersonModel() { Fornavn = "Sammy", Efternavn = "Damiri"},
            new PersonModel() { Fornavn = "Thomas", Efternavn = "Holmberg"},
            new PersonModel() { Fornavn = "Tobias", Efternavn = "Besser"}
    };

            OOPElever = new PersonModel[]
            {
            new PersonModel() { Fornavn = "Alexander", Efternavn = "Thamdru"},
            new PersonModel() { Fornavn = "Allan", Efternavn = "Gawron"},
            new PersonModel() { Fornavn = "Andreas", Efternavn = "Balle"},
            new PersonModel() { Fornavn = "Darab", Efternavn = "Haqnazar"},
            new PersonModel() { Fornavn = "Felix", Efternavn = "Beger"},
            new PersonModel() { Fornavn = "Jamie", Efternavn = "D"},
            new PersonModel() { Fornavn = "Jeppe", Efternavn = "Pedersen"},
            new PersonModel() { Fornavn = "Joseph", Efternavn = "Hale"},
            new PersonModel() { Fornavn = "Kamil", Efternavn = "Kulpa"},
            new PersonModel() { Fornavn = "Loke", Efternavn = "Bendtsen"},
            new PersonModel() { Fornavn = "Mark", Efternavn = "Larsen"},
            new PersonModel() { Fornavn = "Niklas", Efternavn = "Jensen"},
            new PersonModel() { Fornavn = "Rasmus", Efternavn = "Hjorth"},
            new PersonModel() { Fornavn = "Sammy", Efternavn = "Damiri"},
            new PersonModel() { Fornavn = "Thomas", Efternavn = "Holmberg"},
            new PersonModel() { Fornavn = "Tobias", Efternavn = "Besser"}
            };

            ComputerteknologiElever = new PersonModel[]
            {
            new PersonModel() { Fornavn = "Alexander", Efternavn = "Thamdru"},
            new PersonModel() { Fornavn = "Allan", Efternavn = "Gawron"},
            new PersonModel() { Fornavn = "Andreas", Efternavn = "Balle"},
            new PersonModel() { Fornavn = "Darab", Efternavn = "Haqnazar"},
            new PersonModel() { Fornavn = "Felix", Efternavn = "Beger"},
            new PersonModel() { Fornavn = "Jamie", Efternavn = "D"},
            new PersonModel() { Fornavn = "Jeppe", Efternavn = "Pedersen"},
            new PersonModel() { Fornavn = "Joseph", Efternavn = "Hale"},
            new PersonModel() { Fornavn = "Kamil", Efternavn = "Kulpa"},
            new PersonModel() { Fornavn = "Loke", Efternavn = "Bendtsen"},
            new PersonModel() { Fornavn = "Mark", Efternavn = "Larsen"},
            new PersonModel() { Fornavn = "Niklas", Efternavn = "Jensen"},
            new PersonModel() { Fornavn = "Rasmus", Efternavn = "Hjorth"},
            new PersonModel() { Fornavn = "Sammy", Efternavn = "Damiri"},
            new PersonModel() { Fornavn = "Thomas", Efternavn = "Holmberg"},
            new PersonModel() { Fornavn = "Tobias", Efternavn = "Besser"}
            };

            ClientsideprogrammeringElever = new PersonModel[]
            {
            new PersonModel() { Fornavn = "Alexander", Efternavn = "Thamdru"},
            new PersonModel() { Fornavn = "Allan", Efternavn = "Gawron"},
            new PersonModel() { Fornavn = "Andreas", Efternavn = "Balle"},
            new PersonModel() { Fornavn = "Darab", Efternavn = "Haqnazar"},
            new PersonModel() { Fornavn = "Felix", Efternavn = "Beger"},
            new PersonModel() { Fornavn = "Jamie", Efternavn = "D"},
            new PersonModel() { Fornavn = "Jeppe", Efternavn = "Pedersen"},
            new PersonModel() { Fornavn = "Joseph", Efternavn = "Hale"},
            new PersonModel() { Fornavn = "Kamil", Efternavn = "Kulpa"},
            new PersonModel() { Fornavn = "Loke", Efternavn = "Bendtsen"},
            new PersonModel() { Fornavn = "Mark", Efternavn = "Larsen"},
            new PersonModel() { Fornavn = "Niklas", Efternavn = "Jensen"},
            new PersonModel() { Fornavn = "Rasmus", Efternavn = "Hjorth"},
            new PersonModel() { Fornavn = "Sammy", Efternavn = "Damiri"},
            new PersonModel() { Fornavn = "Thomas", Efternavn = "Holmberg"},
            new PersonModel() { Fornavn = "Tobias", Efternavn = "Besser"}
            };

            NetværkElever = new PersonModel[]
            {
            new PersonModel() { Fornavn = "Alexander", Efternavn = "Thamdru"},
            new PersonModel() { Fornavn = "Allan", Efternavn = "Gawron"},
            new PersonModel() { Fornavn = "Andreas", Efternavn = "Balle"},
            new PersonModel() { Fornavn = "Darab", Efternavn = "Haqnazar"},
            new PersonModel() { Fornavn = "Felix", Efternavn = "Beger"},
            new PersonModel() { Fornavn = "Jamie", Efternavn = "D"},
            new PersonModel() { Fornavn = "Jeppe", Efternavn = "Pedersen"},
            new PersonModel() { Fornavn = "Joseph", Efternavn = "Hale"},
            new PersonModel() { Fornavn = "Kamil", Efternavn = "Kulpa"},
            new PersonModel() { Fornavn = "Loke", Efternavn = "Bendtsen"},
            new PersonModel() { Fornavn = "Mark", Efternavn = "Larsen"},
            new PersonModel() { Fornavn = "Niklas", Efternavn = "Jensen"},
            new PersonModel() { Fornavn = "Rasmus", Efternavn = "Hjorth"},
            new PersonModel() { Fornavn = "Sammy", Efternavn = "Damiri"},
            new PersonModel() { Fornavn = "Thomas", Efternavn = "Holmberg"},
            new PersonModel() { Fornavn = "Tobias", Efternavn = "Besser"}
            };

            Fag = new FagModel[]
            {
            new FagModel() { FagNavn = "Studieteknik", Lærer = new PersonModel(){ Fornavn = "Niels", Efternavn = "Olesen"} },
            new FagModel() { FagNavn = "Grundlæggende Programmering", Lærer = new PersonModel(){ Fornavn = "Flemming", Efternavn = "Sørensen"} },
            new FagModel() { FagNavn = "OOP", Lærer = new PersonModel() { Fornavn = "Flemming", Efternavn = "Sørensen"} },
            new FagModel() { FagNavn = "Computerteknologi", Lærer = new PersonModel(){ Fornavn = "Niels", Efternavn = "Olesen"} },
            new FagModel() { FagNavn = "Clientsideprogrammering", Lærer = new PersonModel(){ Fornavn = "Peter", Efternavn = "Lindenskov"} },
            new FagModel() { FagNavn = "Netværk", Lærer = new PersonModel(){ Fornavn = "Henrik", Efternavn = "Poulsen"} }
            };

            AlleElever = new PersonModel[][]
            {
            StudieTeknikElever,
            GrundlæggendeProgrammeringElever,
            DatabaseProgrammeringElever,
            OOPElever,
            ComputerteknologiElever,
            ClientsideprogrammeringElever,
            NetværkElever

            };
        }
    }
}