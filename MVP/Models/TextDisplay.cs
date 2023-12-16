namespace MVP.Models
{
    public class TextDisplay : ITextDisplay
    {
        public string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray); 
        }
    }
}
