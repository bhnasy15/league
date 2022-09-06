namespace Auth
{
    public class Passwords
    {
        private Passwords(string value) { Value = value; }

        public string Value { get; private set; }

        public static Passwords User { get { return new Passwords("P@55word"); } }
        public static Passwords Admin{ get { return new Passwords("P@55word"); } }
	}
}

