public class User
{
    private string _name;
    private string _password;
    private string _email;

    public string Name 
    {
        get { return _name; }
        set 
        {
            if (value == "")
                Console.WriteLine("Error: Empty string in user name");
            else
                _name = value;
        }
    }

    public string Password
    {
        get { return _password; }
        set
        {
            if (value.Length < 8)
            {
                Console.WriteLine("Error: Password is too short");
                return;
            }
            bool capital_letter = false;
            bool special_symbol = false;

            foreach (char i in value)
            {
                if (Char.IsUpper(i))
                    capital_letter = true;
                if (!Char.IsLetterOrDigit(i))
                    special_symbol = true;
            }

            if (!capital_letter)
            {
                Console.WriteLine("Error: There are no capital letters in the password");
                return;
            }

            if (!special_symbol)
            {
                Console.WriteLine("Error: There are no special symbols in the password");
                return;
            }

            _password = value;
        }
    }

    public bool HaveCourse { get; set; }

    public string Email 
    {
        get { return _email; }
        set
        { 
            // TODO
        }
    }
}