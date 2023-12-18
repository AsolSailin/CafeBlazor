namespace CafeBlazor.Services
{
    public class FileSystemService
    {
        string path = "";

        public async Task UploadFileAsync(string name, Stream stream, string animalOrEmployee)
        {

            switch (animalOrEmployee)
            {
                case "meal":
                    path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images\meals", name);
                    break;
                case "user":
                    path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images\users", name);
                    break;
            }

        using var fs = new FileStream(path, FileMode.Create);
            await stream.CopyToAsync(fs);
        }
    }
}
