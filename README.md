# DesafioDotNet

Este é um projeto de exemplo para uma aplicação ASP.NET Core usando Entity Framework Core e SQL Server. O projeto inclui operações básicas para a entidade `Pedido` e suas relações com `ItemPedido` e `Produto`.

## Pré-requisitos

Antes de começar, certifique-se de ter instalado:

- [Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/) ou [Visual Studio Code](https://code.visualstudio.com/)
- [.NET SDK](https://dotnet.microsoft.com/download)

## Configuração do Banco de Dados

Este projeto utiliza o Entity Framework Core para lidar com a camada de banco de dados. Para configurar o banco de dados:

1. Abra o arquivo `appsettings.json` na raiz do projeto.

2. Configure a string de conexão no bloco `"ConnectionStrings"`:

    ```json
    "ConnectionStrings": {
        "DefaultConnection": "SuaConnectionStringAqui"
    },
    ```

    Substitua `"SuaConnectionStringAqui"` pela string de conexão do seu banco de dados SQL Server.

3. Abra o Package Manager Console no Visual Studio e execute os seguintes comandos:

    ```bash
    Update-Database -Context DesafioDotNetDbContext
    ```

    Isso criará o banco de dados com as tabelas necessárias.

## Executando o Projeto

1. Abra o projeto no Visual Studio ou Visual Studio Code.

2. Execute o projeto.

3. Acesse a API através do navegador ou ferramenta como [Postman](https://www.postman.com/) utilizando os endpoints definidos no `PedidoController` (por exemplo, `/api/pedidos`).

## Contribuições

Sinta-se à vontade para contribuir com melhorias, correções de bugs ou novos recursos. Abra uma issue ou envie um pull request.

## Licença

Este projeto está licenciado sob a MIT License - veja o arquivo [LICENSE](LICENSE) para detalhes.
