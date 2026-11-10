# 🌊 EcoVision - Monitoramento Urbano de Alagamentos

O **EcoVision** é uma plataforma de backend desenvolvida em **C# .NET 8** para a **Global Solution** da **FIAP** no contexto da iniciativa **CitizenTech**. A solução foi desenhada para enfrentar os crescentes desafios de drenagem e eventos climáticos extremos nas grandes cidades, alinhando-se diretamente a dois dos Objetivos de Desenvolvimento Sustentável da ONU:

- 🏙️ **ODS 11 - Cidades e Comunidades Sustentáveis**: Apoio à gestão de infraestruturas urbanas resilientes e proteção de populações vulneráveis a alagamentos.
- 🌍 **ODS 13 - Ação Contra a Mudança Global do Clima**: Resposta rápida e prevenção adaptativa frente a tempestades e transbordamentos de rios e córregos.

---

## 👥 Integrantes do Grupo

| Nome do Integrante | RM | Responsabilidade no Projeto |
| :--- | :---: | :--- |
| ** Gabriel Guilherme 1 ** | RM558638 | Arquitetura Backend, APIs RESTful e Testes Unitários |
| ** Gabriel Lacerda  2  ** | RM558307 | Modelagem de Dados, EF Core e Padrão Repository |
| ** Fernando Carlos 3   ** | RM558095 | Documentação Técnica, Swagger UI e Prompts.md |
| ** Julia Carolina  4   ** | RM558896 | Análise de Negócio e Alinhamento ODS/CitizenTech |

---

## 🚀 Tecnologias e Boas Práticas

- **C# / .NET 8 Web API**: Framework moderno e de alto desempenho para construção de serviços RESTful.
- **Entity Framework Core (In-Memory)**: Mapeamento objeto-relacional (ORM) configurado para persistência temporária ágil durante a fase de testes.
- **Repository Pattern**: Separação clara entre a lógica de negócios e as operações de acesso a dados com injeção de dependência via interfaces.
- **Programação Assíncrona (`async/await`)**: Processamento não bloqueante de requisições I/O para garantir escalabilidade.
- **Consultas LINQ**: Filtragens eficientes diretamente sobre as coleções do repositório.
- **Testes Unitários automatizados com xUnit**: Validação contínua das regras de negócio do repositório em ambiente isolado.
- **Swagger UI / Swashbuckle**: Documentação interativa para teste direto das rotas HTTP no navegador.

---

## 📁 Arquitetura da Solução

```text
EcoVision/
├── EcoVision.API/                  # Projeto Web API Kestrel
│   ├── Controllers/               # Endpoints REST (PontosAlagamentoController.cs)
│   ├── Data/                      # Contexto do EF Core (AppDbContext.cs)
│   ├── Models/                    # Entidades (PontoAlagamento.cs, AlertaEmergencia.cs)
│   ├── Repositories/              # Interface e Implementação (IPontoAlagamentoRepository)
│   ├── Program.cs                 # Bootstrapping e Injeção de Dependências
│   └── appsettings.json           # Configurações do ambiente
├── EcoVision.Tests/                # Projeto de Testes Automatizados (xUnit)
│   └── PontoAlagamentoRepositoryTests.cs
├── evidencias/                     # Prints comprobatórios numerados de 01 a 05
├── README.md                       # Documentação principal da entrega
└── prompts.md                      # Registro de prompts e uso responsável de IA
🔌 Endpoints da API
Método	Rota	Descrição	Status HTTP
GET	/api/PontosAlagamento	Lista todos os pontos de alagamento registrados	200 OK
GET	/api/PontosAlagamento/{id}	Busca os detalhes de um ponto específico por ID	200 OK / 404 Not Found
GET	/api/PontosAlagamento/em-risco	Retorna apenas locais marcados com risco iminente de transbordo	200 OK
POST	/api/PontosAlagamento	Cadastra um novo ponto com medição de nível de água	201 Created
PUT	/api/PontosAlagamento/{id}	Atualiza o estado ou nível de água de um ponto existente	204 No Content / 400 Bad Request
DELETE	/api/PontosAlagamento/{id}	Remove o registro de um ponto de monitoramento	204 No Content / 404 Not Found
🛠️ Como Executar a Aplicação
Pré-requisitos
.NET 8.0 SDK

IDE Visual Studio 2022 ou Visual Studio Code

Git instalado no sistema

Passos de Instalação e Execução
Clone o repositório para a sua máquina local:

Bash
git clone [https://github.com/Manerrando28/EcoVision.git](https://github.com/Manerrando28/EcoVision.git)
cd EcoVision
Restaure as dependências do ecossistema .NET:

Bash
dotnet restore
Execute a API através do CLI do .NET:

Bash
dotnet run --project EcoVision.API
Acesse o Swagger UI no navegador preferido:

Plaintext
https://localhost:7030/swagger
🧪 Execução dos Testes Unitários (xUnit)
A solução implementa testes automatizados utilizando xUnit para garantir o correto funcionamento dos repositórios assíncronos e do banco em memória.

Para rodar a suíte inteira de testes via terminal:

Bash
dotnet test
📸 Evidências de Funcionamento
Abaixo estão exibidas as capturas de tela que comprovam a compilação, arquitetura, testes e execução dos serviços:

1. Inicialização da Aplicação
Logs de startup do servidor Kestrel e confirmação do banco de dados em memória inicializado.
<img width="1917" height="1017" alt="01_execucao_console png" src="https://github.com/user-attachments/assets/79419b8a-0392-4650-bafd-a2ad480d9d62" />




2. Arquitetura da Solução
Organização das camadas de software e estrutura de projetos no Visual Studio.
![02 - Estrutura da Solução](02_estrutura_solucao.png.png)




3. Validação dos Endpoints (Swagger UI)
Testes reais das rotas HTTP com cadastro de ponto de alagamento e filtragem de locais em risco.
<img width="1748" height="915" alt="04_swagger_get jpg" src="https://github.com/user-attachments/assets/0da7b294-cd06-437d-bbcb-7d30aa73cfe6" />
<img width="1747" height="909" alt="03_swagger_post jpg" src="https://github.com/user-attachments/assets/ed60fbb2-1566-44c8-aa90-53823d673654" />


Cadastro de Ponto (POST 201)	Consulta de Pontos em Risco (GET 200)
4. Testes Unitários Automatizados (xUnit)
Execução da suíte de testes no Test Explorer exibindo 100% dos testes aprovados (2/2).
<img width="1917" height="990" alt="05_testes_xunit jpg" src="https://github.com/user-attachments/assets/b5c01fbb-7282-4f64-aa20-0aa5963ae405" />


📜 Registro de IA (Prompts)
Em conformidade com as diretrizes acadêmicas da FIAP, o ficheiro prompts.md presente na raiz deste repositório documenta a utilização de assistentes virtuais baseados em Inteligência Artificial para auxílio na depuração de erros de compilação, estruturação de documentação Markdown e revisão da arquitetura.

🙏 Agradecimentos e Considerações Finais
Agradecemos sinceramente a todo o corpo docente da FIAP, especialmente aos professores da disciplina de C# Software Development, pelos ensinamentos transmitidos ao longo do ano lectivo. A orientação acadêmica e a estrutura desafiadora do ecossistema da Global Solution foram fundamentais para que pudéssemos consolidar conceitos avançados de orientação a objetos, arquitetura assíncrona e boas práticas de desenvolvimento de software em .NET.

Extendemos também o nosso agradecimento aos colegas de equipe pelo empenho conjunto na idealização e entrega da solução EcoVision.

EcoVision © 2026 - Desenvolvido para a Global Solution FIAP.
