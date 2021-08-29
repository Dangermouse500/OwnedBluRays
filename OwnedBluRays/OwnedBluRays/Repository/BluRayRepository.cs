using System.Collections;
using System.Collections.Generic;

namespace OwnedBluRays.Repository
{
    public class BluRayRepository
    {
        public List<BluRay> GetAllOwnedBluRays()
        {
            //TODO get from sql lite db
            //return null;

            var hackList = new List<BluRay>();
            hackList.Add(new BluRay(1, "Rocky", "Sly Stallone", "Sly Stallone", new System.DateTime(1980, 1, 1), "Drama"));
            hackList.Add(new BluRay(1, "Pulp Fiction", "Quentin Tarantino", "John Travolta, Uma Thurman", new System.DateTime(1994, 1, 1), "Comedy"));
            hackList.Add(new BluRay(1, "Inception", "Christopher Nolan", "Leonardo DiCaprio", new System.DateTime(2010, 1, 1), "Thriller"));
            return hackList;
        }

        public ArrayList GetAllOwnedBluRays2()
        {
            //TODO get from sql lite db
            //return null;
            //
            var hackList = new List<BluRay>();
            hackList.Add(new BluRay(1, "Rocky", "Sly Stallone", "Sly Stallone", new System.DateTime(1980, 1, 1), "Drama"));
            hackList.Add(new BluRay(1, "Pulp Fiction", "Quentin Tarantino", "John Travolta, Uma Thurman", new System.DateTime(1994, 1, 1), "Comedy"));
            hackList.Add(new BluRay(1, "Inception", "Christopher Nolan", "Leonardo DiCaprio", new System.DateTime(2010, 1, 1), "Thriller"));

            var arrayListHacked = new ArrayList(hackList);
            return arrayListHacked;
        }

        public List<BluRay> GetAllOwnedBluRaysByGenre()
        {
            //TODO get from sql lite db
            //.Where(g => g.Genre == genre).ToList();
            return null;
        }

        public BluRay GetOwnedBluRayById(int id)
        {
            //TODO get from sql list db
            //return AllOwnedBluRays.FirstOrDefault(i => i.BluRayId == id);
            return null;
        }
    }
}