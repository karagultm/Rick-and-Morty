namespace RickAndMortyAPI.Models // Uygun namespace
{
    public class Episode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AirDate { get; set; }
        public string EpisodeCode { get; set; }
        public ICollection<Character> Characters { get; set; }
    }
}
