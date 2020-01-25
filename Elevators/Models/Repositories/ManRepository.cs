using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Models
{
    public class ManRepository
    {
        private List<Man> manContext = new List <Man>(20);
        private static int _endIndex = 0;


        public int Add(Man man)
        {
            man.ID = _endIndex;
            _endIndex++;
            manContext.Add(man);
            return man.ID;
        }

        public void Remove(int id)
        {
            manContext.RemoveAll(man => man.ID == id);
        }
    }
}
