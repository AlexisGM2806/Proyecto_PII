using System;
namespace Library
{
    
    public interface IUsuario
    {
        bool Activo { get; set; }          
        DateTime FechaCreacion { get; set; } 
    }

}