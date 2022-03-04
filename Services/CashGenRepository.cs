using CashGen.DBContexts;
using CashGen.Entities;
using System.Linq.Expressions;
using System.Reflection;

namespace CashGen.Services
{
    public class CashGenRepository:ICashGenRepository, IDisposable
    {
        // Fields
        private readonly CashGenContext _context;

        // Methods
        public CashGenRepository(CashGenContext context)
        {
            if (context == null)
            {
                CashGenContext local1 = context;
                throw new ArgumentNullException("context");
            }
            this._context = context;
        }

        public void AddChat(Chat chat)
        {
            this._context.Chats.Add(chat);
        }

        public void AddEventLog(EventLog line)
        {
            this._context.EventLogs.Add(line);
        }

        public void AddFilter(Filter filter)
        {
            if (filter == null)
            {
                throw new ArgumentNullException("filter");
            }
            this._context.Filters.Add(filter);
        }

        public void AddNote(Note note)
        {
            if (note == null)
            {
                throw new ArgumentNullException("note");
            }
            this._context.Notes.Add(note);
        }

        public void AddOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException("order");
            }
            this._context.Orders.Add(order);
        }

        public void AddOrderLine(LineItem line)
        {
            this._context.LineItems.Add(line);
        }

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("product");
            }
            this._context.Products.Add(product);
        }

        public void AddStore(Store store)
        {
            if (store == null)
            {
                throw new ArgumentNullException("store");
            }
            this._context.Stores.Add(store);
        }

        public void AddStoreUser(StoreUser item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            this._context.StoreUsers.Add(item);
        }

        public void AddUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }
            this._context.Users.Add(user);
        }

        public void DeleteFilterCollections(Guid id)
        {
            ParameterExpression expression = Expression.Parameter((Type)typeof(FilterCollection), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            foreach (FilterCollection filters in Enumerable.ToList<FilterCollection>((IEnumerable<FilterCollection>)Queryable.Where<FilterCollection>(this._context.FilterCollections, Expression.Lambda<Func<FilterCollection, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, methodof(FilterCollection.get_FilterId) as MethodInfo), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass26_0)), fieldof(<> c__DisplayClass26_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1))))
            {
                this._context.FilterCollections.Remove(filters);
            }
        }

        public void DeleteFilterOptions(Guid id)
        {
        <> c__DisplayClass25_0 class_;
            ParameterExpression expression = Expression.Parameter((Type)typeof(FilterOption), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            foreach (FilterOption option in Enumerable.ToList<FilterOption>((IEnumerable<FilterOption>)Queryable.Where<FilterOption>(this._context.FilterOptions, Expression.Lambda<Func<FilterOption, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(FilterOption.get_FilterId)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass25_0)), fieldof(<> c__DisplayClass25_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1))))
        {
                this._context.FilterOptions.Remove(option);
            }
        }

        public void DeleteProduct(Product product)
        {
            this._context.Products.Remove(product);
        }

        public void DeleteProductFeatures(Guid id)
        {
        <> c__DisplayClass18_0 class_;
            ParameterExpression expression = Expression.Parameter((Type)typeof(Feature), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            foreach (Feature feature in Enumerable.ToList<Feature>((IEnumerable<Feature>)Queryable.Where<Feature>(this._context.Features, Expression.Lambda<Func<Feature, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Feature.get_ProductId)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass18_0)), fieldof(<> c__DisplayClass18_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1))))
        {
                this._context.Features.Remove(feature);
            }
        }

        public void DeleteProductFilters(Guid id)
        {
        <> c__DisplayClass27_0 class_;
            ParameterExpression expression = Expression.Parameter((Type)typeof(ProductFilter), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            foreach (ProductFilter filter in Enumerable.ToList<ProductFilter>((IEnumerable<ProductFilter>)Queryable.Where<ProductFilter>(this._context.ProductFilters, Expression.Lambda<Func<ProductFilter, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(ProductFilter.get_ProductId)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass27_0)), fieldof(<> c__DisplayClass27_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1))))
        {
                this._context.ProductFilters.Remove(filter);
            }
        }

        public void DeleteProductImages(Guid id)
        {
        <> c__DisplayClass17_0 class_;
            ParameterExpression expression = Expression.Parameter((Type)typeof(Image), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            foreach (Image image in Enumerable.ToList<Image>((IEnumerable<Image>)Queryable.Where<Image>(this._context.Images, Expression.Lambda<Func<Image, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Image.get_ProductId)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass17_0)), fieldof(<> c__DisplayClass17_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1))))
        {
                this._context.Images.Remove(image);
            }
        }

        public void DeleteStore(Store store)
        {
            this._context.Stores.Remove(store);
        }

        public void DeleteStoreUser(StoreUser item)
        {
            this._context.StoreUsers.Remove(item);
        }

        public void DeleteUser(User user)
        {
            this._context.Users.Remove(user);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            bool flag1 = disposing;
        }

        public IEnumerable<Store> GetAccounts()
        {
            List<Store> list1 = new List<Store>();
            ParameterExpression expression = Expression.Parameter((Type)typeof(Store), "c");
            Expression[] expressionArray1 = new Expression[] { (Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Store.get_GroupName)) };
            ParameterExpression[] expressionArray2 = new ParameterExpression[] { expression };
            return (IEnumerable<Store>)Enumerable.ToList<Store>((IEnumerable<Store>)Queryable.OrderBy<Store, string>(this._context.Stores, Expression.Lambda<Func<Store, string>>((Expression)Expression.Condition((Expression)Expression.Not((Expression)Expression.Call(null, (MethodInfo)methodof(string.IsNullOrEmpty), expressionArray1)), (Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Store.get_GroupName)), (Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Store.get_Title))), expressionArray2)));
        }

        public IEnumerable<Chat> GetChat(Guid id)
        {
        <> c__DisplayClass6_0 class_;
            ParameterExpression expression = Expression.Parameter((Type)typeof(Chat), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            IQueryable<Chat> queryable1 = Queryable.Where<Chat>(this._context.Chats, Expression.Lambda<Func<Chat, bool>>((Expression)Expression.OrElse((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Chat.get_Id)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass6_0)), fieldof(<> c__DisplayClass6_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), (Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Chat.get_ParentId)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass6_0)), fieldof(<> c__DisplayClass6_0.id)), false, (MethodInfo)methodof(Guid.op_Equality))), expressionArray1));
            expression = Expression.Parameter((Type)typeof(Chat), "c");
            ParameterExpression[] expressionArray2 = new ParameterExpression[] { expression };
            return (IEnumerable<Chat>)Enumerable.ToList<Chat>((IEnumerable<Chat>)Queryable.OrderBy<Chat, DateTime>(queryable1, Expression.Lambda<Func<Chat, DateTime>>((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Chat.get_MessageDate)), expressionArray2)));
        }

        public IEnumerable<Chat> GetChats(Guid id, bool admin)
        {
        <> c__DisplayClass7_0 class_;
            ParameterExpression expression = Expression.Parameter((Type)typeof(Chat), "c");
            Expression[] expressionArray1 = new Expression[] { (Expression)Expression.Constant("00000000-0000-0000-0000-000000000000", (Type)typeof(string)) };
            ParameterExpression[] expressionArray2 = new ParameterExpression[] { expression };
            IQueryable<Chat> queryable1 = Queryable.Where<Chat>(this._context.Chats, Expression.Lambda<Func<Chat, bool>>((Expression)Expression.AndAlso((Expression)Expression.OrElse((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Chat.get_StoreId)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass7_0)), fieldof(<> c__DisplayClass7_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), (Expression)Expression.Equal((Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass7_0)), fieldof(<> c__DisplayClass7_0.admin)), (Expression)Expression.Constant((bool)true, (Type)typeof(bool)))), (Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Chat.get_ParentId)), (Expression)Expression.New((ConstructorInfo)methodof(Guid..ctor), expressionArray1), false, (MethodInfo)methodof(Guid.op_Equality))), expressionArray2));
            expression = Expression.Parameter((Type)typeof(Chat), "c");
            ParameterExpression[] expressionArray3 = new ParameterExpression[] { expression };
            return (IEnumerable<Chat>)Enumerable.ToList<Chat>((IEnumerable<Chat>)Queryable.Take<Chat>((IQueryable<Chat>)Queryable.OrderByDescending<Chat, DateTime>(queryable1, Expression.Lambda<Func<Chat, DateTime>>((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Chat.get_MessageDate)), expressionArray3)), 100));
        }

        public Collection GetCollection(Guid id)
        {
        <> c__DisplayClass11_0 class_;
            if (id == Guid.Empty)
            {
                Collection collection1 = new Collection();
                collection1.Title = "All Collections";
                collection1.Id = Guid.Empty;
                return collection1;
            }
            ParameterExpression expression = Expression.Parameter((Type)typeof(Collection), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            return Queryable.FirstOrDefault<Collection>(Queryable.Where<Collection>(this._context.Collections, Expression.Lambda<Func<Collection, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Collection.get_Id)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass11_0)), fieldof(<> c__DisplayClass11_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1)));
        }

        public IEnumerable<Filter> GetCollectionFilters(Guid id)
        {
        <> c__DisplayClass37_0 class_;
            Guid item = new Guid("00000000-0000-0000-0000-000000000000");
            List<Guid> list1 = new List<Guid>();
            list1.Add(item);
            list1.Add(id);
            List<Guid> listOfCollections = list1;
            ParameterExpression expression = Expression.Parameter((Type)typeof(Collection), "p");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            Collection collection = Queryable.FirstOrDefault<Collection>(Queryable.Where<Collection>(this._context.Collections, Expression.Lambda<Func<Collection, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Collection.get_Id)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass37_0)), fieldof(<> c__DisplayClass37_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1)));
            if ((collection != null) && (collection.ParentId != item))
            {
                listOfCollections.Add(collection.ParentId);
                expression = Expression.Parameter((Type)typeof(Collection), "p");
                ParameterExpression[] expressionArray2 = new ParameterExpression[] { expression };
                Collection collection = Queryable.FirstOrDefault<Collection>(Queryable.Where<Collection>(this._context.Collections, Expression.Lambda<Func<Collection, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Collection.get_Id)), (Expression)Expression.Property((Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass37_0)), fieldof(<> c__DisplayClass37_0.collection)), (MethodInfo)methodof(Collection.get_ParentId)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray2)));
                if (collection.ParentId != item)
                {
                    listOfCollections.Add(collection.ParentId);
                }
            }
            expression = Expression.Parameter((Type)typeof(Filter), "p");
            Expression[] expressionArray3 = new Expression[2];
            expressionArray3[0] = (Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Filter.get_Collections));
            ParameterExpression expression2 = Expression.Parameter((Type)typeof(FilterCollection), "x");
            Expression[] expressionArray4 = new Expression[] { (Expression)Expression.Property((Expression)expression2, (MethodInfo)methodof(FilterCollection.get_CollectionId)) };
            ParameterExpression[] expressionArray5 = new ParameterExpression[] { expression2 };
            expressionArray3[1] = (Expression)Expression.Lambda<Func<FilterCollection, bool>>((Expression)Expression.Call((Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass37_0)), fieldof(<> c__DisplayClass37_0.listOfCollections)), (MethodInfo)methodof(List<Guid>.Contains, List<Guid>), expressionArray4), expressionArray5);
            ParameterExpression[] expressionArray6 = new ParameterExpression[] { expression };
            return (IEnumerable<Filter>)Enumerable.ToList<Filter>((IEnumerable<Filter>)Queryable.Where<Filter>(this._context.Filters, Expression.Lambda<Func<Filter, bool>>((Expression)Expression.Call(null, (MethodInfo)methodof(Enumerable.Any), expressionArray3), expressionArray6)));
        }

        public IEnumerable<Collection> GetCollections(Guid id)
        {
        <> c__DisplayClass24_0 class_;
            ParameterExpression expression = Expression.Parameter((Type)typeof(Collection), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            IQueryable<Collection> queryable1 = Queryable.Where<Collection>(this._context.Collections, Expression.Lambda<Func<Collection, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Collection.get_ParentId)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass24_0)), fieldof(<> c__DisplayClass24_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1));
            expression = Expression.Parameter((Type)typeof(Collection), "c");
            ParameterExpression[] expressionArray2 = new ParameterExpression[] { expression };
            return (IEnumerable<Collection>)Enumerable.ToList<Collection>((IEnumerable<Collection>)Queryable.OrderBy<Collection, string>(queryable1, Expression.Lambda<Func<Collection, string>>((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Collection.get_Title)), expressionArray2)));
        }

        public IEnumerable<Feature> GetFeatures(Guid id)
        {
        <> c__DisplayClass15_0 class_;
            ParameterExpression expression = Expression.Parameter((Type)typeof(Feature), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            return (IEnumerable<Feature>)Enumerable.ToList<Feature>((IEnumerable<Feature>)Queryable.Where<Feature>(this._context.Features, Expression.Lambda<Func<Feature, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Feature.get_ProductId)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass15_0)), fieldof(<> c__DisplayClass15_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1)));
        }

        public Filter GetFilter(Guid id)
        {
        <> c__DisplayClass38_0 class_;
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException("id");
            }
            ParameterExpression expression = Expression.Parameter((Type)typeof(Filter), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            return Queryable.FirstOrDefault<Filter>(Queryable.Where<Filter>(this._context.Filters, Expression.Lambda<Func<Filter, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Filter.get_Id)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass38_0)), fieldof(<> c__DisplayClass38_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1)));
        }

        public IEnumerable<FilterCollection> GetFilterCollections(Guid id)
        {
        <> c__DisplayClass39_0 class_;
            ParameterExpression expression = Expression.Parameter((Type)typeof(FilterCollection), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            return (IEnumerable<FilterCollection>)Enumerable.ToList<FilterCollection>((IEnumerable<FilterCollection>)Queryable.Where<FilterCollection>(this._context.FilterCollections, Expression.Lambda<Func<FilterCollection, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(FilterCollection.get_FilterId)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass39_0)), fieldof(<> c__DisplayClass39_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1)));
        }

        public IEnumerable<FilterOption> GetFilterOptions(Guid id)
        {
        <> c__DisplayClass40_0 class_;
            ParameterExpression expression = Expression.Parameter((Type)typeof(FilterOption), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            IQueryable<FilterOption> queryable1 = Queryable.Where<FilterOption>(this._context.FilterOptions, Expression.Lambda<Func<FilterOption, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(FilterOption.get_FilterId)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass40_0)), fieldof(<> c__DisplayClass40_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1));
            expression = Expression.Parameter((Type)typeof(FilterOption), "c");
            ParameterExpression[] expressionArray2 = new ParameterExpression[] { expression };
            return (IEnumerable<FilterOption>)Enumerable.ToList<FilterOption>((IEnumerable<FilterOption>)Queryable.OrderBy<FilterOption, string>(queryable1, Expression.Lambda<Func<FilterOption, string>>((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(FilterOption.get_Value)), expressionArray2)));
        }

        public IEnumerable<Filter> GetFilters()
        {
            ParameterExpression expression = Expression.Parameter((Type)typeof(Filter), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            return (IEnumerable<Filter>)Enumerable.ToList<Filter>((IEnumerable<Filter>)Queryable.OrderBy<Filter, string>(this._context.Filters, Expression.Lambda<Func<Filter, string>>((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Filter.get_Label)), expressionArray1)));
        }

        public IEnumerable<Image> GetImages(Guid id)
        {
        <> c__DisplayClass14_0 class_;
            ParameterExpression expression = Expression.Parameter((Type)typeof(Image), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            return (IEnumerable<Image>)Enumerable.ToList<Image>((IEnumerable<Image>)Queryable.Where<Image>(this._context.Images, Expression.Lambda<Func<Image, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Image.get_ProductId)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass14_0)), fieldof(<> c__DisplayClass14_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1)));
        }

        public IEnumerable<LineItem> GetLineItems(Guid id)
        {
        <> c__DisplayClass32_0 class_;
            ParameterExpression expression = Expression.Parameter((Type)typeof(LineItem), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            return (IEnumerable<LineItem>)Enumerable.ToList<LineItem>((IEnumerable<LineItem>)Queryable.Where<LineItem>(this._context.LineItems, Expression.Lambda<Func<LineItem, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(LineItem.get_OrderId)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass32_0)), fieldof(<> c__DisplayClass32_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1)));
        }

        public IEnumerable<Note> GetNotes(Guid id)
        {
        <> c__DisplayClass49_0 class_;
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException("id");
            }
            ParameterExpression expression = Expression.Parameter((Type)typeof(Note), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            return (IEnumerable<Note>)Enumerable.ToList<Note>((IEnumerable<Note>)Queryable.Where<Note>(this._context.Notes, Expression.Lambda<Func<Note, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Note.get_LinkedId)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass49_0)), fieldof(<> c__DisplayClass49_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1)));
        }

        public Order GetOrder(Guid id)
        {
        <> c__DisplayClass31_0 class_;
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException("id");
            }
            ParameterExpression expression = Expression.Parameter((Type)typeof(Order), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            return Queryable.FirstOrDefault<Order>(Queryable.Where<Order>(this._context.Orders, Expression.Lambda<Func<Order, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Order.get_Id)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass31_0)), fieldof(<> c__DisplayClass31_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1)));
        }

        public IEnumerable<Order> GetOrders()
        {
            ParameterExpression expression = Expression.Parameter((Type)typeof(Order), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            return (IEnumerable<Order>)Enumerable.ToList<Order>((IEnumerable<Order>)Queryable.OrderByDescending<Order, int>(this._context.Orders, Expression.Lambda<Func<Order, int>>((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Order.get_order_number)), expressionArray1)));
        }

        public Product GetProduct(Guid id)
        {
        <> c__DisplayClass10_0 class_;
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException("id");
            }
            ParameterExpression expression = Expression.Parameter((Type)typeof(Product), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            return Queryable.FirstOrDefault<Product>(Queryable.Where<Product>(this._context.Products, Expression.Lambda<Func<Product, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Product.get_Id)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass10_0)), fieldof(<> c__DisplayClass10_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1)));
        }

        public IEnumerable<Collection> GetProductCollections(Guid id)
        {
        <> c__DisplayClass12_0 class_;
            List<Collection> list = new List<Collection>();
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException("id");
            }
            ParameterExpression expression = Expression.Parameter((Type)typeof(Product), "c");
            ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
            Product productFromRepo = Queryable.FirstOrDefault<Product>(Queryable.Where<Product>(this._context.Products, Expression.Lambda<Func<Product, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Product.get_Id)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass12_0)), fieldof(<> c__DisplayClass12_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1)));
            if (!string.IsNullOrEmpty(productFromRepo.CatLevel1))
            {
                Collection collection = new Collection();
                expression = Expression.Parameter((Type)typeof(Collection), "c");
                Expression[] expressionArray2 = new Expression[] { (Expression)Expression.Property((Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass12_0)), fieldof(<> c__DisplayClass12_0.productFromRepo)), (MethodInfo)methodof(Product.get_CatLevel1)) };
            ParameterExpression[] expressionArray3 = new ParameterExpression[] { expression };
            list.Add(Queryable.First<Collection>(Queryable.Where<Collection>(this._context.Collections, Expression.Lambda<Func<Collection, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Collection.get_Id)), (Expression)Expression.New((ConstructorInfo)methodof(Guid..ctor), expressionArray2), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray3))));
        }
        if (!string.IsNullOrEmpty(productFromRepo.CatLevel2))
        {
            Collection collection2 = new Collection();
        expression = Expression.Parameter((Type) typeof(Collection), "c");
            Expression[] expressionArray4 = new Expression[] { (Expression)Expression.Property((Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass12_0)), fieldof(<> c__DisplayClass12_0.productFromRepo)), (MethodInfo)methodof(Product.get_CatLevel2)) };
        ParameterExpression[] expressionArray5 = new ParameterExpression[] { expression };
        list.Add(Queryable.First<Collection>(Queryable.Where<Collection>(this._context.Collections, Expression.Lambda<Func<Collection, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) expression, (MethodInfo) methodof(Collection.get_Id)), (Expression) Expression.New((ConstructorInfo) methodof(Guid..ctor), expressionArray4), false, (MethodInfo) methodof(Guid.op_Equality)), expressionArray5))));
        }
        if (!string.IsNullOrEmpty(productFromRepo.CatLevel3))
        {
            Collection collection3 = new Collection();
    expression = Expression.Parameter((Type) typeof(Collection), "c");
            Expression[] expressionArray6 = new Expression[] { (Expression)Expression.Property((Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass12_0)), fieldof(<> c__DisplayClass12_0.productFromRepo)), (MethodInfo)methodof(Product.get_CatLevel3)) };
    ParameterExpression[] expressionArray7 = new ParameterExpression[] { expression };
    list.Add(Queryable.First<Collection>(Queryable.Where<Collection>(this._context.Collections, Expression.Lambda<Func<Collection, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) expression, (MethodInfo) methodof(Collection.get_Id)), (Expression) Expression.New((ConstructorInfo) methodof(Guid..ctor), expressionArray6), false, (MethodInfo) methodof(Guid.op_Equality)), expressionArray7))));
    }
        return (IEnumerable<Collection>) list;
}

