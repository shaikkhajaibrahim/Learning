using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class Bus:Vehicle
    {
        private int tyres = 8;

        /// <summary>
        /// Clone
        /// </summary>
        /// <returns></returns>
        public override Vehicle Clone()
        {
            return this.MemberwiseClone() as Vehicle;
        }

        public override int TyreCount
        {
            get
            {
                return tyres;
            }
            protected set
            {
                tyres = value;
            }
        }
    }
}
