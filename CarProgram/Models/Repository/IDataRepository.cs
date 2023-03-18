namespace CarProgram.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Update(Car Dbentity, CarModel entity);
        void Delete(TEntity entity);

    }
}
