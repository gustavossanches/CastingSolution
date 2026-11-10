## Regras para o modelo de IA

- Caso algo não esteja claro ou confuso, pergunte e tire duvidas comigo antes de propor novas ideias.
- **SEMPRE perguntar** antes de implementar qualquer alteração, caso algo não esteja claro.
- Não implementar nada sem confirmação do usuário.
- Explicar o que será feito antes de fazer e SOMENTE IMPLEMENTAR APÓS CONFIRMAÇÃO.

## Estado atual

- Models criados na pasta `Models` com subpastas `Enums`, `DTOs` e `ViewModel`.
- Arquitetura Controller-Service-Repository implementada.
- `ApplicationDbContext` criado na pasta `Data/` com SQLite configurado.
- Tela inicial (Home) criada mostrando eventos ativos.
- Tela de listagem de Promotores (`ListarPromotores`) criada.
- Tela de cadastro de Promotores (`Create`) criada com ViewModel (`CriarPromotorViewModel`).
- Todos os campos da tabela `Promotores` são opcionais no banco (nullable).
- Validação de formulário implementada na ViewModel (apenas `Nome` é obrigatório no formulário).
- Mapeamento `MapToPromotor` extraído para `Map/MapPromotor.cs`.
- Tailwind CSS + DaisyUI configurados e funcionando.
- Paleta de cores definida: Bordô (#8E1B23), Rosa claro (#D9A7A7), Creme (#F3EFE7), Preto (#111111), Branco (#FFFFFF), Cinza (#777777).

## TODO / Pendências

- **IMPLEMENTAR FOTOS NO CADASTRO DO PROMOTOR**: Adicionar upload de fotos na tela de criação/edição de promotores, vinculando à entidade `FotoPromotor` (model já existe com relacionamento configurado).
- Criar Controller e View para cadastro de Eventos (link "Criar Evento" já existe no menu).
- Criar funcionalidade de edição de Promotores.
- Criar funcionalidade de exclusão de Promotores.
- Implementar filtros e busca na listagem de Promotores.

## Dashboard / Tela Inicial (Home)

Ideia discutida para a Home do sistema:

- **Cards no topo** com contadores: Eventos Ativos, Pendentes de Cliente, Cancelados.
- **Lista principal** mostrando os eventos **Ativos** (Cliente, Local, Data, Valor Cobrado).
- **Seção lateral/pequena lista** dos eventos **Pendentes de Cliente** (nome do cliente + data + botão de ação).
- **Eventos Cancelados** ficam em aba separada ou link "Ver histórico".
- Botão de ação rápida **"Novo Evento"**.

## Checkpoint - Última sessão

- Todos os campos do modelo `Promotor` tornados opcionais no banco (`string?`, `int?`, `DateTime?`, enums nullable).
- Criada a `CriarPromotorViewModel` para validação de formulário (apenas `Nome` obrigatório).
- Refatorado Controller, Service e Map para trabalhar com ViewModel.
- Gerada e aplicada migração `TornarCamposOpcionais` no SQLite.
- Corrigida sintaxe do `@plugin "daisyui/theme"` no CSS.

### O que estamos fazendo agora

- Implementação da tela de detalhes do promotor e exibição das fotos salvas localmente.

### Próximo passo (para continuar na próxima sessão)

- **Concluir a exibição das fotos na tela de detalhes**: adicionar a action `Foto(int id)` no `PromotoresController`, buscar a foto pelo ID, entregar o arquivo salvo em `C:\Promotores` com `PhysicalFile` e validar a galeria na view `PromotorDetalhe.cshtml`.

## Scripts do projeto

- Sempre que for mexer no projeto, **inicie o script do Tailwind CSS** para compilar o CSS em tempo real. Execute no terminal na pasta raiz do projeto:

```bash
npx @tailwindcss/cli -i ./wwwroot/css/input.css -o ./wwwroot/css/output.css --watch
```

- Esse comando deve ficar rodando em segundo plano durante todo o desenvolvimento, pois o ASP.NET Core usa o arquivo `output.css` gerado pelo Tailwind.
