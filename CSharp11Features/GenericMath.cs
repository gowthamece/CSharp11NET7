using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11Features
{
    public class GenericMath
    {
        public T AddAll<T>(T[] values) where T : INumber<T>
        {
            T result = T.Zero;

            foreach (var value in values)
            {
                result += value;
            }
            return result;
        }
    }
}
