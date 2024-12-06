namespace InanceMVC.DTO.ServiceDTO
{
    public class CreateServiceDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile? ImageFile { get; set; }
    }

}
