using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_DataBindingsec1.Data
{
    public interface IFriendDataService
    {
        IEnumerable<Friend> GetAll();
    }
}
