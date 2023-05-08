using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosApp.Aplication.Models.Requests;
using UsuariosApp.Aplication.Models.Responses;
using UsuariosApp.Application.Models.Requests;

namespace UsuariosApp.Aplication.Interfaces
{
    public interface IUsuarioAppService
    {
        AutenticarResponseDTO Autenticar(AutenticarRequestDTO dto);
        CriarContaResponseDTO CriarConta(CriarContaRequestDTO dto);
    }
}
