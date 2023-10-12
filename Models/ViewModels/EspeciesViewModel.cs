namespace Unidad_2_Actividad_1.Models.ViewModels
{
    public class EspeciesViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public IEnumerable<EspecieModel> Especies { get; set; } = null!;
    }
    public class EspecieModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
