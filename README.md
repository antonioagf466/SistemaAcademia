
# SistemaAcademia

> Sistema de gestão para uma academia — backend ASP.NET Core com Entity Framework Core.

**Trabalho feito por:** Antonio Geraldes, Antonio Bernardo e Eduardo Vigil

**Resumo:**
- Projeto em ASP.NET Core; já contém migrations na pasta `Migrations`.

**Tecnologias**
- **Framework:** ASP.NET Core
- **ORM:** Entity Framework Core
- **Linguagem:** C#
- **Banco de dados:** (configurável via `appsettings.json`, tipicamente SQL Server / LocalDB)

**Pré-requisitos**
- .NET SDK 8.0+ instalado (ou a versão indicada no arquivo `.csproj`).
- Visual Studio 2022/2023 (recomendado) para a experiência descrita abaixo.

**Como clonar**
1. Clone o repositório (substitua `<repo-url>` pela URL do seu repositório):

```bash
git clone <repo-url>
```

2. Abra a solução no Visual Studio:

```text
Abrir o arquivo `SistemaAcademia.sln` com o Visual Studio (File → Open → Project/Solution).
```

**Usando Visual Studio (Windows / recomendado)**

- Abra `SistemaAcademia.sln` no Visual Studio.
- No `Solution Explorer`, clique com o botão direito no projeto `SistemaAcademia` e selecione `Set as Startup Project`.
- Verifique a `ConnectionStrings` em `appsettings.json` ou use **User Secrets** (clicar com o botão direito no projeto → `Manage User Secrets`) para não deixar credenciais no código.

Aplicar migrations e atualizar o banco (Package Manager Console):

1. Abra o `Package Manager Console` (Menu `Tools` → `NuGet Package Manager` → `Package Manager Console`).
2. Selecione o **Default Project** correto (ex.: `SistemaAcademia`) na dropdown do Package Manager Console.
3. Para aplicar todas as migrations existentes e atualizar o banco, execute:

```powershell
Update-Database
```

4. Para criar uma nova migration após alterar modelos (models):

```powershell
Add-Migration NomeDaMigration
Update-Database
```


**Configuração de conexão**
- A string de conexão está em `appsettings.json` (ou `appsettings.Development.json`). Ajuste conforme seu ambiente (SQL Server, LocalDB, etc.). Em ambientes locais com Visual Studio é comum usar `LocalDB` ou um SQL Server Express.

**Executar a aplicação**

- No Visual Studio: `F5` ou `Ctrl+F5`.

**Estrutura relevante**
- `Controllers/` — controllers MVC/API
- `Models/` — entidades do domínio
- `Views/` — renderiza csshtml
- `Migrations/` — migrations do EF Core
- `appsettings.json` — configurações e connection strings


**Créditos**
- Desenvolvimento: Antonio, Bernardo e Eduardo

---
