 
## Regras para o modelo de IA  
- Caso algo não esteja claro ou confuso, pergunte e tire duvidas comigo antes de propor novas ideias
- **SEMPRE perguntar** antes de implementar qualquer alteração, caso algo não esteja claro.
- Não implementar nada sem confirmação do usuário.
- Explicar o que será feito antes de fazer e SOMENTE IMPLEMENTAR APÓS CONFIRMAÇÃO.

## Estado atual
- Models criados na pasta `Models` (raiz) com subpastas `Enums` e `DTOs`
- Enum `StatusEvento` adicionado ao model `Evento` (Ativo, PendenteCliente, Cancelado)
- Enum `Area` expandido com opções comuns de evento
- `ApplicationDbContext` criado na pasta `Data/`, registrado no `Program.cs` e connection string configurada no `appsettings.json`
- Relacionamentos configurados por convenção do EF Core (exclusão em cascata ativa por padrão)

## Dashboard / Tela Inicial (Home)
Ideia discutida para a Home do sistema:
- **Cards no topo** com contadores: Eventos Ativos, Pendentes de Cliente, Cancelados
- **Lista principal** mostrando os eventos **Ativos** (Cliente, Local, Data, Valor Cobrado)
- **Seção lateral/pequena lista** dos eventos **Pendentes de Cliente** (nome do cliente + data + botão de ação)
- **Eventos Cancelados** ficam em aba separada ou link "Ver histórico"
- Botão de ação rápida **"Novo Evento"**

## Checkpoint - Última sessão
- Configuração do SQLite concluída (DbContext, Program.cs, appsettings.json)

### O que estamos fazendo agora
- Criar e aplicar a migration inicial do EF Core

### Próximo passo (para continuar na próxima sessão)
- Implementar Controllers e Views (ou API) para cadastro de Promotores e Eventos
