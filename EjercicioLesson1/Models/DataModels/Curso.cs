using System.ComponentModel.DataAnnotations;


namespace EjercicioLesson1.Models.DataModels
{
    public class Curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string DescriptionCorta { get; set; } = string.Empty;
        [Required]
        public string Descriptionlarga { get; set; } = string.Empty;
        [Required]
        public string  PublicoObjetivo { get; set;} = string.Empty;
        [Required]
        public string Objetivo { get; set; } = string.Empty;
        [Required]
        public string Requisitos { get; set; } = string.Empty;
        
        public enum Nivel { bajo, intermedio, avanzado};
    }
}
