public class Questionnaire
{
    //private int _id;
    //private uint _age;
    //private bool _high_education;
    //private float _education_time_per_day;
    //private float _education_all_time;
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
    public uint Age { get; set; }
    public bool HighEducation { get; set; }
    public float EducationTimePerDay { get; set; }
    public float EducationAllTime { get; set; }
}