using VehicleRegistrationSystem.DAL.Context;

namespace VehicleRegistrationSystem.DAL.Repository
{
    public class RepositoryBase
    {
        protected static DatabaseContext Context;
        protected static object LockSync = new object();

        protected RepositoryBase()
        {
            CreateContext();
        }

        private static void CreateContext()
        {
            if (Context == null)
            {
                lock (LockSync)
                {
                    if (Context == null)
                    {
                        Context = new DatabaseContext();
                    }
                }
            }
        }
    }
}