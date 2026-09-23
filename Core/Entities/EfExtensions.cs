using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microsoft.EntityFrameworkCore
{
    public static class EfExtensions
    {
        // 聚集索引（IsClustered）擴充方法
        public static KeyBuilder IsClustered(this KeyBuilder builder, bool clustered = true) => builder;
        public static IndexBuilder IsClustered(this IndexBuilder builder, bool clustered = true) => builder;
        public static IndexBuilder<TEntity> IsClustered<TEntity>(this IndexBuilder<TEntity> builder, bool clustered = true) => builder;

        // 預設值 SQL（HasDefaultValueSql）雙引數擴充方法
        public static PropertyBuilder HasDefaultValueSql(this PropertyBuilder builder, string? sql, string? name)
        {
            return builder.HasDefaultValueSql(sql);
        }

        public static PropertyBuilder<TProperty> HasDefaultValueSql<TProperty>(this PropertyBuilder<TProperty> builder, string? sql, string? name)
        {
            return builder.HasDefaultValueSql(sql);
        }
    }
}