public IEnumerable<ProductFilter> GetProductFilters(Guid id)
{
        <> c__DisplayClass16_0 class_;
    ParameterExpression expression = Expression.Parameter((Type)typeof(ProductFilter), "c");
    ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
    return (IEnumerable<ProductFilter>)Enumerable.ToList<ProductFilter>((IEnumerable<ProductFilter>)Queryable.Where<ProductFilter>(this._context.ProductFilters, Expression.Lambda<Func<ProductFilter, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(ProductFilter.get_ProductId)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass16_0)), fieldof(<> c__DisplayClass16_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1)));
    }

    public IEnumerable<Product> GetProducts()
{
    ParameterExpression expression = Expression.Parameter((Type)typeof(Product), "c");
    ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
    return (IEnumerable<Product>)Enumerable.ToList<Product>((IEnumerable<Product>)Queryable.OrderBy<Product, string>(this._context.Products, Expression.Lambda<Func<Product, string>>((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Product.get_Title)), expressionArray1)));
}

public Store GetStore(Guid id)
{
        <> c__DisplayClass22_0 class_;
    if (id == Guid.Empty)
    {
        throw new ArgumentNullException("id");
    }
    ParameterExpression expression = Expression.Parameter((Type)typeof(Store), "c");
    ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
    return Queryable.FirstOrDefault<Store>(Queryable.Where<Store>(this._context.Stores, Expression.Lambda<Func<Store, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Store.get_Id)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass22_0)), fieldof(<> c__DisplayClass22_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1)));
    }

    public IEnumerable<Store> GetStores()
{
    ParameterExpression expression = Expression.Parameter((Type)typeof(Store), "c");
    ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
    return (IEnumerable<Store>)Enumerable.ToList<Store>((IEnumerable<Store>)Queryable.OrderBy<Store, string>(this._context.Stores, Expression.Lambda<Func<Store, string>>((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Store.get_Title)), expressionArray1)));
}

