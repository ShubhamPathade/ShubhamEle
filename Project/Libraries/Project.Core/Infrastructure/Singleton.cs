namespace Project.Core.Infrastructure
{
    public class Singleton<T> : BaseSingleton
    {
        #region Fields

        private static T _instance;

        #endregion

        #region Properties

        public static T Instance
        {
            get => _instance;
            set
            {
                _instance = value;
                AllSingletons[typeof(T)] = value;
            }
        }

        #endregion
    }
}
