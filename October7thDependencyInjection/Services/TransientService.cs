using System;
namespace October7thDependencyInjection.Services
{
    public interface ITransientService : IScopedService
    {
    }
    public class TransientService : ITransientService
    {
        private string _guid;
        public TransientService()
        {
            _guid = Guid.NewGuid().ToString();
        }
        public string GetGuid()
        {
            return _guid;
        }
    }
}
