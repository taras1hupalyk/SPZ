using First;
using SPZ.BusinessLogic.Services.Interfaces;

namespace SPZ.BusinessLogic.Services
{
    public class AliasesService : IAliasesService
    {
        private readonly PSCommandHandler _commandHandler;

        public AliasesService()
        {
            _commandHandler = new PSCommandHandler();
        }

        public IEnumerable<string> GetAllAliases()
        {
            return _commandHandler.GetAliases();
        }

        public IEnumerable<string> GetAlliasesWithCertainLength(int length)
        {
            return _commandHandler.GetAliases().Where(x => x.Length == length);
        }
    }
}