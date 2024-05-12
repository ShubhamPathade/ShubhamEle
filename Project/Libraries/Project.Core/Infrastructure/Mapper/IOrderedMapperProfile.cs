namespace Project.Core.Infrastructure.Mapper
{
    /// <summary>
    /// Mapper profile registrar interface
    /// </summary>
    public interface IOrderedMapperProfile
    {
        #region Properties

        /// <summary>
        /// Gets order of this configuration implementation
        /// </summary>
        int Order { get; }

        #endregion
    }
}