public User GetUser(Guid id)
{
        <> c__DisplayClass44_0 class_;
    if (id == Guid.Empty)
    {
        throw new ArgumentNullException("id");
    }
    ParameterExpression expression = Expression.Parameter((Type)typeof(User), "c");
    ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
    return Queryable.FirstOrDefault<User>(Queryable.Where<User>(this._context.Users, Expression.Lambda<Func<User, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(User.get_Id)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass44_0)), fieldof(<> c__DisplayClass44_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1)));
    }

    public User GetUserByEmail(string Email)
{
        <> c__DisplayClass45_0 class_;
    ParameterExpression expression = Expression.Parameter((Type)typeof(User), "c");
    ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
    return Queryable.FirstOrDefault<User>(Queryable.Where<User>(this._context.Users, Expression.Lambda<Func<User, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(User.get_Email)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass45_0)), fieldof(<> c__DisplayClass45_0.Email))), expressionArray1)));
    }

    public User GetUserByResetToken(Guid id)
{
        <> c__DisplayClass46_0 class_;
    ParameterExpression expression = Expression.Parameter((Type)typeof(User), "c");
    ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
    return Queryable.FirstOrDefault<User>(Queryable.Where<User>(this._context.Users, Expression.Lambda<Func<User, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(User.get_ResetToken)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass46_0)), fieldof(<> c__DisplayClass46_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1)));
    }

    public User GetUserLogin(string Email, string Password)
{
        <> c__DisplayClass47_0 class_;
    ParameterExpression expression = Expression.Parameter((Type)typeof(User), "c");
    ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
    return Queryable.FirstOrDefault<User>(Queryable.Where<User>(this._context.Users, Expression.Lambda<Func<User, bool>>((Expression)Expression.AndAlso((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(User.get_Email)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass47_0)), fieldof(<> c__DisplayClass47_0.Email))), (Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(User.get_Password)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass47_0)), fieldof(<> c__DisplayClass47_0.Password)))), expressionArray1)));
    }

    public IEnumerable<User> GetUsers()
{
    ParameterExpression expression = Expression.Parameter((Type)typeof(User), "c");
    ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
    return (IEnumerable<User>)Enumerable.ToList<User>((IEnumerable<User>)Queryable.OrderBy<User, string>(this._context.Users, Expression.Lambda<Func<User, string>>((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(User.get_LastName)), expressionArray1)));
}

