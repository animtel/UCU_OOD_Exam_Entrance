using System;
using System.Collections.Generic;
using System.Text;

namespace UCU_OOD_Exam._2016._2016._1
{
    public class Boolean
    {
        public Boolean and(Boolean anotherBool)
        {
            return anotherBool;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    public class True: Boolean
    {
        public Boolean and(Boolean anotherBool)
        {
            return anotherBool;
        }
    }

    public class False: Boolean
    {
        public Boolean and(Boolean anotherBool)
        {
            return this;
        }
    }
}
