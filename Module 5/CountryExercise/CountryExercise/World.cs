using System;
using System.Collections.Generic;
using System.Text;

namespace WorldNamespace
{
    abstract class World
    {
        private string planetName;
        private Continents continent;
        public string PlanetName
        {
            get { return planetName; }
            set { planetName = value; }
        }

        public Continents Continent
        {
            get { return continent; }
            set { continent = value; }
        }

    }

    class Country : World
    {
        private string countryName;
        private string capital;
        private CountryLanguage countryLanguages;
        private Currencies currency;


        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        public Currencies Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public CountryLanguage CountryLanguages
        {
            get { return countryLanguages; }
            set { countryLanguages = value; }
        }
        public Country()
        {
            CountryName = "Unknown";
            Capital = "Unkown";
        }
        public void SayHi()
        {
            Console.WriteLine("Welcome there...");

        }
        public void SayHi(string country)
        {
            Console.WriteLine($"Welcome from {country}");

        }

    }
    enum Continents
    {
        Europe, Asia, Australia, NorthAmerica, SouthAmerica, Ocenania, Africa
    }
    enum Currencies
    {
        UnitedArabEmiratesdirham, Afghani, Lek, ArmenianDram, NetherlandsAntillianGuilder, Kwanza, ArgentinePeso, AustralianDollar, ArubanGuilder, AzerbaijanianManat, ConvertibleMarks, BarbadosDollar, BangladeshiTaka, BulgarianLev, BahrainiDinar, BurundianFranc, BermudianDollar, BruneiDollar, Boliviano, BolivianMvdol, BrazilianReal, BahamianDollar, Ngultrum, Pula, BelarussianRuble, BelizeDollar, CanadianDollar, FrancCongolais, WIREuro, SwissFranc, WIRFranc, Unidadesdeformento, ChileanPeso, YuanRenminbi, ColombianPeso, UnidaddeValorReal, CostaRicanColon, CubanPeso, CapeVerdeEscudo, CyprusPound, CzechKoruna, DjiboutiFranc, DanishKrone, DominicanPeso, AlgerianDinar, Kroon, EgyptianPound, Nakfa, EthiopianBirr, Euro, FijiDollar, FalklandIslandsPound, PoundSterling, Lari, Cedi, Gibraltarpound, Dalasi, GuineaFranc, Quetzal, GuyanaDollar, HongKongDollar, Lempira, CroatianKuna, HaitiGourde, Forint, Rupiah, NewIsraeliShekel, IndianRupee, IraqiDinar, IranianRial, IcelandKrona, JamaicanDollar, JordanianDinar, Japaneseyen, KenyanShilling, Som, Riel, ComoroFranc, NorthKoreanWon, SouthKoreanWon, KuwaitiDinar, CaymanIslandsDollar, Tenge, Kip, LebanesePound, SriLankaRupee, LiberianDollar, Loti, LithuanianLitas, LatvianLats, LibyanDinar, MoroccanDirham, MoldovanLeu, MalagasyAriary, Denar, Kyat, Tugrik, Pataca, Ouguiya, MalteseLira, MauritiusRupee, Rufiyaa, Kwacha, MexicanPeso, MexicanUnidaddeInversion, MalaysianRinggit, Metical, NamibianDollar, Naira, CordobaOro, NorwegianKrone, NepaleseRupee, NewZealandDollar, RialOmani, Balboa, NuevoSol, Kina, PhilippinePeso, PakistanRupee, Zloty, Guarani, QatariRial, RomanianNewLeu, SerbianDinar, RussianRuble, RwandaFranc, SaudiRiyal, SolomonIslandsDollar, SeychellesRupee, SudanesePound, SwedishKrona, SingaporeDollar, SaintHelenaPound, SlovakKoruna, Leone, SomaliShilling, SurinamDollar, Dobra, SyrianPound, Lilangeni, Baht, Somoni, Manat, TunisianDinar, Paanga, NewTurkishLira, TrinidadandTobagoDollar, NewTaiwanDollar, TanzanianShilling, Hryvnia, UgandaShilling, USDollar, CFAFrancBEAC, Silveronetroyounce, Goldonetroyounce, EastCarribeanDollar, Palladiumonetroyounce, NoCurrency
    }
    enum Languages
    {
        English, French, German, Italian, Portuegese, Spanish, Chineese, Japanese, Indonesian
    }

    struct CountryLanguage
    {
        private string firstLanguage;
        private string secondLanguage;
        public string FirstLanguage
        {
            get { return firstLanguage; }
            set { firstLanguage = value; }
        }

        public string SecondLanguage
        {
            get { return secondLanguage; }
            set { secondLanguage = value; }
        }
    }
}
