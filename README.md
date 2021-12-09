# Estudo de Mensageria

## Objetivo

### Definição do serviço
Implementar um serviço que envie e receba mensagens com serviços externos.

O serviço deve ser capaz de:
* Enviar mensagens para um tópico específico;
* Receber mensagens de um tópico específico;
* Redefinir o tópico de envio;
* Redefinir o tópico de recebimento;

Para as funções de envio e redefinição de tópicos é necessário que o seviço implemente uma `API HTTP JSON`:
* A função de envio de mensagens deve ser feita via `GET`;
* A função de redefinição do tópico de envio deve ser feita via `POST`;
* A função de redefinição do tópico de recebimento deve ser feita via `POST`;

A função de recebimento de mensagens deve rodar automaticamente no background enquanto a aplicação estiver online.

#### Definição da Mensagem
As mensagens enviadas devem seguir um padrão:
* Máximo de 130 caracteres UTF-8;
* Não pode ser vazia;
* Não pode ser nula;
* Contém a data de envio do cliente em UTC;
* Contém o número do IP do cliente;

Ao receber a mensagem, o serviço deve persisti-la com todos os dados acima mais a data de recebimento, também em UTC.

### Implementação
A implementação do projeto deve seguir padrões de [TDD](https://en.wikipedia.org/wiki/Test-driven_development);
Devem ser implementados [testes de integração](https://en.wikipedia.org/wiki/Integration_testing);

O projeto deve ser publicado em uma cloud.
Para isso, deve ser usado o [Terraform](www.terraform.io).

O deploy também deve ser automatizado, utilizando [GitHub Actions](https://github.com/features/actions).

### Execução
Durante a execução do projeto, devem ser feitas tarefas via board, no modelo de [User Story](https://en.wikipedia.org/wiki/User_story).

Isso ajuda a definir os comportamentos esperados e dessa forma, garante que os testes sejam mais eficazes.
