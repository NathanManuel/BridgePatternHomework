using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.BookContentProvider
{
    public interface IBookContentProvider
    {
          IEnumerable<string> GetBookContent();

    }
}
