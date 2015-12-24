using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public abstract class Vehicle : IPrototype<Vehicle>
    {
        public abstract Vehicle Clone();

        public virtual string Name { set; get; }

        public virtual string Model { set; get; }

        public virtual int TyreCount { get; protected set; }
        
    }
}
