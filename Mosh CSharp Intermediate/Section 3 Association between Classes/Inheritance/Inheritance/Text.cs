namespace Inheritance
{
    public class Text : PersentationObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }

        public void AddHyperLink(string url)
        {
            System.Console.WriteLine("We added a link to " + url);
        }
    }
}
