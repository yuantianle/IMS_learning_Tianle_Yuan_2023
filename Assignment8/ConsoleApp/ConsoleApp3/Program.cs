namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepository<Entity> repository = new GenericRepository<Entity>();

            Entity entity1 = new Entity { Id = 1 };
            Entity entity2 = new Entity { Id = 2 };

            // Add entities
            repository.Add(entity1);
            repository.Add(entity2);

            // Display all entities
            Console.WriteLine("All entities:");
            foreach (Entity entity in repository.GetAll())
            {
                Console.WriteLine($"Id: {entity.Id}");
            }

            // Get an entity by Id
            Entity retrievedEntity = repository.GetById(1);
            Console.WriteLine($"Retrieved entity: Id: {retrievedEntity.Id}");

            // Remove an entity
            repository.Remove(entity1);

            // Display all entities
            Console.WriteLine("All entities after removal:");
            foreach (Entity entity in repository.GetAll())
            {
                Console.WriteLine($"Id: {entity.Id}");
            }
        }

        public interface IRepository<T>
        {
            void Add(T item);
            void Remove(T item);
            void Save();
            IEnumerable<T> GetAll();
            T GetById(int id);
        }
        public class Entity
        {
            public int Id { get; set; }
        }
        public class GenericRepository<T> : IRepository<T> where T : Entity
        {
            private List<T> my_DataSource;

            public GenericRepository()
            {
                my_DataSource = new List<T>();
            }

            public void Add(T item)
            {
                my_DataSource.Add(item);
            }

            public void Remove(T item)
            {
                my_DataSource.Remove(item);
            }

            public void Save()
            {
                // Save data to data source (SQL Server, Oracle, In-Memory, etc.)
            }

            public IEnumerable<T> GetAll()
            {
                return my_DataSource;
            }

            public T GetById(int id)
            {
                return my_DataSource.Find(item => item.Id == id);
            }
        }
    }
}