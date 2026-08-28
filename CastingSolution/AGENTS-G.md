 
## Regras para o modelo de IA  
- Caso algo não esteja claro ou confuso, pergunte e tire duvidas comigo antes de propor novas ideias
- **SEMPRE perguntar** antes de implementar qualquer alteração, caso algo não esteja claro.
- Não implementar nada sem confirmação do usuário.
- Explicar o que será feito antes de fazer e SOMENTE IMPLEMENTAR APÓS CONFIRMAÇÃO.

## Estado atual
  
## Checkpoint - Última sessão
 
### O que estamos fazendo agora
 
### Próximo passo (para continuar na próxima sessão)
- Configurar o SQLite no projeto:
  1. Adicionar connection string no `appsettings.json`
  2. Criar o `DbContext` (AppDbContext)
  3. Registrar o DbContext no `Program.cs`
  4. Criar e aplicar a migration inicial (`dotnet ef migrations add InitialCreate` e `dotnet ef database update`)
