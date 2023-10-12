namespace Unidad_2_Actividad_1.Models.ViewModels
{
    public class EspecieViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdClase { get; set; }
        public string NombreClase { get; set; } = null!;
        public double Peso { get; set; }
        public int Tamano { get; set; }
        public string Habitat { get; set; }=null!;
        public string Descripcion { get; set; }= null!;
    }
}
