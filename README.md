# Observações
Com base no que aprendi nas aulas de .NET 6 realizei o teste contendo apenas um Controller e uma Entidade, sem Interface e Service pois ainda foi me ensinado a mexer com os dois.

# Descrição do Teste Técnico
Você foi designado para desenvolver um teste para avaliar candidatos à posição de 
Desenvolvedor .Net. O objetivo é avaliar o conhecimento técnico, habilidades na 
resolução de problemas e práticas de código eficientes. Siga as instruções abaixo:

### Desenvolvedor - Teste Técnico:
Utilizando C# .NET, crie uma API Swagger com quatro endpoints: Post, Put, Delete e Get. 
Essa API será utilizada por um sistema de cadastro de usuários.

### Requisitos Técnicos:
* A API deve incluir controller, entidade, interface e service.
* Se julgar necessário, crie uma ou mais DTOs.
* Os dados não precisam ser gravados em um banco de dados.

### Considerações Específicas:
* Post e Put: A API não deve permitir o cadastro de mais de um usuário com o 
mesmo CPF. Se uma tentativa de cadastro for feita com um CPF já existente, a API 
deve retornar uma mensagem de erro.
* Delete: O endpoint deve excluir o usuário com base no CPF. Caso o usuário a ser 
excluído não seja encontrado, a API deve retornar uma mensagem de erro.
* Get: Dois endpoints devem ser implementados. Um para buscar um usuário por 
meio do CPF e outro para listar todos os usuários.

### Observações Adicionais:
* Utilize o Google, YouTube, ChatGPT ou qualquer outra fonte disponível para 
auxiliar no desenvolvimento.
* Inclua comentários no código explicando a lógica implementada.

**Envio do Teste:** Ao finalizar, crie um repositório contendo suas observações para que 
seja possível realizar a avaliação.

**Critérios de Avaliação:** Os candidatos serão avaliados com base no conhecimento 
técnico, na habilidade para resolver problemas de forma eficiente e na aplicação de boas 
práticas de código
