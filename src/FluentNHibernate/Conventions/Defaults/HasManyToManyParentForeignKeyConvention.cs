using FluentNHibernate.Mapping;
using FluentNHibernate.Conventions;

namespace FluentNHibernate.Conventions.Defaults
{
    public class HasManyToManyParentForeignKeyConvention : IHasManyToManyConvention
    {
        public bool Accept(IManyToManyPart target)
        {
            return string.IsNullOrEmpty(target.ParentKeyColumn);
        }

        public void Apply(IManyToManyPart target)
        {
            target.WithParentKeyColumn(target.ParentType.Name + "_id");
        }
    }
}