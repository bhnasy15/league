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
                    "Afghanistan", "Australia", "Bahrain", "Bangladesh",
                    "Bhutan", "BruneiDarussalam", "Cambodia", "ChinaPR",
                    "ChineseTaipei", "Guam", "HongKong", "India",
                    "Indonesia", "IRIran", "Iraq", "Japan",
                    "Jordan", "KoreaDPR", "KoreaRepublic", "Kuwait",
                    "KyrgyzRepublic", "Laos", "Lebanon", "Macau",
                    "Malaysia", "Maldives", "Mongolia", "Myanmar",
                    "Nepal", "NorthernMarianaIslands", "Oman", "Pakistan",
                    "Palestine", "Philippines", "Qatar", "SaudiArabia",
                    "Singapore", "SriLanka", "Syria", "Tajikistan",
                    "Thailand", "TimorLeste", "Turkmenistan", "UnitedArabEmirates",
                    "Uzbekistan", "Vietnam", "Yemen"
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
