using AutoMapper;

namespace Project.Core.Infrastructure.Mapper
{
    /// <summary>
    /// AutoMapper configuration
    /// </summary>
    public static class AutoMapperConfiguration
    {
        #region Properties

        /// <summary>
        /// Mapper
        /// </summary>
        public static IMapper Mapper { get; private set; }

        /// <summary>
        /// Mapper configuration
        /// </summary>
        public static MapperConfiguration MapperConfiguration { get; private set; }

        #endregion

        #region Methods

        /// <summary>
        /// Initialize mapper
        /// </summary>
        /// <param name="config">Mapper configuration</param>
        public static void Init(MapperConfiguration config)
        {
            MapperConfiguration = config;
            Mapper = config.CreateMapper();
        }

        #endregion
    }
}
