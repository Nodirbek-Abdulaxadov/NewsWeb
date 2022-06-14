namespace NewsWeb.Services
{
    public interface IImageInterface
    {
        string SaveImage(IFormFile file);
        void DeleteImage(string fileName);
    }
}
