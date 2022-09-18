using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Lab1
{
    public class Domino
    {
        private DominoValues Value1;
        private DominoValues Value2;

        private bool Value1Can = false;
        private bool Value2Can = false;
        public Domino()
        {
            Random random = new Random();
            Value1 = (DominoValues)random.Next(0, 6);
            Value2 = (DominoValues)random.Next(0, 6);
        }
        public Domino(DominoValues value1, DominoValues value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
        public void ReturnDominoValues(ref int one, ref int two)
        {
            one = (int)Value1;
            two = (int)Value2;
        }

        public string ReturnDominoValuesString()
        {
            return $"({(int)Value1}; {(int)Value2})";
        }

        public bool MakeTurn(Domino domino)
        {
            if(domino.Value1 == Value1 && !Value1Can)
            {
                Value1Can = true;
                domino.Value1Can = true;
                return true;
            }
            else if(domino.Value2 == Value2 && !Value2Can)
            {
                Value2Can = true;
                domino.Value2Can = true;
                return true;
            }
            return false;
        }
    }


    public enum DominoValues
    {
        none,
        one,
        two,
        three,
        four,
        five,
        six
    }


}
