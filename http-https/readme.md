# O que é HTTP e HTTPS

> É um protocolo de comunicação da `camada de aplicação` baseado em `TCP/IP` que padroniza a forma como cliente e servidor se comunicam.
> Ele define como o conteúdo é solicitado e transmitido pela internet. As portas são `80 para HTTP` e `433 para HTTPS`.

## HTTP/0.9 - A frase de efeito (1991)

> A versão mais simples do HTTP que é o `HTTP/0.9` (1991) consiste em apenas um único método `GET` para solicitções vindas do cliente até o servidor.
> O servidor recebe a requisição, responde com um `HTML` e, assim que o cliente recebe o conteúdo a conexão era encerrada.

- Não possuia cabeçalhos.
- `GET` era o únivo método permitido.
- Resposta do servidor era obrigatóriamente um `HTML`.

## HTTP/1.0 - (1996)

> Nesta nova versão o `HTTP` pode lidar com outros formatos de respostas, como imagens, arquivos de vídeo, textos simples ou qualquer outro tipo de conteúdo.
> Métodos como o `POST` e `HEAD` foram adicionados. Formatos de respostas/solicitação foram alterados, novos cabeçalhos foram adcionados na resposta/solicitação.
> Foram adcionados códigos de `STATUS` para identificar as respostas do servidor. Suporte a conjunto de caracteres, multipartes, autorização, cache e codificação de conteúdo...
> Nesta versão os cabeçalhos de solicitação e resposta ainda eram codificados em `ASCII` mas o corpo da resposta poderia ser de qualquer tipo. Dessa forma o servidor poderia enviar qualquer tipo de conteúdo para o cliente.
> Uma das suas principais desvantagens é que não se poderia ter múltiplas requisições por conexão. Ou seja, sempre que o cliente precisava de um novo conteúdo era necessário abrir uma nova conexão `TCP`.

### Handshake - Aperto de mão triplo.

> Isso indica que todas as conexões `TCP` começam com um handshake triplo no qual o cliente e o servidor compartilham uma série de pacotes antes de começar a compartilhar os dados do app.

- SYN o cliente pega um número aleatório e envia para o servidor.
- SYN ACK o server reconhece a solicitação enviando um pacote ACK de volta para o cliente que também é composto por um número aleatório captado pelo server, X + 1 é adicionado ao número aleatório enviado pelo cliente em SYN
- ACK o cliente incrementa o número Y recebido do server e envia um pacote ACK de volta com o número Y + 1.

> Após a conclusão do handshake triplo, o compartilhamento de dados entre cliente e server pode começar.

> Além de ser sem conexão, o `HTTP` é um protocolo sem estado, ou seja, o server não matém informações sobre o cliente e, portanto, cada requisição precisa ter as informações necessárias para que o server atenda a requisição por conta própria. isso causa um aumento no uso da largura de banda.

## HTTP/1.1 - (1997)

> Foi criada para melhorar e adicionar ainda mais recursos que na versão anterior.
> Novos métodos `HTTP` foram adicionados, que introduziram `PUT`, `PATCH`, `OPTIONS` e `DELETE`.
> Indentificação do nome do host nesta versão se tornou obrigatório.
> Introduzido conexões persistentes, ou seja, as conexões não eram fechadas por padrão o que permitia múltiplas requisições sequenciais, então para fechar as conexões, o cabeçalho `Connection: close` precisava estar disponivel na requisição para encerrar a conexão com segurança.
> Pipelining fora introduzido, onde o cliente poderia enviar várias requisições ao server sem esperar pela resposta do server na mesma conexão, e o server teria que enviar a resposta na mesma sequência em que as requisições foram recebidas

### Content-Length

> Como o cliente identifica que este é o ponto em que o download da primeira resposta é concluído e o conteúdo e quando deve começar o conteúdo da próxima resposta?
> Para resolver isso usa-se o `Content-Length` presente, onde o cliente indentifica onde a resposta termina e começar a aguardar a próxima resposta.
