using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosApp.Aplication.Interfaces;
using UsuariosApp.Aplication.Models.Requests;
using UsuariosApp.Aplication.Models.Responses;
using UsuariosApp.Application.Models.Requests;

namespace UsuariosApp.Aplication.Services
{
    public class UsuarioAppService : IUsuarioAppService
    {
        AutenticarResponseDTO IUsuarioAppService.Autenticar(AutenticarRequestDTO dto)
        {
            throw new NotImplementedException();
        }

        CriarContaResponseDTO IUsuarioAppService.CriarConta(CriarContaRequestDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
