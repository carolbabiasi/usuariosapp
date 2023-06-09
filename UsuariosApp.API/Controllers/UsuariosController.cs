﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsuariosApp.Aplication.Interfaces;
using UsuariosApp.Aplication.Models.Requests;
using UsuariosApp.Aplication.Models.Responses;
using UsuariosApp.Application.Models.Requests;

namespace UsuariosApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioAppService? _usuarioAppService;

        public UsuariosController(IUsuarioAppService? usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }

        /// <summary>
        ///     Autenticação de usuários
        /// </summary>
        [HttpPost]
        [Route("autenticar")]
        [ProducesResponseType(typeof(AutenticarResponseDTO), StatusCodes.Status200OK)]
        public IActionResult Autenticar(AutenticarRequestDTO dto)
        {
            //TODO
            return Ok();

        }

        /// <summary>
        /// Criação de conta de usuários
        /// </summary>

        [HttpPost]
        [Route("criar-conta")]
        [ProducesResponseType(typeof(CriarContaResponseDTO), StatusCodes.Status201Created)]
        public IActionResult CriarConta(CriarContaRequestDTO dto) 
        { 
            //TODO
            return Ok();
        }
    }
}
