namespace NewsWeb.Services
{
    public class ImageRepository : IImageInterface
    {
        private readonly IWebHostEnvironment environment;
        private readonly string Folder = "images";

        public ImageRepository(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        public string SaveImage(IFormFile file)
        {
            string uniqueName = string.Empty;
            if (file is not null)
            {
                string uploadPath = Path.Combine(environment.WebRootPath, Folder);
                uniqueName = Guid.NewGuid().ToString() +  file.FileName;
                uploadPath = Path.Combine(uploadPath, uniqueName);
                FileStream fileStream = new FileStream(uploadPath, FileMode.Create);
                file.CopyTo(fileStream);
                fileStream.Close();
            }

            return uniqueName;
        }

        public void DeleteImage(string fileName)
        {
            string uplodFolder = Path.Combine(environment.WebRootPath, Folder);
            string filePath = Path.Combine(uplodFolder, fileName);
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
        }
    }
}
