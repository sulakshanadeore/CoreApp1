namespace CoreApp1.Models
{
    public interface IFirst
    {
        string greet();
    }

   public class Greeting : IFirst
    {
        public string greet()
        {
            return "Good day!!!";
        }
    }
}
