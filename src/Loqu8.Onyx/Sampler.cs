using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loqu8.Onyx
{
    public class Sampler
    {
        public Guid NewId
        {
            get
            {
                return Guid.NewGuid();
            }
        }
    }
}
