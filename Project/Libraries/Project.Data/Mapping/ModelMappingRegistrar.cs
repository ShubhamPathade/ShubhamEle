using Microsoft.EntityFrameworkCore;
using Project.Core.Domain.SpModels.Common;
using Project.Core.Domain.SpModels.Electrician;
//using Project.Core.Domain.Dashboard;
//using Project.Core.Domain.Orders;
//using Project.Core.Domain.ProcedureModels;
//using Project.Core.Domain.ProcedureModels.PTLOrders;
//using Project.Core.Domain.Ratings;
//using Project.Core.Domain.PTLOrderWeb.CommonWeb;
//using Project.Core.Domain.PTLOrderWeb.ProcedureModelsWeb;

namespace Project.Data.Mapping
{
    public class ModelMappingRegistrar
    {
        public static void Register(ModelBuilder modelBuilder)
        {
            // Total count model
            modelBuilder.Entity<TotalCountModel>(entity =>
            {
                entity.HasNoKey();
            });

            // Electrcian Model
            modelBuilder.Entity<ElectricianSpModel>(entity =>
            {
                entity.HasNoKey();
            });
        }
    }
}
