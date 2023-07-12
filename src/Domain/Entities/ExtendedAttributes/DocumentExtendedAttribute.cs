using SampleApp.Domain.Contracts;
using SampleApp.Domain.Entities.Misc;

namespace SampleApp.Domain.Entities.ExtendedAttributes
{
    public class DocumentExtendedAttribute : AuditableEntityExtendedAttribute<int, int, Document>
    {
    }
}