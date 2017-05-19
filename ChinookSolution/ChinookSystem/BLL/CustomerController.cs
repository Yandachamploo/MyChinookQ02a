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
    public class CustomerController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<RepresentativeCustomer> RepresentativeCustomer_Get(int employeeId)
        {
            using (var context = new ChinookContext())
            {
                var results = from x in context.Customers
                              where x.SupportRepId == employeeId
                              orderby x.LastName, x.FirstName
                              select new RepresentativeCustomer
                              {
                                  Name = x.LastName + "," + x.FirstName,
                                  City = x.City,
                                  State = x.State,
                                  Phone = x.Phone,
                                  Email = x.Email

                              };
                return results.ToList();
            }
        }
    }
}