using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model
{
    abstract class BaseFighterDecorator : IFighter
    {
        public virtual int Lives
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public virtual int AttackValue
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public virtual int DefenseValue
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public virtual void Defend(Attack attack)
        {
            throw new NotImplementedException();
        }

        public virtual Attack Attack()
        {
            throw new NotImplementedException();
        }
    }
}
