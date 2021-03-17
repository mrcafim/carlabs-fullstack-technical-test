using Microsoft.Extensions.Configuration;
using System;
using Moq.AutoMock;
using Restaurant.Infra.Data;

namespace Restaurant.Tests
{
    public class TestBase
    {
        public readonly AutoMocker AutoMocker = new AutoMocker();

        public IConfiguration GetConfiguration()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.test.json")
                .Build();
        }

        public DataContext GetContext()
        {
            return DatabaseContextMocker.CreateContext();
        }

        //public UsuarioCadastrarDTO ObterUsuarioCadastrarDTOValido()
        //{
        //    return new UsuarioCadastrarDTO
        //    {
        //        Nome = "Rutyelle Santos",
        //        Email = "alguem@ivoryit.com.br",
        //        Perfil = "Administrador",
        //        Senha = "senha@123",
        //        SenhaConfirmar = "senha@123"
        //    };
        //}

        //public UsuarioCadastrarDTO ObterUsuarioCadastrarDTOInvalido()
        //{
        //    return new UsuarioCadastrarDTO
        //    {
        //        Nome = "",
        //        Email = "",
        //        Perfil = "",
        //        Senha = "",
        //        SenhaConfirmar = ""
        //    };
        //}

        //public UsuarioEditarDTO ObterUsuarioEditarDTOValido()
        //{
        //    return new UsuarioEditarDTO
        //    {
        //        Id = 1,
        //        Nome = "Rutyelle Santos",
        //        Email = "alguem@ivoryit.com.br",
        //        Perfil = "Administrador",
        //        Senha = "senha@123"
        //    };
        //}

        //public UsuarioEditarDTO ObterUsuarioEditarDTOInvalido()
        //{
        //    return new UsuarioEditarDTO
        //    {
        //        Id = 0,
        //        Nome = "",
        //        Email = "",
        //        Perfil = "",
        //        Senha = ""
        //    };
        //}

        //public AutenticacaoDTO ObterAutenticacaoDTOValido()
        //{
        //    return new AutenticacaoDTO
        //    {
        //        Usuario = "usuario@ivoryit.com.br",
        //        Senha = "senhasenhasenha"
        //    };
        //}

        //public AutenticacaoDTO ObterAutenticacaoDTOInvalido()
        //{
        //    return new AutenticacaoDTO
        //    {
        //        Usuario = "",
        //        Senha = ""
        //    };
        //}

        //public AutenticacaoRefreshDTO ObterAutenticacaoRefreshDTOValido()
        //{
        //    return new AutenticacaoRefreshDTO
        //    {
        //        UsuarioId = 1,
        //        RefreshToken = "token"
        //    };
        //}

        //public AutenticacaoRefreshDTO ObterAutenticacaoRefreshDTOInvalido()
        //{
        //    return new AutenticacaoRefreshDTO
        //    {
        //        UsuarioId = 0,
        //        RefreshToken = ""
        //    };
        //}

        //public Usuario ObterUsuarioValido()
        //{
        //    return new Usuario
        //    {
        //        Id = 1,
        //        Nome = "Rutyelle Santos",
        //        Email = "alguem@ivoryit.com.br",
        //        Perfil = "Administrador",
        //        Senha = "senha@123",
        //        Token = Guid.NewGuid().ToString(),
        //        TokenExpiracao = DateTime.Now.AddHours(1),
        //        Ativo = true
        //    };
        //}

        //public AzureAdAccessToken ObterAzureAdAccessToken()
        //{
        //    return new AzureAdAccessToken
        //    {
        //        AccessToken = Guid.NewGuid().ToString(),
        //        AccessTokenExpiracao = 1234,
        //        AccessTokenRefresh = Guid.NewGuid().ToString(),
        //        UsuarioId = Guid.NewGuid()
        //    };
        //}

        //public AzureAdGroupRole ObterAzureAdGroupRole()
        //{
        //    return new AzureAdGroupRole
        //    {
        //        GroupId = Guid.NewGuid(),
        //        Roles = "Administrador"
        //    };
        //}
    }
}
