using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel;
using ChinookSystem.Data.Entities;
using ChinookSystem.DAL;
using ChinookSystem.Data.POCOs;//needed for AlbumArtist.cs
#endregion

namespace ChinookSystem.BLL
{
    [DataObject]
    public class ArtistController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Artist> Artist_ListAll()
        {
            using (var context = new ChinookContext())
            {
                return context.Artists.ToList();
            }
        }//eom
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<ArtistAlbum> ArtistAlbums_Get(int year)
        {
            using (var context = new ChinookContext())
            {
                var results = from x in context.Albums
                              where x.ReleaseYear == year
                              orderby x.Artist.Name, x.Title
                              select new ArtistAlbum
                              {
                                  Name = x.Artist.Name,
                                  Title = x.Title

                              };
                return results.ToList();
            }
        }//eom
    }//eoc
}//eon
