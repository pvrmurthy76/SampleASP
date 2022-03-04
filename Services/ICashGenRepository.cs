using CashGen.Entities;

namespace CashGen.Services
{
    public interface ICashGenRepository
    {
        // Methods
        void AddChat(Chat chat);
        void AddEventLog(EventLog line);
        void AddFilter(Filter filter);
        void AddNote(Note note);
        void AddOrder(Order order);
        void AddOrderLine(LineItem line);
        void AddProduct(Product product);
        void AddStore(Store store);
        void AddStoreUser(StoreUser item);
        void AddUser(User user);
        void DeleteFilterCollections(Guid id);
        void DeleteFilterOptions(Guid id);
        void DeleteProduct(Product product);
        void DeleteProductFeatures(Guid id);
        void DeleteProductFilters(Guid id);
        void DeleteProductImages(Guid id);
        void DeleteStore(Store store);
        void DeleteStoreUser(StoreUser item);
        void DeleteUser(User user);
        IEnumerable<Store> GetAccounts();
        IEnumerable<Chat> GetChat(Guid id);
        IEnumerable<Chat> GetChats(Guid id, bool admin);
        Collection GetCollection(Guid id);
        IEnumerable<Filter> GetCollectionFilters(Guid id);
        IEnumerable<Collection> GetCollections(Guid id);
        IEnumerable<Feature> GetFeatures(Guid id);
        Filter GetFilter(Guid id);
        IEnumerable<FilterCollection> GetFilterCollections(Guid id);
        IEnumerable<FilterOption> GetFilterOptions(Guid id);
        IEnumerable<Filter> GetFilters();
        IEnumerable<Image> GetImages(Guid id);
        IEnumerable<LineItem> GetLineItems(Guid id);
        IEnumerable<Note> GetNotes(Guid id);
        Order GetOrder(Guid id);
        IEnumerable<Order> GetOrders();
        Product GetProduct(Guid id);
        IEnumerable<Collection> GetProductCollections(Guid id);
        IEnumerable<ProductFilter> GetProductFilters(Guid id);
        IEnumerable<Product> GetProducts();
        Store GetStore(Guid id);
        IEnumerable<Store> GetStores();
        User GetUser(Guid id);
        User GetUserByEmail(string Emaild);
        User GetUserByResetToken(Guid id);
        User GetUserLogin(string Email, string Password);
        IEnumerable<User> GetUsers();
        IEnumerable<Store> GetUserStores(Guid id);
        void RemoveOrderLines(Guid id);
        bool Save();
        void UpdateFilter(Filter filter);
        void UpdateOrder(Order order);
        void UpdateProduct(Product product);
        void UpdateStore(Store store);
        void UpdateUser(User user);

    }
}
