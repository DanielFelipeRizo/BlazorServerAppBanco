namespace BlazorServerAppBanco.ModelsDTO.Users
{
    public class UserTagDTO
    {
        public int UserTagId { get; set; }

        public string? UserTagsName { get; set; } = string.Empty;

        public string? UserTagsDescription { get; set; } = string.Empty;

        public bool? UserTagsStatus { get; set; } = true;

        public string? CreatedBy { get; set; } = string.Empty;

        public DateTime? CreatedDate { get; set; }
    }
}
