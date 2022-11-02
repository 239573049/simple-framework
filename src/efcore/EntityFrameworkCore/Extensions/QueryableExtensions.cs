using System;
using System.Linq;
using System.Linq.Expressions;

namespace EntityFrameworkCore.Extensions;

public static class QueryableExtensions
{
    public static IQueryable<T> PageBy<T>(
        this IQueryable<T> query,
        int skipCount,
        int maxResultCount)
    {
        return Queryable.Take<T>(Queryable.Skip<T>(query, skipCount), maxResultCount);
    }

    public static TQueryable PageBy<T, TQueryable>(
        this TQueryable query,
        int skipCount,
        int maxResultCount)
        where TQueryable : IQueryable<T>
    {
        return (TQueryable)Queryable.Take<T>(Queryable.Skip<T>(query, skipCount), maxResultCount);
    }

    public static IQueryable<T> WhereIf<T>(
        this IQueryable<T> query,
        bool condition,
        Expression<Func<T, bool>> predicate)
    {
        return !condition ? query : query.Where<T>(predicate);
    }

    public static TQueryable WhereIf<T, TQueryable>(
        this TQueryable query,
        bool condition,
        Expression<Func<T, bool>> predicate)
        where TQueryable : IQueryable<T>
    {
        return !condition ? query : (TQueryable)query.Where<T>(predicate);
    }

    public static IQueryable<T> WhereIf<T>(
        this IQueryable<T> query,
        bool condition,
        Expression<Func<T, int, bool>> predicate)
    {
        return !condition ? query : query.Where<T>(predicate);
    }

    public static TQueryable WhereIf<T, TQueryable>(
        this TQueryable query,
        bool condition,
        Expression<Func<T, int, bool>> predicate)
        where TQueryable : IQueryable<T>
    {
        return !condition ? query : (TQueryable)query.Where<T>(predicate);
    }

}