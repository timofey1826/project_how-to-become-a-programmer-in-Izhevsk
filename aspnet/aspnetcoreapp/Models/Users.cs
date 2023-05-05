public class Users{

    private string _name;

    private string _surname;

    private string _email;
    bool sobaka;
    int sobakaIndex;
    string[] pochtavr = {"gmail.com","mail.ru","","","",};

    
    public string Name{
        get{ return _name;}
        set
        {
            _name = value;
        }
    }
    public string Surname{
        get{ return _surname;}
        set
        {
            _surname = value;
        }
    }
    public string Email{
        get{ return _email;}
        set
        {
            if(value != null)
            {
                for(int i = 0;i < value.Length; i++)
                {
                    if(value[i] == '@')
                    {
                    sobaka = true;
                    sobakaIndex = i;
                    break;
                    }
                }
                
                if(sobaka == true)
                {
                    if(sobakaIndex != 0)
                    {
                        foreach(string p in pochtavr)
                        {
                            if(p.Length < value.Length)
                            {
                                for(int i = 0;i < value.Length; i++)
                                {
                                    if(p == value.Substring(i,i+p.Length))
                                    {

                                    }
                                }
                            }
                        }
                    }
                    
                    _email = value;
                }
            
            }
        }
    }
}