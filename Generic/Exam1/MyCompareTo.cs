using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1
{
    public class MyCompareTo
    {
        /// <summary>
        /// Compares the specified reference value.
        /// </summary>
        /// <param name="refValue">The reference value.</param>
        /// <param name="diffValue">The difference value.</param>
        /// <returns></returns>
        public bool Compare(int refValue, int diffValue)
        {
            if (refValue.GetType().IsValueType)
            {
                return (refValue == diffValue);
            }

            return object.Equals(refValue, diffValue);
        }

        /// <summary>
        /// Compares the specified reference value.
        /// </summary>
        /// <param name="refValue">The reference value.</param>
        /// <param name="diffValue">The difference value.</param>
        /// <returns></returns>
        public bool Compare(double refValue, double diffValue)
        {
            if (refValue.GetType().IsValueType)
            {
                return (refValue == diffValue);
            }

            return object.Equals(refValue, diffValue);
        }

        /// <summary>
        /// Compares the specified reference object.
        /// </summary>
        /// <param name="refObj">The reference object.</param>
        /// <param name="diffObj">The difference object.</param>
        /// <returns></returns>
        public bool Compare(string refObj, string diffObj)
        {
            if (refObj.GetType().IsValueType)
            {
                return (refObj == diffObj);
            }

            return object.Equals(refObj, diffObj);
        }


        /// <summary>
        /// 試著用一個泛型方法取代上述的三個 Compare 方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="refObj">The reference object.</param>
        /// <param name="diffObj">The difference object.</param>
        /// <returns>result</returns>
    }
}
