namespace Auth
{
    public class Passwords
    {
        private Passwords(string value) { Value = value; }

        public string Value { get; private set; }

        public static Passwords User { get { return new Passwords("Up@ssw0rd"); } }
        public static Passwords Admin{ get { return new Passwords("Ap@ssw0rd"); } }
	}
}

