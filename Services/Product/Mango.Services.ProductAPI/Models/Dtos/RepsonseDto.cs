namespace Mango.Services.ProductAPI.Models.Dtos
{
    public class RepsonseDto
    {
        public bool IsSuccess { get; set; } = true;
        public object Result { get; set; }
        public string DisplayMessage { get; set; } = string.Empty; 
        public List<string> ErrorMessage { get; set; }
    }
}
