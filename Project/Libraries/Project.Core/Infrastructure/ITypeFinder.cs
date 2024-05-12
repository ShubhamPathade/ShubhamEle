using System;
using System.Collections.Generic;
using System.Reflection;

namespace Project.Core.Infrastructure
{
    /// <summary>
    /// Classes implementing this interface provide information about types 
    /// to various services in the project engine.
    /// </summary>
    public interface ITypeFinder
    {
        #region Methods

        IEnumerable<Assembly> GetAssemblies();
        IEnumerable<Type> FindClassesOfType(Type assignTypeFrom, bool onlyConcreateClasses = true);
        IEnumerable<Type> FindClassesOfType(Type assignTypeFrom, IEnumerable<Assembly> assemblies, bool onlyConcreateClasses = true);
        IEnumerable<Type> FindClassesOfType<T>(bool onlyConstreateClasses = true);
        IEnumerable<Type> FindClassesType<T>(IEnumerable<Assembly> assemblies, bool onlyConcreateClasses = true);

        #endregion
    }
}
