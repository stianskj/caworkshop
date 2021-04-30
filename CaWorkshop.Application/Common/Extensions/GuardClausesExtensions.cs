using CaWorkshop.Application.Common.Exceptions;

namespace Ardalis.GuardClauses
{
    public static class GuardClausesExtensions
    {
        public static T NotFound<T>(this IGuardClause guardClause, T input, object key)
        {
            if (input is null)
            {
                throw new NotFoundException(typeof(T).Name, key);
            }
            return input;
        }
    }
}