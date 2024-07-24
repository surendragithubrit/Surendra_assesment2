namespace Assesment2
{
    internal class Book
    {
        public int BookId {  get; set; }
        public string BookName {  get; set; }
        public int Price {  get; set; }
        public string Author {  get; set; }
        public string Publisher { get; set; }

        public override string ToString()
        {
            return $"BookId={BookId} BookName={BookName} Price={Price} Author={Author} Publisher={Publisher}";
        }
        static void Main(string[] args)
        {
            Book book = new Book();
        }
    }
}
