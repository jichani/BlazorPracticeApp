using BlazorApp1.Models;

namespace BlazorApp1.Controller
{
    public class OrderController
    {
        //  List 형태로 값을 반환해야 합니다.
        public Task<List<OrderModel>> orderModelsAsync()
        {
            List<OrderModel> orders = new ();
            orders.Add(new OrderModel { Id = 1, Name = "안성탕면", Category = "라면", Price = "1600", OrderDate = DateTime.Now });
            orders.Add(new OrderModel { Id = 2, Name = "신라면", Category = "라면", Price = "1400", OrderDate = DateTime.Now });
            orders.Add(new OrderModel { Id = 3, Name = "짜파개티", Category = "라면", Price = "1700", OrderDate = DateTime.Now });
            orders.Add(new OrderModel { Id = 4, Name = "진라면", Category = "라면", Price = "1600", OrderDate = DateTime.Now });
            return Task.FromResult(orders);
        }
    }
}
