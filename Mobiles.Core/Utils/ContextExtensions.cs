using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Mobiles.Core.Utils
{
    public static class ContextExtensions
    {
        public static EntityEntry<T> Upsert<T>(this DbContext context, T entity) where T : class
        {
            try
            {
                return context.Add(entity);
            }
            catch (InvalidOperationException)
            {
                //var found = context.Find(typeof(T), typeof(T).GetProperty("Id")?.GetValue(entity));
                //if (found is not null)
                //{
                //    var entry = context.Entry(found);
                //    entry.CurrentValues.SetValues(entity);
                //    context.Update(entry);
                //}
                context.Attach(entity);
                return context.Update(entity);
            }
        }
    }
}
