namespace RestApiDrill.Models
//basic model for a basketball player with the following properties: Id, Name, Number, Position, TeamId, BasketballTeam
{
    public class BasketballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Position { get; set; }
        public int TeamId { get; set; }
        public string BasketballTeam { get; set; }
    }
}