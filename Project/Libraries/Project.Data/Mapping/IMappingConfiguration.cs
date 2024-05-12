using Microsoft.EntityFrameworkCore;

namespace Project.Data.Mapping
{
    public interface IMappingConfiguration
    {
        #region Methods

        void ApplyConfiguration(ModelBuilder modelBuilder);

        #endregion
    }
}
