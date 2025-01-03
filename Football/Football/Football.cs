interface ISpeakable
{
    public void SaySpeech();
}

abstract class FootballMatchParticipant : ISpeakable
{
    public abstract void ShowStatistics();

    public virtual void SaySpeech()
    {
        
    }
    
}

class Footballer : FootballMatchParticipant
{
    public Footballer(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }
    public Footballer(string firstName, string lastName, int goalsAmount, int cardsAmount)
    {
        _firstName = firstName;
        _lastName = lastName;
        _goalsAmount = goalsAmount;
        _cardsAmount = cardsAmount;
    }
    public override void ShowStatistics()
    {
        Console.WriteLine($"{_firstName} {_lastName}:");
        Console.WriteLine();
        Console.WriteLine($"Забито голов: {_goalsAmount}");
        Console.WriteLine($"Получено желтых карточек:{_cardsAmount}");
        Console.WriteLine();
    }

    public override void SaySpeech()
    {
        Console.WriteLine($"\"ГОООООООЛ!\" - {_firstName} {_lastName}");
        Console.WriteLine();
    }

    public void Score()
    {
        _goalsAmount += 1;
        SaySpeech();
    }

    private string _firstName;
    public string FirstName {get { return _firstName; }}
    
    private string _lastName;
    public string LastName {get { return _lastName; }}
    
    private int _cardsAmount = 0;
    public int CardsAmount {get { return _cardsAmount; } set{_cardsAmount = value; } }
    
    private int _goalsAmount = 0;
    public int GoalsAmount {get { return _goalsAmount; }set{_goalsAmount = value; } }
    
}

class Referee : FootballMatchParticipant
{
    public Referee(string name)
    {
        _name = name;
    }
    public override void ShowStatistics()
    {
        Console.WriteLine($"Показано желтых карточек: {_showedCardsAmount}");
    }
    public override void SaySpeech()
    {
        Console.WriteLine($"{_name}:");
        Console.WriteLine("Показана желтая карточка");
        Console.WriteLine();
    }
    public void ShowCard(Footballer footballer)
    {
        _showedCardsAmount += 1;
        footballer.CardsAmount += 1;
        SaySpeech();
    }
    private int _showedCardsAmount = 0;
    public int ShowedCardsAmount {get { return _showedCardsAmount; }set{_showedCardsAmount = value; } }
    private string _name;
    public string Name {get { return _name; }}

}

class Fan : FootballMatchParticipant
{
    public Fan(string supportedTeamName)
    {
        _supportedTeamName = supportedTeamName;
    }
    public override void ShowStatistics()
    {
        Console.WriteLine($"Выкрикнуто кричалок: {_chantsAmount}");
    }

    public override void SaySpeech()
    {
        Console.WriteLine($"Болельщик {_supportedTeamName}:");
        Console.WriteLine($"Вперед, {_supportedTeamName}!!!!!");
        _chantsAmount += 1;
    }

    private string _supportedTeamName;
    public string SupportedTeamName {get { return _supportedTeamName;} set{_supportedTeamName = value; } }
    private int _chantsAmount = 0;
    public int ChantsAmount {get { return _chantsAmount; }set{_chantsAmount = value; } }
    
}