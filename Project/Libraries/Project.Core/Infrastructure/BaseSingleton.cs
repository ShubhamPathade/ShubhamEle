using System;
using System.Collections.Generic;

namespace Project.Core.Infrastructure
{
    public class BaseSingleton
    {
        #region Constructor

        static BaseSingleton()
        {
            AllSingletons = new Dictionary<Type, object>();
        }

        #endregion

        #region Properties

        public static IDictionary<Type, object> AllSingletons { get; }

        #endregion
    }
}
