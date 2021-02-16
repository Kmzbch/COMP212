using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_DataBindingsec1.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            // TODO: Load data from real database
            yield return new Friend { FirstName = "Alice", LastName="Amber" };
            yield return new Friend { FirstName = "Bob", LastName="Bobson" };
            yield return new Friend { FirstName = "Cecil", LastName = "Coriandar" };
        }
    }
}
