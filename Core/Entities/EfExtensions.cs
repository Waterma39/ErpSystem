using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microsoft.EntityFrameworkCore
{
    public static class EfExtensions
    {
        public static KeyBuilder IsClustered(this KeyBuilder builder, bool clustered = true) => builder;
        public static IndexBuilder IsClustered(this IndexBuilder builder, bool clustered = true) => builder;
        public static IndexBuilder<TEntity> IsClustered<TEntity>(this IndexBuilder<TEntity> builder, bool clustered = true) => builder;
    }
}