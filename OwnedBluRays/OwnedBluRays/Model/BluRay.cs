using System;

namespace OwnedBluRays
{
    public class BluRay
    {
        public int BluRayId { get; set; }
        public string BluRayTitle { get; set; }
        public string BluRayDirector { get; set; }
        public string BluRayActors { get; set; }
        public DateTime BluRayYearOfRelease { get; set; }
        public string BluRayGenre { get; set; }

        public BluRay(int Id, string title, string director, string actors, DateTime yearOfRelease, string genre)
        {
            BluRayId = Id;
            BluRayTitle = title;
            BluRayDirector = director;
            BluRayActors = actors;
            BluRayYearOfRelease = yearOfRelease;
            BluRayGenre = genre;
        }
    }
}