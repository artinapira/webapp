namespace webapp.ViewModels
{
    public class PacientiVM
    {
        public string EmriMbiemri { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Pass { get; set; } = null!;

        public DateOnly? DataLindjes { get; set; }

        public string? Gjinia { get; set; }
    }
}
