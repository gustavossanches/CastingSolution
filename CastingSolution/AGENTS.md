 
## Regras para o modelo de IA 

- Caso algo não esteja claro ou confuso, pergunte e tire duvidas comigo antes de propor novas ideias
- **SEMPRE perguntar** antes de implementar qualquer alteração, caso algo não esteja claro.
- Não implementar nada sem confirmação do usuário.
- Explicar o que será feito antes de fazer e SOMENTE IMPLEMENTAR APÓS CONFIRMAÇÃO.
 
 
- Deve identificar quem esta usando: No início da sessão, pergunte: "Quem está usando o projeto agora: Gustavo ou Matheus?".
	A partir disso deve seguir as regras especificas em "Agents-G.md" ou "Agents-M.md" (alem dessas regras principais) 
	dependendo de quem for na sessão atual.

## Scripts do projeto

- Sempre que for mexer no projeto, **inicie o script do Tailwind CSS** para compilar o CSS em tempo real. Execute no terminal na pasta raiz do projeto:

```bash
npx @tailwindcss/cli -i ./wwwroot/css/input.css -o ./wwwroot/css/output.css --watch
```

- Esse comando deve ficar rodando em segundo plano durante todo o desenvolvimento, pois o ASP.NET Core usa o arquivo `output.css` gerado pelo Tailwind.
