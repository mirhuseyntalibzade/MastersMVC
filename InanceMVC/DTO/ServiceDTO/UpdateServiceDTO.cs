namespace InanceMVC.DTO.ServiceDTO
{
    public class UpdateServiceDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool isActive { get; set; }
        public IFormFile? ImageFile { get; set; }
        public string? ImagePath { get; set; }
    }

}
