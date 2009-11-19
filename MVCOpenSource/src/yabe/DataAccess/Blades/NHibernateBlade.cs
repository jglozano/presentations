using MvcTurbine;
using MvcTurbine.Blades;

namespace DataAccess.Blades
{
    public class NHibernateBlade : IBlade
    {
        #region IBlade Members

        public void Dispose()
        {
        }

        public void Initialize(RotorContext context)
        {
        }

        public void Execute(RotorContext context)
        {
            NHConfig.Initialize();
            NHConfig.CreateSessionFactory();
        }

        #endregion
    }
}