using System.Collections.Generic;
using System.Linq;
using TrustImobiliare.Domain.Entities;

namespace TrustImobiliare.Persistance
{
    public static class Seed
    {
        public static void Initialize(TrustImobiliareDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Properties.Any())
            {
                return;
            }

            SeedAgents(context);
            SeedTypes(context);
            SeedProperties(context);
        }

        private static void SeedAgents(TrustImobiliareDbContext context)
        {
            var agents = new List<Agent>
            {
                new Agent {FirstName = "Adriana", LastName = "Stacnu", PhotoLink = "https://images.unsplash.com/photo-1573497491306-c8a68afac6f2?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format   "},
                new Agent {FirstName = "Cosmin", LastName = "Voicu", PhotoLink = "https://images.unsplash.com/photo-1560250097-0b93528c311a?ixlib=rb-1.2.1&auto=format"}
            };

            context.AddRange(agents);
            context.SaveChanges();
        }

        private static void SeedTypes(TrustImobiliareDbContext context)
        {
            var types = new List<Type>
            {
                new Type {Name = "apartament"},
                new Type {Name = "teren"},
                new Type {Name = "garsonieră"},
                new Type {Name = "casă"},
                new Type {Name = "spațiu comercial"},
                new Type {Name = "spațiu de birouri"},
                new Type {Name = "spațiu industrial"}
            };

            context.AddRange(types);
            context.SaveChanges();
        }

