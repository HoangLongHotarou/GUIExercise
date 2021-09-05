using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theory2.Models;

namespace Theory2.IO
{
    public interface INewsRepository
    {
        List<Publisher> GetNews();
        void Save(List<Publisher> publishers);
    }
}