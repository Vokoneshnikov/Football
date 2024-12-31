interface ISpeakable
{ 
    public void SaySpeech();
}

public abstract class FootballMatchParticipant : ISpeakable
{
    public abstract void SaySpeech();
    public abstract void ShowStatistics();

}

public class Footballer : FootballMatchParticipant
{
    public override void SaySpeech()
    {
        throw new NotImplementedException();
    }

    public override void ShowStatistics()
    {
        throw new NotImplementedException();
    }
}
abstract class VoiceAssistant : ISpeakable
{
    public abstract void SaySpeech();
}



class Program
{
    static void Main(string[] args)
    {
        FootballMatchParticipant participant = new FootballMatchParticipant();
        
        
        
        
        
    }
}