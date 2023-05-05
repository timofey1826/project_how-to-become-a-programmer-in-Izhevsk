public class Users{

    private string _name;

    private string _surname;

    private string _email, sobaka;
    string[] pochtavr = {"gmail.com","mail.ru","","","",};

    
    public string name{
        get{ return _name;}
        set
        {
            _name = value;
        }
    }
    public string surname{
        get{ return _surname;}
        set
        {
            _surname = value;
        }
    }
    public string email{
        get{ return _email;}
        set
        {
            for(int i = 0;i < value.Length; i++)
            {

            }
            _email = value;
        }
    }
}