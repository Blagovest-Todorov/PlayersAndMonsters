namespace PlayersAndMonsters
{
    public class Hero
    {
        public Hero(string username, int level)
        {
            Username = username;
            Level = level;
        }

        public string Username { get; set; }
        public int Level { get; set; }

        public sealed override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        } //sealed method is method closed/blocked for overridings into the child class, 
        //sealed prohibits the down hierachies to override the method
        // sealed prohibits from a given level down the hierarchy a given method
        // to be overriden-changed the behavior
    }
}
