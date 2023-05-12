public class Questionnaire
{
    private Dictionary<string, bool> _languages_learned = new Dictionary<string, bool>
    {
        { "python", false },
        { "c++", false },
        { "c#", false },
        { "java", false },
        { "html css javascript", false },
    };
    private Dictionary<string, bool> _languages_wants_to_learn = new Dictionary<string, bool>
    {
        { "python", false },
        { "c++", false },
        { "c#", false },
        { "java", false },
        { "html css javascript", false },
    };

    public int Id { get; set; }
    public int UserId { get; set; }
    public uint Age { get; set; }
    public bool HighEducation { get; set; }
    public float EducationTimePerDay { get; set; }
    public float EducationAllTime { get; set; }

    public void SetLanguageToLearn(string language, bool wantsToLearn)
    {
        if (_languages_wants_to_learn.ContainsKey(language))
            _languages_wants_to_learn[language] = wantsToLearn;
        else
            System.Console.WriteLine("This language does not exist");
    }

    public void SetLanguageLearned(string language, bool learned)
    {
        if (_languages_learned.ContainsKey(language))
            _languages_learned[language] = learned;
        else
            System.Console.WriteLine("This language does not exist");
    }
}