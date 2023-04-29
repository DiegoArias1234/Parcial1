using System.ComponentModel.DataAnnotations;

namespace Parcial1.Shared.Entities
{
    public class Registro
    {
        [key] public int Id { get; set; }
        public int IdBoleta { get; set; }

        

        public string FechaUso { get; set; } = null!;


        public bool FueUsada { get; set; } = false;

        public string Porteria { get; set; } = null!;

    }
}
