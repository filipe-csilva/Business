# API Sistema de Tarefas

API para gerenciamento de tarefas por usuario

| :placard: Vitrine.Dev |     |
| -------------  | --- |
| :sparkles: Nome        | Sistema de Vendas
| :label: Tecnologias | c#, .Net
| :rocket: URL         | 
| :fire: Desafio     | 

<!-- Inserir imagem com a #vitrinedev ao final do link -->
![](https://cdn.discordapp.com/attachments/769394667531534386/1149903062308245624/Businnes.png)

## Descrição do projeto

Este é um projeto de exemplo que demonstra um aplicativo web usando ASP.NET Core para realizar operações CRUD (Create, Read, Update, Delete) para tarefas e usuários. O aplicativo utiliza um banco de dados para armazenar os dados e fornece uma API para interação com o front-end.

## Tecnologias Utilizadas

- ASP.NET Core 7.0
- Entity Framework Core (EF Core)
- Postgres (ou outro banco de dados de sua escolha)
- C#, .Net


## Pré-requisitos

- .NET Core SDK (versão 7.0 ou superior)
- Postgres (ou outro banco de dados compatível)
- Um ambiente de desenvolvimento integrado (IDE) como Visual Studio ou Visual Studio Code


## Configuração do Banco de Dados

1. Instale o Postgres e crie um banco de dados para o projeto.

2. Abra o arquivo `appsettings.json` na pasta raiz do projeto.

3. No arquivo `appsettings.json`, substitua a string de conexão do banco de dados pelos dados do seu banco recém-criado.


## Configuração do Projeto

1. Clone este repositório para sua máquina local.

2. Abra o projeto no seu IDE de escolha.
3. Aplique as migrações para criar as tabelas do banco de dados. No terminal, execute o seguinte comando:

    ```
    dotnet ef database update
    ```

4. Inicie o aplicativo. No terminal, execute o seguinte comando:

    ```
    dotnet run
    ```

6. Acesse a API através do navegador ou de uma ferramenta como o Postman. As rotas para interagir com as tarefas e usuários serão fornecidas pela API.


## Rotas da API

A API possui as seguintes rotas:

- GET `/api/Product`: Retorna todas as tarefas.
- GET `/api/Product/{id}`: Retorna uma tarefa específica pelo ID.
- POST `/api/Product`: Cria uma nova tarefa.
- PUT `/api/Product/{id}`: Atualiza uma tarefa existente pelo ID.
- DELETE `/api/Product/{id}`: Exclui uma tarefa pelo ID.

- GET `/api/Brand`: Retorna todos os usuários.
- GET `/api/Brand/{id}`: Retorna um usuário específico pelo ID.
- POST `/api/Brand`: Cria um novo usuário.
- PUT `/api/Brand/{id}`: Atualiza um usuário existente pelo ID.
- DELETE `/api/Brand/{id}`: Exclui um usuário pelo ID.

- GET `/api/Group`: Retorna todos os usuários.
- GET `/api/Group/{id}`: Retorna um usuário específico pelo ID.
- POST `/api/Group`: Cria um novo usuário.
- PUT `/api/Group/{id}`: Atualiza um usuário existente pelo ID.
- DELETE `/api/Group/{id}`: Exclui um usuário pelo ID.

- GET `/api/SubGroup`: Retorna todos os usuários.
- GET `/api/SubGroup/{id}`: Retorna um usuário específico pelo ID.
- POST `/api/SubGroup`: Cria um novo usuário.
- PUT `/api/SubGroup/{id}`: Atualiza um usuário existente pelo ID.
- DELETE `/api/SubGroup/{id}`: Exclui um usuário pelo ID.

- GET `/api/Client`: Retorna todos os usuários.
- GET `/api/Client/{id}`: Retorna um usuário específico pelo ID.
- POST `/api/Client`: Cria um novo usuário.
- PUT `/api/Client/{id}`: Atualiza um usuário existente pelo ID.
- DELETE `/api/Client/{id}`: Exclui um usuário pelo ID.

- GET `/api/Supplier`: Retorna todos os usuários.
- GET `/api/Supplier/{id}`: Retorna um usuário específico pelo ID.
- POST `/api/Supplier`: Cria um novo usuário.
- PUT `/api/Supplier/{id}`: Atualiza um usuário existente pelo ID.
- DELETE `/api/Supplier/{id}`: Exclui um usuário pelo ID.

## Contribuição

Contribuições são bem-vindas! Se você encontrar algum problema ou tiver sugestões, sinta-se à vontade para abrir uma issue neste repositório.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
