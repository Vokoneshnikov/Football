class Program
{
    static void Main(string[] args)
    {
        Footballer Edik = new Footballer("Eduard", "Mursalimov");
        Referee referee = new Referee("Referee of RFPL");
        Fan fan = new Fan("FC Slonyary");
        Edik.Score();
        fan.SaySpeech();
        Edik.ShowStatistics();
        referee.ShowCard(Edik);
        Edik.ShowStatistics();
    }
}