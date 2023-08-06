namespace Proje.Domain.Core.Persistance.Repositories;

public interface IEntityTimeStamps
{
    DateTime CreateDate { get; set; }
    DateTime? UpdateDate { get; set; }
    DateTime? DeletedDate { get; set; }
}