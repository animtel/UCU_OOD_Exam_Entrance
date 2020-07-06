using System;
using System.Collections.Generic;
using System.Text;

namespace UCU_OOD_Exam._2016._2016._1
{
    public class _2016_1_Startup
    {
        public void Start()
        {
            var True = new True();
            var False = new False();

            var TrueAndFalse = True.and(False).ToString();
            var TrueAndTrue = True.and(True).ToString();
            var FalseAndTrue = False.and(True).ToString();
            var FalseAndFalse = False.and(False).ToString();
            var TrueAndTrueAndFalse = True.and(True).and(False).ToString();
            var TrueAndTrueAndTrue = True.and(True).and(True).ToString();

            Console.WriteLine(TrueAndFalse);
            Console.WriteLine(TrueAndTrue);
            Console.WriteLine(FalseAndTrue);
            Console.WriteLine(FalseAndFalse);
            Console.WriteLine(TrueAndTrueAndFalse);
            Console.WriteLine(TrueAndTrueAndTrue);
        }
    }
}