        private static void SeedProperties(TrustImobiliareDbContext context)
        {
            var properties = new List<Property>
            {
                new Property
                {
                    Name = "Apartament de închiriat - Cocoșvar Vulcan",
                    Description = "De închiriat apartament cu 3 camere, complet mobilat și utilat, în cartierul Cocoșvar din Vulcan. Apartamentul se află la etajul 3 al unui imobil cu 4 etaje.\nZona este foarte bine cotată din punct de vedere imobiliar, astfel încat în apropiere avem diferite magazine alimentare, instituții de învățământ și numeroase alte puncte de interes.\nApartamentul are o suprafață utilă de 63 mp, și este compartimentata astfel:\n– două dormitoare\n– baie cu cadă și geam\n– living spațios și bucătărie",
                    Status = "De închiriat",
                    Price = 250,
                    Surface = 63,
                    PrimaryPhotoLink = "https://cdn.pixabay.com/photo/2015/11/07/21/29/living-1032733_960_720.jpg",
                    PhotoLinks = "https://cdn.pixabay.com/photo/2018/05/02/09/02/baby-boy-3368016_960_720.jpg,https://cdn.pixabay.com/photo/2017/07/31/14/56/apartment-2558277_960_720.jpg,https://cdn.pixabay.com/photo/2017/02/24/12/22/kitchen-2094707_960_720.jpg,https://cdn.pixabay.com/photo/2017/02/24/12/23/bathroom-2094716_960_720.jpg",
                    Rooms = 3,
                    Bathrooms = 1,
                    Year = 2013,
                    TypeId = 2,
                    AgentId = 1,
                    Address = new Address {Country = "Romania", Region = "Hunedoara", City = "Vulcan", Neighborhood = "Cocoșvar", AddressDetail = "Strada Romană 63"},
                    Features = new List<Feature> {new Feature {Name = "Amenajare străzi", Value = "Asfaltate,Iluminat stradal,Mijloace de transport în comun"}, new Feature {Name = "Bucătărie", Value = "Deschisă,Mobilată,Utilată"}, new Feature {Name = "Contorizare", Value = "Apometre,Contor electric,Contor gaz"}, new Feature {Name = "Dotări", Value = "Aragaz,Cadă,Mașină de spălat,TV"}, new Feature {Name = "Dotări imobil", Value = "Interfon"}, new Feature {Name = "Ferestre", Value = "PVC"}, new Feature {Name = "IT&C", Value = "Internet"}, new Feature {Name = "Mobilat", Value = "Complet"}, new Feature {Name = "Pereți", Value = "Faianță,Vopsea lavabilă"}, new Feature {Name = "Podele", Value = "Gresie,Parchet"}, new Feature {Name = "Priveliște", Value = "Vedere spre oraș"}, new Feature {Name = "Sistem încălzire", Value = "Calorifere,Centrală proprie"}, new Feature {Name = "Utilități generale", Value = "Apă,Canalizre,CATV,Curent,Gaz"}, new Feature {Name = "Uși interior", Value = "Lemn"}, new Feature {Name = "Ușă intrare", Value = "Metal"}}
                },
                new Property
                {
                    Name = "Spațiu de birouri - Petroșani",
                    Description = "Vă propunem spre închiriere un spațiu pretabil pentru birouri, cu suprafața utilă de 185mp, în Petroșani, clădirea CNH-ului.\nSpațiul este structurat astfel:\nParter: 4 camere, baie, spațiu depozitare;\nEtaj: 2 camere, baie, balcon;\nAvantaje:\n– zonă de interes;\n– renovat recent",
                    Status = "De închiriat",
                    Price = 800,
                    Surface = 185,
                    PrimaryPhotoLink = "https://images.pexels.com/photos/416320/pexels-photo-416320.jpeg?cs=srgb&dl=chairs-daylight-designer-empty-416320.jpg&fm=jpg",
                    PhotoLinks = "https://images.pexels.com/photos/3712597/pexels-photo-3712597.jpeg?cs=srgb&dl=black-office-rolling-chair-beside-white-wooden-table-3712597.jpg&fm=jpg,https://images.pexels.com/photos/1957478/pexels-photo-1957478.jpeg?cs=srgb&dl=white-rolling-armchair-beside-table-1957478.jpg&fm=jpg",
                    Rooms = 6,
                    Bathrooms = 2,
                    Year = 1950,
                    TypeId = 6,
                    AgentId = 2,
                    Address = new Address {Country = "Romania", Region = "Hunedoara", City = "Petroșani", Neighborhood = "Centru", AddressDetail = "Strada Preparaţiei 7"},
                    Features = new List<Feature> {new Feature {Name = "IT&C", Value = "Internet,Telefon"}}
                },
                new Property
                {
                    Name = "Garsonieră de închiriat - Vulcan",
                    Description = "Garsoniera are o compartimentare semidecomandată, compusă din: living, bucătărie, baie, hol și balcon.\nÎmbunătățiri: ușă de metal la intrare, geamuri PVC, centrală propie, calorifere aluminiu, gresie, faianță, parchet, instalații termice, electrice și sanitare.\nAvantaje zona : mijloc de transport în comun, supermarket-uri, instituții de învățământ, locuri de joacă pentru copii, etc.Garsoniera se închiriază complet mobilată și utilată.\nVă așteptăm cu drag la vizionare!",
                    Status = "De închiriat",
                    Price = 165,
                    Surface = 32,
                    PrimaryPhotoLink = "https://cdn.pixabay.com/photo/2018/01/26/08/15/dining-room-3108037_960_720.jpg",
                    PhotoLinks = "https://images.pexels.com/photos/784149/pexels-photo-784149.jpeg?cs=srgb&dl=two-green-leaf-plants-with-orange-pots-on-terrace-784149.jpg&fm=jpg,https://cdn.pixabay.com/photo/2017/02/24/12/19/apartment-2094666_960_720.jpg,https://cdn.pixabay.com/photo/2018/01/29/07/55/modern-minimalist-bathroom-3115450_960_720.jpg",
                    Rooms = 1,
                    Bathrooms = 1,
                    Year = 1980,
                    TypeId = 3,
                    AgentId = 1,
                    Address = new Address {Country = "Romania", Region = "Hunedoara", City = "Vulcan", Neighborhood = "Centru", AddressDetail = "Strada Romană 63"},
                    Features = new List<Feature> {new Feature {Name = "Amenajare străzi", Value = "Asfaltate,Iluminat stradal,Mijloace de transport în comun"}, new Feature {Name = "Bucătărie", Value = "Mobilată,Utilată"}, new Feature {Name = "Contorizare", Value = "Apometre,Contor electric,Contor gaz"}, new Feature {Name = "Dotări", Value = "Aragaz,Cadă,Dressing,Frigider,Mașină de spălat,TV"}, new Feature {Name = "Dotări imobil", Value = "Interfon"}, new Feature {Name = "Electrocasnice", Value = "Hotă"}, new Feature {Name = "Ferestre", Value = "Geamuri cu izolație fonică,Geamuri termopan"}, new Feature {Name = "IT&C", Value = "Internet(Wireless)"}, new Feature {Name = "Izolații termice", Value = "Exterior"}, new Feature {Name = "Mobilat", Value = "Complet"}, new Feature {Name = "Parcare", Value = "Parcare deschisă"}, new Feature {Name = "Pereți", Value = "Faianță,Vopsea lavabilă"}, new Feature {Name = "Podele", Value = "Gresie,Parchet laminat"}, new Feature {Name = "Priveliște", Value = "Vedere spre oraș"}, new Feature {Name = "Sistem încălzire", Value = "Calorifere,Centrală proprie"}, new Feature {Name = "Utilități generale", Value = "Apă,Canalizre,CATV,Curent,Gaz"}, new Feature {Name = "Uși interior", Value = "Lemn"}, new Feature {Name = "Ușă intrare", Value = "Metal"}}
                },
                new Property
                {
                    Name = "Garsonieră de vânzare - Lupeni",
                    Description = "Agenția noastră vă propune spre vânzare garsonieră nedecomandată, situată la etajul 2 din 4 al unui imobil edificat în jurul anului 1980.\nCu o suprafață utilă de aproximativ 25mp, locuința este compusă din living, bucătărie și baie. Garsoniera dispune și de un spațiu de depozitare suplimentar. Locuința beneficiază de centrală termică proprie, calorifer de oțel, uță de metal la intrare, uți de lemn pe interior, parchet, gresie, faianță.\nImobilul este pretabil pentru închiriat, fiind o zonă în care se află mulți potențiali chiriași generați de fabricile din zonă. În imediata vecinătate se află magazine alimentare, farmacii și alte puncte de inters public.",
                    Status = "De vânzare",
                    Price = 8700,
                    Surface = 25,
                    PrimaryPhotoLink = "https://cdn.pixabay.com/photo/2017/12/27/14/41/window-3042834_960_720.jpg",
                    PhotoLinks = "https://cdn.pixabay.com/photo/2016/07/26/18/30/kitchen-1543493_960_720.jpg,https://cdn.pixabay.com/photo/2018/08/15/20/53/bad-3609070_960_720.jpg",
                    Rooms = 1,
                    Bathrooms = 1,
                    Year = 1980,
                    TypeId = 3,
                    AgentId = 1,
                    Address = new Address {Country = "Romania", Region = "Hunedoara", City = "Lupeni", Neighborhood = "Cartierul Viitorului", AddressDetail = "Strada Viitorului C3"},
                    Features = new List<Feature> { new Feature { Name = "Alte spații", Value = "Debara" }, new Feature {Name = "Amenajare străzi", Value = "Asfaltate,Iluminat stradal,Mijloace de transport în comun"}, new Feature {Name = "Contorizare", Value = "Apometre,Contor electric,Contor gaz"}, new Feature {Name = "Dotări imobil", Value = "Interfon"}, new Feature {Name = "Ferestre", Value = "PVC"}, new Feature {Name = "IT&C", Value = "Internet(Wireless),Telefon"}, new Feature {Name = "Izolații termice", Value = "Exterior"}, new Feature {Name = "Mobilat", Value = "Nemobilat"}, new Feature {Name = "Parcare", Value = "Parcare deschisă"}, new Feature {Name = "Pereți", Value = "Faianță,Vopsea lavabilă"}, new Feature {Name = "Podele", Value = "Gresie,Parchet laminat"}, new Feature {Name = "Priveliște", Value = "Vedere spre oraș"}, new Feature {Name = "Sistem încălzire", Value = "Calorifere,Centrală proprie"}, new Feature {Name = "Utilități generale", Value = "Apă,Canalizre,CATV,Curent,Gaz"}, new Feature {Name = "Uși interior", Value = "Lemn"}, new Feature {Name = "Ușă intrare", Value = "Metal"}}
                },
                new Property
                {
                    Name = "Teren de vânzare - Petrila",
                    Description = "Vă oferim spre vânzare un teren intravilan situat în localitatea Petrila. Terenul are o suprafață de 5800mp, cu deschidere la drum de 44ml.\nCa și utilități avem:\n- apă;\n- canal;\n- gaz metan;\n- curent electric.",
                    Status = "De vânzare",
                    Price = 48600,
                    Surface = 5400,
                    PrimaryPhotoLink = "https://images.unsplash.com/photo-1495107334309-fcf20504a5ab?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format",
                    PhotoLinks = "https://images.unsplash.com/photo-1510274460854-4b7ad642d3a9?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format",
                    TypeId = 1,
                    AgentId = 2,
                    Address = new Address {Country = "Romania", Region = "Hunedoara", City = "Petrila", Neighborhood = "Prislop", AddressDetail = "Strada Prislop 1"},
                    Features = new List<Feature> {new Feature {Name = "Alte caracteristici", Value = "Oportunitate de investiții"}, new Feature {Name = "Amenajare străzi", Value = "Asfaltate,Iluminat stradal"}, new Feature {Name = "Utilități teren", Value = "Apă,Canalizare,Curent,Gaz"}}
                },
                new Property
                {
                    Name = "Spațiu comercial de închiriat - Petrila",
                    Description = "Agentia noastră vă propune spre închiriere un spațiu comercial cu suprafața utilă de 96mp, open space cu deschidere stradala de 13.75 ml, situat pe Strada Republicii, Petrila.\nProprietatea este ideală pentru: showroom, carmangerie, birou, salon înfrumusețare, cabinet.\nExistă 5 locuri de parcare în fața imobilului.",
                    Status = "De închiriat",
                    Price = 700,
                    Surface = 95,
                    PrimaryPhotoLink = "https://images.unsplash.com/photo-1565621775772-6e3f64cb7a7d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format",
                    PhotoLinks = "https://cdn.pixabay.com/photo/2018/05/12/16/07/lost-places-3393809_960_720.jpg",
                    Rooms = 1,
                    Bathrooms = 1,
                    Year = 2019,
                    TypeId = 5,
                    AgentId = 2,
                    Address = new Address {Country = "Romania", Region = "Hunedoara", City = "Petrila", Neighborhood = "Centru", AddressDetail = "Str. Republicii 6"},
                    Features = new List<Feature> {new Feature {Name = "Amenajare străzi", Value = "Asfaltate,Iluminat stradal,Mijloace de transport în comun"}, new Feature {Name = "Parcare", Value = "Parcare deschisă"}, new Feature {Name = "Utilități generale", Value = "Apă,Canalizre,CATV,Curent,Gaz"}}
                },
                new Property
                {
                    Name = "Casă modernă de închiriat",
                    Description = "Imobil spre închiriere situat în Petroșani.\nProprietatea beneficiază de o suprafață utilă de 120mp, cu dispunere pe doua niveluri P + E, oferind o suprafață de teren de 200mp.\nCompartimentare:\nParter: living generos, bucătărie, baie;\nEtaj: 3 dormitoare, birou, baie, hol;\nÎmbunătățiri și dotări: încălzire în pardoseală la parter, scară interioară din lemn, travertin în băi și terasă, marmură la intrarea în locuință, totul mobilat și utilat cu produse de foarte bună calitate.\nAvantaje:\n– stradă privată, pavată;\n– 2 locuri de parcare;\n– cameră tehnică;\n– exterior la cheie amenajat cu gazon;\n– mobilier nou;\nLocuința se închiriază complet mobilată și utilată!",
                    Status = "De închiriat",
                    Price = 500,
                    Surface = 120,
                    PrimaryPhotoLink = "https://cdn.pixabay.com/photo/2013/08/30/12/56/holiday-house-177401_960_720.jpg",
                    PhotoLinks = "https://cdn.pixabay.com/photo/2018/05/25/17/52/home-3429674_960_720.jpg,https://cdn.pixabay.com/photo/2016/11/14/02/28/apartment-1822409_960_720.jpg,https://cdn.pixabay.com/photo/2014/10/16/08/39/bedroom-490779_960_720.jpg,https://cdn.pixabay.com/photo/2014/08/11/21/39/wall-416060_960_720.jpg",
                    Rooms = 4,
                    Bathrooms = 2,
                    Year = 2018,
                    TypeId = 4,
                    AgentId = 2,
                    Address = new Address {Country = "Romania", Region = "Hunedoara", City = "Petroșani", Neighborhood = "Spital", AddressDetail = "Strada Nicolae Titulescu 14"},
                    Features = new List<Feature> {new Feature {Name = "Alte spații", Value = "Curte,Debara,Grădină,WC Serviciu"}, new Feature {Name = "Amenajare străzi", Value = "Asfaltate,Iluminat stradal,Mijloace de transport în comun"}, new Feature {Name = "Contorizare", Value = "Apometre,Contor electric,Contor gaz"}, new Feature {Name = "Dotări", Value = "Aragaz,Cadă,Dressing,Mașină de spălat"}, new Feature {Name = "Dotări imobil", Value = "Acoperiș"}, new Feature {Name = "Ferestre", Value = "PVC"}, new Feature {Name = "IT&C", Value = "Internet,Telefon"}, new Feature {Name = "Izolații termice", Value = "Exterior"}, new Feature {Name = "Mobilat", Value = "Complet"}, new Feature {Name = "Pereți", Value = "Faianță,Vopsea lavabilă"}, new Feature {Name = "Podele", Value = "Gresie,Parchet laminat"}, new Feature {Name = "Sistem încălzire", Value = "Calorifere,Centrală proprie"}, new Feature {Name = "Utilități generale", Value = "Apă,Canalizre,CATV,Curent,Gaz"}, new Feature {Name = "Uși interior", Value = "MDF"}, new Feature {Name = "Ușă intrare", Value = "Metal"}}
                },
                new Property
                {
                    Name = "Teren intravilan - Lupeni",
                    Description = "Agentia noastră vă oferă spre vânzare teren intravilan situat în localitatea Lupeni, judetul Hunedoara, cu suprafața de 3400 mp. Dispune de o deschidere la stradă de 24ml, ideal pentru locuință individuală sau locuințe multiple. Ca utilități avem apă, canal și curent electric la stradă, iar gazul metan la 100m. Terenul este învecinat cu case și vile noi.",
                    Status = "De vânzare",
                    Price = 34000,
                    Surface = 3400,
                    PrimaryPhotoLink = "https://images.unsplash.com/photo-1561297489-bbf7a3871769?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format",
                    PhotoLinks = "https://images.unsplash.com/photo-1553490686-e66583ce2f96?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format",
                    TypeId = 1,
                    AgentId = 2,
                    Address = new Address {Country = "Romania", Region = "Hunedoara", City = "Lupeni", Neighborhood = "Cartierul Sohodol", AddressDetail = "Cartierul Sohodol A"},
                    Features = new List<Feature> {new Feature {Name = "Alte caracteristici", Value = "Oportunitate de investiții,Teren împrejmuit"}, new Feature {Name = "Amenajare străzi", Value = "Asfaltate,Iluminat stradal"}, new Feature {Name = "Utilități teren", Value = "Apă,Canalizre,Curent,Gaz"}}
                },
                new Property
                {
                    Name = "Spațiu industrial - Service auto",
                    Description = "Clădirea cu suprafața de 1359mp utili este compusă din 18 încăperi funcționale: spațiu mecanică, spațiu tinichigerie, cabină vopsit, recepție, stație ITP, magazii, vestiar, zonă birouri și așteptare clienți, plus 2 grupuri sanitare.\nTerenul aferent clădirii este de 2396mp, curtea liberă fiind betonată integral și pregatită pentru parcare.\nImobilul se vinde mobilat și dotat pentru desfășurarea activității de mecanică auto, tinchigerie/vopsitorie, incluzând următoarele echipamente:\n– Elevatoare;\n– Rampă de reglat unghiuri;\n– Spațiu pregătire vopsitorie;\n– Cabină de vopsit;\n– Instalație de aer comprimat;\n– Dispozitiv de îndreptat caroserii;\n– Linie ITP.",
                    Status = "De vânzare",
                    Price = 300000,
                    Surface = 1359,
                    PrimaryPhotoLink = "https://cdn.pixabay.com/photo/2016/11/29/09/32/antique-1868726_960_720.jpg",
                    PhotoLinks = "https://cdn.pixabay.com/photo/2015/09/16/20/11/garage-943249_960_720.jpg",
                    Rooms = 18,
                    Bathrooms = 2,
                    TypeId = 7,
                    AgentId = 2,
                    Address = new Address {Country = "Romania", Region = "Hunedoara", City = "Petroșani", Neighborhood = "Dărănești", AddressDetail = "Strada 1 Decembrie 1918"},
                    Features = new List<Feature> {new Feature {Name = "Amenajare străzi", Value = "Asfaltate,Iluminat stradal"}, new Feature {Name = "Utilități teren", Value = "Apă,Canalizre,Curent,Gaz"}}
                },
                new Property
                {
                    Name = "Apartament 2 camere - Vulcan",
                    Description = "Apartament cu 2 camere decomandate situat în Cartierul Dincă, Vulcan.\nApartamentul cu suprafața de 60 mp utili este situat la etajul 1 al unui imobil cu 4 etaje.\nAcesta este compus din 2 camere mari cu acces la baie din ambele camere și o bucătărie generoasă.\n Locuința beneficiază de contorizare separată, interfon, centrală termică proprie cu calorifere, geamuri termopan, parchet din lemn masiv.",
                    Status = "De vânzare",
                    Price = 12000,
                    Surface = 60,
                    PrimaryPhotoLink = "https://images.pexels.com/photos/129494/pexels-photo-129494.jpeg?cs=srgb&dl=apartment-architecture-balcony-building-129494.jpg&fm=jpg",
                    PhotoLinks = "https://images.pexels.com/photos/1571468/pexels-photo-1571468.jpeg?cs=srgb&dl=gray-fabric-sofa-placed-indoor-1571468.jpg&fm=jpg,https://images.pexels.com/photos/1454806/pexels-photo-1454806.jpeg?cs=srgb&dl=photo-of-bedroom-1454806.jpg&fm=jpg,https://images.pexels.com/photos/2062426/pexels-photo-2062426.jpeg?cs=srgb&dl=chopping-boards-near-oven-under-hood-2062426.jpg&fm=jpg,https://images.pexels.com/photos/1910472/pexels-photo-1910472.jpeg?cs=srgb&dl=oval-mirror-near-toilet-bowl-1910472.jpg&fm=jpg",
                    Rooms = 2,
                    Bathrooms = 1,
                    Year = 1980,
                    TypeId = 2,
                    AgentId = 1,
                    Address = new Address {Country = "Romania", Region = "Hunedoara", City = "Vulcan", Neighborhood = "Cocoșvar", AddressDetail = "Strada Romană 63"},
                    Features = new List<Feature> {new Feature {Name = "Amenajare străzi", Value = "Asfaltate,Iluminat stradal,Mijloace de transport în comun"}, new Feature {Name = "Contorizare", Value = "Apometre,Contor electric,Contor gaz"}, new Feature {Name = "Dotări", Value = "Aragaz,Bideu,Cabină de duș,Dressing,Frigider,Mașină de spălat,TV"}, new Feature {Name = "Dotări imobil", Value = "Interfon"}, new Feature { Name = "Electrocanice", Value = "Hotă" }, new Feature {Name = "Ferestre", Value = "Geamuri termopan"}, new Feature {Name = "IT&C", Value = "Internet,Telefon"}, new Feature {Name = "Mobilat", Value = "Parțial"}, new Feature {Name = "Pereți", Value = "Faianță,Vopsea lavabilă"}, new Feature {Name = "Podele", Value = "Gresie,Parchet"}, new Feature {Name = "Priveliște", Value = "Vedere spre oraș"}, new Feature {Name = "Sistem încălzire", Value = "Calorifere,Centrală proprie"}, new Feature {Name = "Utilități generale", Value = "Apă,Canalizre,CATV,Curent,Gaz"}, new Feature {Name = "Uși interior", Value = "Lemn"}, new Feature {Name = "Ușă intrare", Value = "PVC"}}
                },
                new Property
                {
                    Name = "Garsonieră de vânzare",
                    Description = "Agenția noatră vă oferă spre vânzare o Garsoniera cu suprafața utila de 45mp + balcon 5mp în X din Petroșani.\nGarsoniera este situată la etajul 2 al unui imobil cu 4 nivele și este structurată astfel:\n– cameră;\n– hol;\n– bucătărie;\n– baie;\n– balcon (închis și transformat în loc pentru gătit).\nÎmbunătățiri: ușă de metal la intrare, geamuri PVC, centrală propie, calorifere aluminiu, gresie, faianță, parchet, instalații termice, electrice si sanitare.\n Avantaje zonă : mijloc de transport în comun, supermarket-uri, instituții de învățământ, locuri de joacă pentru copii.\n Datorită spațiului generos, locuința poate fi recompartimentată, transformându-se în 2 camere decomandate!",
                    Status = "De vânzare",
                    Price = 9000,
                    Surface = 45,
                    PrimaryPhotoLink = "https://images.pexels.com/photos/1571470/pexels-photo-1571470.jpeg?cs=srgb&dl=three-gray-ornaments-on-white-wooden-desk-inside-living-room-1571470.jpg&fm=jpg",
                    PhotoLinks = "https://cdn.pixabay.com/photo/2016/02/26/22/22/kitchen-1224845_960_720.jpg,https://cdn.pixabay.com/photo/2017/02/24/12/23/bathroom-2094714_960_720.jpg",
                    Rooms = 1,
                    Bathrooms = 1,
                    Year = 2011,
                    TypeId = 3,
                    AgentId = 1,
                    Address = new Address {Country = "Romania", Region = "Hunedoara", City = "Petroșani", Neighborhood = "Parângu", AddressDetail = "Strada Oituz 8"},
                    Features = new List<Feature> {new Feature {Name = "Amenajare străzi", Value = "Asfaltate,Iluminat stradal,Mijloace de transport în comun"}, new Feature {Name = "Contorizare", Value = "Apometre,Contor electric,Contor gaz"}, new Feature {Name = "Dotări imobil", Value = "Interfon"}, new Feature {Name = "Ferestre", Value = "PVC"}, new Feature {Name = "Izolații termice", Value = "Exterior"}, new Feature {Name = "Pereți", Value = "Faianță,Vopsea lavabilă"}, new Feature {Name = "Podele", Value = "Gresie,Parchet laminat"}, new Feature {Name = "Utilități generale", Value = "Apă,Canalizre,CATV,Curent,Gaz"}, new Feature {Name = "Uși interior", Value = "MDF"}, new Feature {Name = "Ușă intrare", Value = "Metal"}}
                },
                new Property
                {
                    Name = "Apartament de închiriat - Petroșani",
                    Description = "Vă oferim spre închiriere un deosebit apartament cu 3 camere, decomodat, modern, situat la parter, în cartierul Aeroport.\nAcest apartament este format din hol, bucătărie, 2 dormitoare matrimoniale, un living, 2 grupuri sanitare și balcon. În plus, imobilul dispune și de o minunată gradină. Proprietatea beneficiază de: geamuri termopan, parchet, gresie, uși de interior de lemn. Încălzirea este realizată prin centrală propie pe gaz.\nAvantajele acestui imobil sunt oportunitatea de a locuii într-un mediu curat și elegant, accesul fiind unul sporit către centrele comerciale, instituții de învățământ(6 - 10 minute), gradinițe, piață, farmacii, bănci.\nBeneficiază de un loc de parcare inclus, așadar nu veți avea probleme cu parcarea.\nImobilul se închiriază mobilat și utilat modern.\nApartamentul este potrivit pentru o familie și merită vizualizarea dumneavoastră!",
                    Status = "De închiriat",
                    Price = 250,
                    Surface = 77,
                    PrimaryPhotoLink = "https://images.pexels.com/photos/129494/pexels-photo-129494.jpeg?cs=srgb&dl=apartment-architecture-balcony-building-129494.jpg&fm=jpg",
                    PhotoLinks = "https://cdn.pixabay.com/photo/2016/11/18/17/20/couch-1835923_960_720.jpg,https://cdn.pixabay.com/photo/2016/06/10/01/05/hotel-room-1447201_960_720.jpg,https://cdn.pixabay.com/photo/2014/08/11/21/40/bedroom-416063_960_720.jpg,https://cdn.pixabay.com/photo/2016/12/30/07/59/kitchen-1940175_960_720.jpg,https://cdn.pixabay.com/photo/2017/02/24/12/24/bathroom-2094733_960_720.jpg",
                    Rooms = 3,
                    Bathrooms = 2,
                    Year = 1980,
                    TypeId = 2,
                    AgentId = 1,
                    Address = new Address {Country = "Romania", Region = "Hunedoara", City = "Petroșani", Neighborhood = "Aviatorilor", AddressDetail = "Strada Aviatorilor 17"},
                    Features = new List<Feature> {new Feature {Name = "Amenajare străzi", Value = "Asfaltate,Iluminat stradal,Mijloace de transport în comun"}, new Feature {Name = "Contorizare", Value = "Apometre,Contor electric,Contor gaz"}, new Feature {Name = "Dotări", Value = "Aragaz,Mașină de spălat"}, new Feature {Name = "Ferestre", Value = "PVC"}, new Feature {Name = "IT&C", Value = "Internet,Telefon"}, new Feature {Name = "Izolații termice", Value = "Exterior"}, new Feature {Name = "Pereți", Value = "Faianță,Vopsea lavabilă"}, new Feature {Name = "Podele", Value = "Gresie,Parchet laminat"}, new Feature {Name = "Utilități generale", Value = "Apă,Canalizre,CATV,Curent,Gaz"}, new Feature {Name = "Uși interior", Value = "MDF"}, new Feature {Name = "Ușă intrare", Value = "Metal"}}
                },
                new Property
                {
                    Name = "Casă de vânzare",
                    Description = "Vă oferim spre vânzare o casă deosebită, cu o compartimentare bine gândită și funcțională, situată în localitatea Petrila.\nCasa cu suprafața utilă de 190mp a fost construită în anul 2019 și este formată din parter plus etaj. Suprafața totală a terenului este de 604mp, iar curtea este de 300 mp unde găsim o adevarată oază de verdeață, aer curat și multă liniște.\n Parterul este destinat zonei de zi, fiind prevăzut cu încălzire în pardoseală și este compus din living spațios cu loc de servire a mesei, cu bucătărie, terasă acoperită și încălzită și spațiu tehnic.\n Etajul beneficiază de o compartimentare bine gândită și funcțională, fiind compus din hol cu acces la pod, 3 dormitoare spațioase dintre care două cu balcon și baie mare cu aerisire naturală. Podul este pregătit ca și spațiu de depozitare.\n Confortul termic al casei este asigurat de o centrală pe lemne și/sau paleți, completat și de izolația exterioară de 10cm. Casa se vinde la stadiul de gri cu ușă de exterior și ferestre din tâmplărie PVC cu geam termopan, uși de interior din PVC cu geam termopan, garaj care poate fi folosit ca spațiu comercial, spațiu tehnic cu centrală și curtea în care se găsește o cabană de 30mp utili cu zonă de relaxare și BBQ.",
                    Status = "De vânzare",
                    Price = 32000,
                    Surface = 190,
                    PrimaryPhotoLink = "https://cdn.pixabay.com/photo/2016/11/18/17/46/architecture-1836070_960_720.jpg",
                    PhotoLinks = "https://cdn.pixabay.com/photo/2017/09/09/18/25/living-room-2732939_960_720.jpg,https://cdn.pixabay.com/photo/2016/12/30/07/55/bedroom-1940168_960_720.jpg,https://cdn.pixabay.com/photo/2015/02/05/20/36/bed-625386_960_720.jpg,https://cdn.pixabay.com/photo/2017/02/24/12/22/apartment-2094701_960_720.jpg,https://cdn.pixabay.com/photo/2016/04/18/08/51/bathroom-1336164_960_720.jpg,https://cdn.pixabay.com/photo/2016/02/29/11/41/bathroom-1228427_960_720.jpg",
                    Rooms = 4,
                    Bathrooms = 2,
                    Year = 2019,
                    TypeId = 4,
                    AgentId = 2,
                    Address = new Address {Country = "Romania", Region = "Hunedoara", City = "Petrila", Neighborhood = "Cartierul Vulturilor", AddressDetail = "Strada Vulturului 6"},
                    Features = new List<Feature> {new Feature {Name = "Alte spații", Value = "Curte,Grădină"}, new Feature {Name = "Amenajare străzi", Value = "Asfaltate,Iluminat stradal,Mijloace de transport în comun"}, new Feature {Name = "Contorizare", Value = "Apometre,Contor electric"}, new Feature {Name = "Diverse", Value = "Telecomandă poartă acces auto,Telecomandă poartă garaj"}, new Feature {Name = "Dotări", Value = "Bideu"}, new Feature {Name = "Dotări imobil", Value = "Acces pentru persoane cu dizabilități,Spații agrement" }, new Feature {Name = "Ferestre", Value = "Geamuri cu izolație fonică,Geamuri cu protecție UV,Geamuri termopan" }, new Feature {Name = "IT&C", Value = "Internet,Telefon"}, new Feature {Name = "Mobilat", Value = "Nemobilat"}, new Feature { Name = "Parcare", Value = "Garaj,Parcare deschisă" }, new Feature {Name = "Pereți", Value = "Vopsea lavabilă"}, new Feature {Name = "Podele", Value = "Șapă"}, new Feature {Name = "Priveliște", Value = "Vedere spre munte"}, new Feature {Name = "Sistem încălzire", Value = "Magazie"}, new Feature {Name = "Utilități generale", Value = "Apă,Canalizre,CATV,Curent"}, new Feature {Name = "Uși interior", Value = "PVC"}, new Feature {Name = "Ușă intrare", Value = "PVC"}}
                },
                new Property
                {
                    Name = "Casă de vânzare - Petroșani",
                    Description = "Casa cu 5 camere și suprafața de teren de 525 mp este de vanzare pe Strada Păcii, în Petroșani. Casa reprezintă o alegere atat pentru locuit, cât și ca investiție.\nÎn locuința pot trăi chiar și două familii, având deschidere la două străzi, fiecare cu acces propriu, însă poate fi folosită și pentru închiriat, existând deja pentru o parte din locuință schimbare de destinație ca spațiu comercial.\nLocuința are o suprafață utilă de aproximativ 130mp, fiind compusă din living, 4 dormitoare, 2 băi, 2 bucătării și holuri despărțitoare. De asemenea imobilul are și o curte liberă, fiind deja amenajat un spațiu pentru grătar, o terasă și accesul auto pentru 3 autoturisme în curte.\nDin punct de vedere al îmbunătățirilor, casa dispune de centrală termică proprie, calorifere de oțel, parchet, gresie, faianță, ferestre cu geam termopan și tamplarie PVC, ușă de PVC la intrare, uși de lemn pe interior.\nImobilul se află într-o zonă bine cotată din punct de vedere imobiliar, oferind acces cu ușurință spre principalele puncte de interes public din Petroșani.",
                    Status = "De vânzare",
                    Price = 95000,
                    Surface = 130,
                    PrimaryPhotoLink = "https://images.pexels.com/photos/1396122/pexels-photo-1396122.jpeg?cs=srgb&dl=brown-and-gray-painted-house-in-front-of-road-1396122.jpg&fm=jpg",
                    PhotoLinks = "https://cdn.pixabay.com/photo/2017/08/27/10/16/interior-2685521_960_720.jpg,https://cdn.pixabay.com/photo/2017/08/05/12/08/living-room-2583032_960_720.jpghttps://images.pexels.com/photos/2631746/pexels-photo-2631746.jpeg?cs=srgb&dl=bedroom-2631746.jpg&fm=jpg,https://images.pexels.com/photos/1743229/pexels-photo-1743229.jpeg?cs=srgb&dl=room-with-bed-and-wooden-floor-1743229.jpg&fm=jpg,https://images.pexels.com/photos/276554/pexels-photo-276554.jpeg?cs=srgb&dl=apartment-architecture-ceiling-chairs-276554.jpg&fm=jpg,https://images.pexels.com/photos/342800/pexels-photo-342800.jpeg?cs=srgb&dl=bathroom-cabinet-candles-faucet-342800.jpg&fm=jpg,https://images.pexels.com/photos/1909791/pexels-photo-1909791.jpeg?cs=srgb&dl=photo-of-a-bathroom-1909791.jpg&fm=jpg",
                    Rooms = 5,
                    Bathrooms = 2,
                    Year = 1986,
                    TypeId = 4,
                    AgentId = 2,
                    Address = new Address {Country = "Romania", Region = "Hunedoara", City = "Petroșani", Neighborhood = "Dacia", AddressDetail = "Strada Viitorului 30"},
                    Features = new List<Feature> {new Feature {Name = "Alte spații", Value = "Curte,Grădină,Pivniță,Zonă pentru grătar"}, new Feature {Name = "Amenajare străzi", Value = "Asfaltate,Iluminat stradal,Mijloace de transport în comun"}, new Feature {Name = "Bucătărie", Value = "Mobilată,Utilată"}, new Feature {Name = "Contorizare", Value = "Apometre,Contor electric,Contor gaz"}, new Feature {Name = "Dotări", Value = "Aragaz,Cabină de duș,Cadă"}, new Feature {Name = "Dotări imobil", Value = "Spații agrement" }, new Feature {Name = "Ferestre", Value = "Geamuri termopan" }, new Feature {Name = "IT&C", Value = "Internet,Telefon"}, new Feature { Name = "Parcare", Value = "Parcare deschisă" }, new Feature {Name = "Pereți", Value = "Vopsea lavabilă"}, new Feature {Name = "Podele", Value = "Parchet laminat"}, new Feature {Name = "Priveliște", Value = "Vedere spre munte"}, new Feature {Name = "Sistem încălzire", Value = "Centrală proprie"}, new Feature {Name = "Utilități generale", Value = "Apă,Canalizre,CATV,Curent,Gaz"}, new Feature {Name = "Uși interior", Value = "Lemn"}, new Feature {Name = "Ușă intrare", Value = "PVC"}}
                },
                new Property
                {
                    Name = "Apartament 2 camere",
                    Description = "De vânzare apartament decomandat cu două camere situat într-una dintre cele mai prolifice zone din oraș la momentul actual. Aflata la etajul 5 al unui bloc cu 10 etaje, dotat cu lift modern. Locuința face parte dintr-un bloc de apartamente construit în jurul anului 2015 și se predă mobilată și utilată.\nCompartimentare:\n– două camere decomandate;\n– hol mare;\n– bucătărie separată;\n– baie spațioasa cu geam de aerisire;\nAvantaje:\n– bloc cu lift;\n– mobilat și utilat;\n– decomandat, cu bucătărie separată;\n– balcon de 7mp cu vedere spre oraș;\n– loc de parcare inclus.",
                    Status = "De vânzare",
                    Price = 20000,
                    Surface = 50,
                    PrimaryPhotoLink = "https://images.pexels.com/photos/439391/pexels-photo-439391.jpeg?cs=srgb&dl=apartment-balcony-buildings-city-439391.jpg&fm=jpg",
                    PhotoLinks = "https://images.unsplash.com/photo-1541123603104-512919d6a96c?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format,https://images.pexels.com/photos/271619/pexels-photo-271619.jpeg?cs=srgb&dl=bed-bedroom-chair-comfort-271619.jpg&fm=jpg,https://images.pexels.com/photos/271624/pexels-photo-271624.jpeg?cs=srgb&dl=apartment-bed-bedroom-chair-271624.jpg&fm=jpg,https://images.pexels.com/photos/94865/pexels-photo-94865.jpeg?cs=srgb&dl=luxury-kitchen-design-cooking-94865.jpg&fm=jpg,https://images.pexels.com/photos/1571461/pexels-photo-1571461.jpeg?cs=srgb&dl=white-bathtub-in-bathroom-1571461.jpg&fm=jpg",
                    Rooms = 2,
                    Bathrooms = 1,
                    Year = 2015,
                    TypeId = 2,
                    AgentId = 1,
                    Address = new Address {Country = "Romania", Region = "Hunedoara", City = "Lupeni", Neighborhood = "Cartierul Bărbăteni", AddressDetail = "Strada Bărbăteni 69"},
                    Features = new List<Feature> { new Feature { Name = "Alte spații", Value = "Lift" }, new Feature {Name = "Amenajare străzi", Value = "Asfaltate,Iluminat stradal,Mijloace de transport în comun"}, new Feature {Name = "Bucătărie", Value = "Parțial mobilată,Parțial utilată"}, new Feature {Name = "Contorizare", Value = "Apometre,Contor electric,Contor gaz"}, new Feature { Name = "Dotări", Value = "Aragaz,Cadă,Mașină de spălat" }, new Feature {Name = "Dotări imobil", Value = "Interfon"}, new Feature {Name = "Ferestre", Value = "Geamuri termopan"}, new Feature {Name = "IT&C", Value = "Internet,Telefon"}, new Feature {Name = "Izolații termice", Value = "Exterior"}, new Feature {Name = "Mobilat", Value = "Parțial"}, new Feature {Name = "Parcare", Value = "Parcare deschisă"}, new Feature {Name = "Pereți", Value = "Faianță,Vopsea lavabilă"}, new Feature {Name = "Podele", Value = "Gresie,Parchet laminat"}, new Feature {Name = "Priveliște", Value = "Vedere panoramică,Vedere spre oraș"}, new Feature {Name = "Sistem încălzire", Value = "Calorifere,Centrală proprie"}, new Feature {Name = "Utilități generale", Value = "Apă,Canalizre,CATV,Curent,Gaz"}, new Feature {Name = "Uși interior", Value = "Lemn"}, new Feature {Name = "Ușă intrare", Value = "Metal"}}
                }
            };

            context.AddRange(properties);
            context.SaveChanges();
        }
    }
}