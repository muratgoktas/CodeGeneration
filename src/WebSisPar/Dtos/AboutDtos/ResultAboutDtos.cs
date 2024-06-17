using System.Security.Principal;

namespace WebSisPar.Dtos.AboutDtos
{
    public class ResultAboutDtos
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string PictureLink01 { get; set; }
        public string PictureLink02 { get; set; }
        public string PictureLink03 { get; set; }
    }
}
