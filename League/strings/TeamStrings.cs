namespace League
{
    public class TeamStrings
    {
        private TeamStrings(List<string> value) { Value = value; }

        public List<string> Value { get; set; }

        public static TeamStrings Names
        {
            get
            {
                return new TeamStrings(new List<string>
                {
					"Nadia Boyer", "Sierra Shaffer", "Kaya Odonnell", "Jayden Barajas",
					"Messiah Flores", "Geovanni Buck", "Alexis Stuart", "Agustin Arias",
					"Stella Avila", "Amari Riddle", "Clay Sexton", "Miles Jimenez",
					"Philip Ramos", "Javion Shaffer", "Rosa Bentley", "Stephanie Berg",
					"Mckenna Wallace", "Cameron Bell", "Kaylee Guerra", "Mary Powers",
					"Camille Weaver", "Kaiden Young", "Kaitlyn Roberson", "Urijah Ali",
					"Jenna Phelps", "Terrence Navarro", "Elias Cummings", "Madelynn Tapia",
					"Jazmin Schwartz", "Nayeli Hoover", "Chaz Stuart", "Josue Kelly",
					"America Parrish", "Genevieve Alvarado", "Julius Jacobson",
					"Taniya Hudson",
					"Ryland Romero", "Madden Henson", "Brandon Crawford", "Cassie Combs",
					"Gerardo Spencer", "Norah Torres", "Ronnie Morse", "Francis Garrett",
					"Ansley Knight", "Laylah Chan", "Donald Frederick", "Tara Singh",
					"Rachael Rangel", "Bradley Campos",
                });
            }
        }

        public static TeamStrings Countries
        {
            get
            {
                return new TeamStrings(new List<string>
                {
                    " Angola", " Benin", " Botswana", " Burkina Faso", " Burundi",
                    " Cameroon", " Cape Verde", " Central African Republic", " Chad",
                    " Comoros1", " Congo", " Congo DR2", " Côte d'Ivoire", " Djibouti1",
                    " Egypt1", " Equatorial Guinea", " Eritrea", " Eswatini", " Ethiopia",
                    " Gabon", " Gambia", " Ghana", " Guinea", " Guinea-Bissau",
                    " Kenya", " Lesotho", " Liberia", " Libya1", " Madagascar",
                    " Malawi", " Mali", " Mauritania1", " Mauritius", " Morocco1",
                    " Mozambique", " Namibia", " Niger", " Nigeria", " Réunion3",
                    " Rwanda", " São Tomé and Príncipe", " Senegal", " Seychelles",
                    " Sierra Leone",
                    " Somalia1", " South Africa", " South Sudan", " Sudan1", " Tanzania",
                    " Togo", " Tunisia1", " Uganda", " Zambia", " Zanzibar3,4,5",
                    " Zimbabwe"
                    });
            }
        }

        public static TeamStrings Logoes
        {
            get
            {
                return new TeamStrings(new List<string>
                {
					"default.jpg"
                });}
        }

    }
}
