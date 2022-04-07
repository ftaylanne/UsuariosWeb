using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace UsuariosWeb.Presentation.Models
{
    public class UsuariosEdicaoModel
    {
        public Guid IdUsuario { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome do usuario.")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Por favor, informe o email do usuario.")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Por favor, selecione o perfil do usuario.")]
        public string IdPerfil { get; set; }

        #region Campo de selecao do tipo DropDown/ComboBox

        public List<SelectListItem>? ListagemPerfis { get; set; }
        #endregion
    }
}
