using System.Linq;

namespace CovidWeb.Models {
    public class EFStoreRepository : IStoreRepository {
        private AppDbContext context;

        public EFStoreRepository(AppDbContext ctx) {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;

        public void CreateProduct(Product p) {
            context.Add(p);
            context.SaveChanges();
        }

        public void DeleteProduct(Product p) {
            context.Remove(p);
            context.SaveChanges();
        }

        public void SaveProduct(Product p) {
            context.SaveChanges();
        }
    }
}
