# 🌊 EcoVision - Monitoramento Urbano de Alagamentos

O **EcoVision** é uma plataforma de backend de alta performance desenvolvida em **C# .NET 8** para a **Global Solution** da **FIAP** no contexto do ecossistema **CitizenTech**. 

A solução foi projetada para mitigar os impactos de eventos climáticos extremos em grandes centros urbanos através do monitoramento em tempo real de níveis de água, identificação de áreas críticas e emissão de alertas preventivos.

---

## 🎯 Alinhamento com os ODS da ONU

O projeto responde diretamente às diretrizes de sustentabilidade global:

* 🏙️ **ODS 11 - Cidades e Comunidades Sustentáveis** (Meta 11.5): Redução significativa de danos materiais e proteção às populações vulneráveis a alagamentos recorrentes.
* 🌍 **ODS 13 - Ação Contra a Mudança Global do Clima** (Meta 13.1): Fortalecimento da resiliência urbana e capacidade de resposta rápida a tempestades e transbordamentos.

---

## 👥 Integrantes do Grupo

- **Gabriel Guilherme** - RM558638 (Arquitetura Backend, APIs RESTful e Testes Unitários)
- **Gabriel Lacerda** - RM558307 (Modelagem de Dados, EF Core e Padrão Repository)
- **Fernando Carlos** - RM558095 (Documentação Técnica, Swagger UI e Prompts.md)
- **Julia Carolina** - RM558896 (Análise de Negócio e Alinhamento ODS/CitizenTech)

---

## 🏛️ Arquitetura, Padrões e Boas Práticas

O projeto adota os princípios de **Clean Code**, **SOLID** e separação clara de responsabilidades:

- **Repository Pattern**: Abstração total da camada de dados por meio da interface `IPontoAlagamentoRepository`, permitindo a desacoplagem entre controladores e acesso à base.
- **Injeção de Dependência (DI)**: Registro de serviços e repositórios com ciclo de vida otimizado no `Program.cs`.
- **Programação Assíncrona (`async/await`)**: Todas as operações de I/O da API e do repositório utilizam chamadas assíncronas para máxima taxa de vazão (throughput).
- **ORM Entity Framework Core**: Configurado com provedor `InMemory` para testes ágeis, isolamento de escopo e alta fidelidade funcional.
- **Consultas LINQ**: Filtragem e ordenação otimizadas diretamente sobre os dados do repositório.

---



## 🔌 Endpoints da API

- `GET /api/PontosAlagamento` - Lista todos os pontos de alagamento
- `GET /api/PontosAlagamento/{id}` - Busca um ponto por ID
- `GET /api/PontosAlagamento/em-risco` - Retorna locais com risco iminente
- `POST /api/PontosAlagamento` - Cadastra um novo ponto
- `PUT /api/PontosAlagamento/{id}` - Atualiza dados de um ponto
- `DELETE /api/PontosAlagamento/{id}` - Remove um ponto registrado

---
🛠️ Instruções de Execução
Pré-requisitos
.NET 8.0 SDK instalado.

Visual Studio 2022, Visual Studio Code ou JetBrains Rider.

Passos
Clonar o Repositório:

Bash
git clone [https://github.com/Manerrando28/EcoVision.git](https://github.com/Manerrando28/EcoVision.git)
cd EcoVision
Restaurar Dependências:

Bash
dotnet restore
Executar a API:

Bash
dotnet run --project EcoVision.API
Acessar a Documentação Interativa:
Navegue até https://localhost:7030/swagger ou http://localhost:5000/swagger.

🧪 Suíte de Testes Automatizados (xUnit)
O projeto conta com testes unitários focados na validação das regras de negócio do repositório, garantindo que operações de busca, filtragem por risco e alteração de estado funcionem de forma determinística.

Para rodar os testes unitários via linha de comando:

Bash
dotnet test

---

## 📸 Evidências de Funcionamento

Abaixo estão exibidas as capturas de tela que comprovam a compilação, arquitetura, testes e execução dos serviços:

### 1. Inicialização da Aplicação
Logs de startup do servidor Kestrel e confirmação do banco de dados em memória inicializado.

![](01_execucao_console.png.png)

---

### 2. Arquitetura da Solução
Organização das camadas de software e estrutura de projetos no Visual Studio.

![](02_estrutura_solucao.png.png)

---

### 3. Validação dos Endpoints (Swagger UI)

**Consulta de Pontos em Risco (GET 200)**
![](04_swagger_get.jpg.png)

**Cadastro de Ponto (POST 201)**
![](03_swagger_post.jpg.png)

---

### 4. Testes Unitários Automatizados (xUnit)
Execução da suíte de testes no Test Explorer exibindo 100% dos testes aprovados (2/2).

![](05_testes_xunit.jpg.png)

## 📜 Registro de IA (Prompts)

Em total conformidade com as diretrizes acadêmicas da FIAP, o arquivo prompts.md localizado na raiz deste repositório registra o uso de assistentes virtuais de IA como ferramenta de produtividade para depuração de erros de compilação, apoio na estruturação de testes e revisão arquitetural.
---

## 🙏 Agradecimentos e Considerações Finais

### Agradecemos sinceramente ao corpo docente da FIAP, com destaque para os professores da disciplina de C# Software Development, pela excelência no ensino e orientação. A jornada da Global Solution permitiu consolidar na prática padrões fundamentais de desenvolvimento de software enterprise em .NET.

---

*EcoVision © 2026 - Desenvolvido para a Global Solution FIAP.*


*EcoVision © 2026 - Desenvolvido para a Global Solution FIAP.*
