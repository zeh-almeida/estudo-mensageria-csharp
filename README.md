# Implementação do Estudo de Mensageria em C#

## Objetivo
Implementar o [Estudo de Mensageria](https://github.com/zeh-almeida/estudo-mensageria) usando C# e Dotnet.

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

#### Casos de Uso
![Caso de Uso](UseCase.drawio.png)

#### Arquitetura
![Arquitetura](Arquitetura.drawio.png)

#### Observações
A implementação será feita primeiramente usando o modelo de `Monolito`, onde um único projeto é responsável por todas as funções.

A medida que se tem andamento na implementação, a solução vai ser refatorada para usar o padrão de micro-serviços onde possível.
