namespace MVC.Models
{
    public class Socks
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public SockSize Size { get; set; }

        public decimal Price { get; set; }
        public int OnStock {  get; set; }
    }

    public enum SockSize
    {
        S, M, L
    }
    public class SockDataSet
    {
        static string[] brands = ["icebreaker", "adidas", "reebook", "puma"];
        public static IEnumerable<Socks> GetSocks()
        {
            var _socks = Enumerable.Range(1, 5).Select(index =>
            new Socks
            {
                Id = index,
                Brand = brands[Random.Shared.Next(brands.Length)],
                Size = (SockSize)Random.Shared.Next(4),
                Price = (decimal)Random.Shared.Next(50, 500),
                OnStock = Random.Shared.Next(10, 100)
            }).ToArray();
            return _socks;
        }
    }
}
