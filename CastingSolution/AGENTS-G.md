 
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
- Header e Footer movidos para `Views/Shared/_Partials/`
- Tela inicial (Home) criada mostrando eventos ativos

## TODO / Pendências
- **AJUSTAR CORES DA PALETA**: As cores do projeto precisam ser revisadas. Aplicar corretamente: Bordô (#8E1B23) para botões principais/menu ativo/destaques, Rosa claro (#D9A7A7) para badges/fundos secundários/detalhes, Creme (#F3EFE7) fundo geral, Preto (#111111) textos principais, Branco (#FFFFFF) cards/conteúdo, Cinza (#777777) textos secundários/bordas.
- Criar Controller e View para cadastro de Eventos (link "Criar Evento" já existe no menu)
- Criar Controller e View para cadastro de Promotores

## Dashboard / Tela Inicial (Home)
Ideia discutida para a Home do sistema:
- **Cards no topo** com contadores: Eventos Ativos, Pendentes de Cliente, Cancelados
- **Lista principal** mostrando os eventos **Ativos** (Cliente, Local, Data, Valor Cobrado)
- **Seção lateral/pequena lista** dos eventos **Pendentes de Cliente** (nome do cliente + data + botão de ação)
- **Eventos Cancelados** ficam em aba separada ou link "Ver histórico"
- Botão de ação rápida **"Novo Evento"**

## Checkpoint - Última sessão
- Estrutura de Views organizada com partials para Header e Footer
- Menu com link para "Criar Evento" adicionado

### O que estamos fazendo agora
- Organizar Views com partials e preparar estrutura para cadastro de Eventos

### Próximo passo (para continuar na próxima sessão)
- Criar Controller Eventos com ação Create e respectiva View
