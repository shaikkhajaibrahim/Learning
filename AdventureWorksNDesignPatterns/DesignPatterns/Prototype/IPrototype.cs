using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public interface IPrototype<T>
    {
        /// <summary>
        /// This method will be used to clone
        /// </summary>
        /// <returns></returns>
        T Clone();
    }
}
