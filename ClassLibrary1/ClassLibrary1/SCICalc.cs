using System;
using System.Collections.Generic;
using System.Text;



namespace com.vm
{
    public class SCICalc : Calc
    {
        public SCICalc()
        {

        }

        public int SciAdd(int a, int b)
        {
            //This is derieved class add
            return base.Add(a, b);

        }
    }
}
