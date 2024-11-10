namespace MVCApplication.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
