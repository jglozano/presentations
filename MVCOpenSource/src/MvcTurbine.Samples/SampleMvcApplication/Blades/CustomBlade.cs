using System;
using MvcTurbine.ComponentModel;

namespace SampleMvcApplication.Blades {
    using MvcTurbine;
    using MvcTurbine.Blades;

    public class CustomBlade : IBlade, ISupportAutoRegistration {
        public ILogger Logger { get; set; }
        #region IBlade Members

        public void Initialize(RotorContext context) {
        }

        public void Execute(RotorContext context) {
            int i = 0;
        }

        #endregion

        public void Dispose() {

        }

        public void AddRegistrations(AutoRegistrationTable registrationTable) {
            registrationTable.AddRegistration<ILogger>(RegistrationHelper.SimpleRegistration<ILogger>);
        }
    }

    public class Logger : ILogger {
        public void LogMessage(string message) {
            throw new NotImplementedException();
        }
    }
    public interface ILogger {
        void LogMessage(string message);
    }
}