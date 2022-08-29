namespace SPZ.BusinessLogic.Services.Interfaces
{
    public interface IAliasesService
    {
        IEnumerable<string> GetAlliasesWithCertainLength(int length);
        IEnumerable<string> GetAllAliases();
    }
}