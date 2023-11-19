// namespace는 c# 코드를 묶는 그룹에 가까운 개념
namespace BlazorApp1.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
    }
}
