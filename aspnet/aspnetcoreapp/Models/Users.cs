public class Users{
    private string _email = "";
    bool pochta = false;
    int sobakaIndex = -2, sobakaCount = 0;
    string[] pochtavr = {"gmail.com","mail.ru","yandex.ru","yahoo.com","outlook.com"};

    public string Email{
        get{ return _email;}
        set
        {
            if(value != null)
            {
                for(int i = 0;i < value.Length; i++)
                {
                    if(value[i].Equals('@'))
                    {
                        sobakaCount += i;

                        if(sobakaIndex == -2)
                        {
                            sobakaIndex = i;
                        }
                        break;
                    }
                }

                if(sobakaCount == 1)
                {
                    foreach(string p in pochtavr)
                    {
                        if(p.Length < value.Length-1)
                        {
                            if(p == value.Substring(sobakaIndex,value.Length))
                            {
                                pochta = true;
                                break;
                            }
                        }
                    }
                    if(pochta)
                    {
                        _email = value;
                    }
                }
            }
        }
    }
}