using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Homework_19
{
    /// <summary>
    /// 
    /// </summary>
    class RepositoryAnimal
    {
        List<IFauna> fauna;
        public RepositoryAnimal()
        {
            fauna = new List<IFauna>();
        }
        public RepositoryAnimal(IEnumerable<IFauna> Args)
        {
            fauna = Args.ToList<IFauna>();
        }
        public void Add(IFauna NewFauna)
        {
            fauna.Add(NewFauna);
        }
        public List<IFauna> PrintRepository()
        {
            return fauna;
        }
    }
}
