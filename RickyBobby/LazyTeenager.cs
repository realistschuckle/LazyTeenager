namespace RickyBobby
{
    public class LazyTeenager
    {
        public string SayTo(string statement)
        {
            if (statement.EndsWith("?"))
            {
                return "Sure.";
            }
            if (statement.EndsWith("!"))
            {
                return "Whoa, chill out!";
            }
            if (statement == "")
            {
                return "Fine. Be that way!";
            }
            return "Whatever.";
        }
    }
}