public IEnumerable<Store> GetUserStores(Guid id)
{
        <> c__DisplayClass51_0 class_;
    if (id == Guid.Empty)
    {
        throw new ArgumentNullException("id");
    }
    ParameterExpression expression = Expression.Parameter((Type)typeof(StoreUser), "c");
    ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
    List<Store> list = new List<Store>();
    foreach (StoreUser item in Enumerable.ToList<StoreUser>((IEnumerable<StoreUser>)Queryable.Where<StoreUser>(this._context.StoreUsers, Expression.Lambda<Func<StoreUser, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(StoreUser.get_UserId)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass51_0)), fieldof(<> c__DisplayClass51_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1))))
        {
            <> c__DisplayClass51_1 class_2;
    expression = Expression.Parameter((Type)typeof(Store), "c");
    ParameterExpression[] expressionArray2 = new ParameterExpression[] { expression };
    Store store = Queryable.FirstOrDefault<Store>(Queryable.Where<Store>(this._context.Stores, Expression.Lambda<Func<Store, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(Store.get_Id)), (Expression)Expression.Property((Expression)Expression.Field((Expression)Expression.Constant(class_2, (Type)typeof(<> c__DisplayClass51_1)), fieldof(<> c__DisplayClass51_1.item)), (MethodInfo)methodof(StoreUser.get_StoreId)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray2)));
    list.Add(store);
}
return (IEnumerable<Store>)list;
    }

    public void RemoveOrderLines(Guid id)
{
        <> c__DisplayClass33_0 class_;
    ParameterExpression expression = Expression.Parameter((Type)typeof(LineItem), "c");
    ParameterExpression[] expressionArray1 = new ParameterExpression[] { expression };
    foreach (LineItem item in Enumerable.ToList<LineItem>((IEnumerable<LineItem>)Queryable.Where<LineItem>(this._context.LineItems, Expression.Lambda<Func<LineItem, bool>>((Expression)Expression.Equal((Expression)Expression.Property((Expression)expression, (MethodInfo)methodof(LineItem.get_OrderId)), (Expression)Expression.Field((Expression)Expression.Constant(class_, (Type)typeof(<> c__DisplayClass33_0)), fieldof(<> c__DisplayClass33_0.id)), false, (MethodInfo)methodof(Guid.op_Equality)), expressionArray1))))
        {
    this._context.LineItems.Remove(item);
}
    }

    public bool Save() =>
        this._context.SaveChanges() >= 0;

        public void UpdateFilter(Filter filter)
        {
        }

        public void UpdateOrder(Order order)
        {
        }

        public void UpdateProduct(Product product)
        {
        }

        public void UpdateStore(Store store)
        {
        }

        public void UpdateUser(User user)
        {
        }

    }
}
