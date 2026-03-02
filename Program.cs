using System;
using System.Collections.Generic;

namespace DVA222_Labb5 
{
   class Program {
      static void Main() {
         IVisitable t = new Mul(new Literal(7), new Add(new Literal(3), new Literal(4)));
         Console.WriteLine(new Stringifier(t)+"="+new Evaluator(t));
      }
   }
}
