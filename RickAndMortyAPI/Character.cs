namespace RickAndMortyAPI.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string Origin { get; set; }
        public string Location { get; set; }
        public string Image { get; set; }
        public int EpisodeId { get; set; }
        public Episode Episode { get; set; }
    }
}
