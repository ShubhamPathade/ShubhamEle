using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Project.Core.Infrastructure
{
    public class AppDomainTypeFinder : ITypeFinder
    {
        #region Fields   

        private string assemblySkipLoadingPattern = "^Microsoft.*|^System.*|^mscorlib|^Microsoft.*|^AutoMapper|^netstandard.*|^Project.Web.Views";

        #endregion

        #region Properties

        public AppDomain App
        {
            get => AppDomain.CurrentDomain;
        }

        public string AssemblySkipLoadingPattern
        {
            get => assemblySkipLoadingPattern;
            set => assemblySkipLoadingPattern = value;
        }

        #endregion

        #region Methods

        public IEnumerable<Type> FindClassesOfType(Type assignTypeFrom, bool onlyConcreateClasses = true)
        {
            return FindClassesOfType(assignTypeFrom, GetAssemblies(), onlyConcreateClasses);
        }

        public IEnumerable<Type> FindClassesOfType(Type assignTypeFrom, IEnumerable<Assembly> assemblies, bool onlyConcreateClasses = true)
        {
            IList<Type> result = new List<Type>();
            if (assemblies != null && assemblies.Any())
            {
                try
                {
                    foreach (var assembly in assemblies)
                    {
                        var types = GetTypes(assembly);
                        if (!types.Any())
                            continue;

                        foreach (var type in types)
                        {
                            if (assignTypeFrom.IsAssignableFrom(type) || (assignTypeFrom.IsGenericTypeDefinition && DoesTypeImplementOpenGeneric(type, assignTypeFrom)))
                            {
                                if (type.IsInterface)
                                    continue;
                                if (onlyConcreateClasses)
                                {
                                    if (type.IsClass && !(type.IsAbstract))
                                    {
                                        result.Add(type);
                                    }
                                }
                                else
                                {
                                    result.Add(type);
                                }
                            }
                        }
                    }
                }
                catch (ReflectionTypeLoadException ex)
                {
                    var msg = string.Empty;
                    foreach (var exception in ex.LoaderExceptions)
                        msg += exception.Message + Environment.NewLine;

                    Debug.WriteLine(msg);
                }
            }
            return result;
        }

        public IEnumerable<Type> FindClassesOfType<T>(bool onlyConstreateClasses = true)
        {
            return FindClassesOfType(typeof(T), onlyConstreateClasses);
        }

        public IEnumerable<Type> FindClassesType<T>(IEnumerable<Assembly> assemblies, bool onlyConcreateClasses = true)
        {
            return FindClassesOfType(typeof(T), assemblies, onlyConcreateClasses);
        }

        public virtual IEnumerable<Assembly> GetAssemblies()
        {
            IList<Assembly> assemblies = new List<Assembly>();
            AddAssembliesInAppDomain(assemblies);
            return assemblies;
        }

        #endregion

        #region Utilities
        private void AddAssembliesInAppDomain(IList<Assembly> assemblies)
        {
            assemblies ??= new List<Assembly>();
            foreach (var assembly in App.GetAssemblies())
            {
                if (!Matches(assembly.FullName))
                    assemblies.Add(assembly);
            }

            #region Testing related

            //Debug.WriteLine("Total : " + assemblies.Count);  //temp
            //foreach (var item in assemblies)
            //{
            //    Debug.WriteLine("Name : " + item.FullName);
            //}

            #endregion
        }

        public virtual bool Matches(string assemblyName)
        {
            return Regex.IsMatch(assemblyName, assemblySkipLoadingPattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
        }

        protected virtual IList<Type> GetTypes(Assembly assembly)
        {
            IList<Type> types = new List<Type>();
            try
            {
                types = assembly.GetTypes();
            }
            catch
            {
                throw;
            }
            return types;
        }

        protected virtual bool DoesTypeImplementOpenGeneric(Type type, Type openGenric)
        {
            try
            {
                Type genericTypeDefination = openGenric.GetGenericTypeDefinition();
                foreach (var implementedInterface in type.FindInterfaces((filer, filterCriteria) => true, null))
                {
                    if (!(implementedInterface.IsGenericType))
                        continue;
                    var isMatch = genericTypeDefination.IsAssignableFrom(implementedInterface.GetGenericTypeDefinition());
                    return isMatch;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}