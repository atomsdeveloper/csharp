# O que é HTTP e HTTPS

> É um protocolo de comunicação da `camada de aplicação` baseado em `TCP/IP` que padroniza a forma como cliente e servidor se comunicam. Ele define como o conteúdo é solicitado e transmitido pela internet. As portas são `80 para HTTP` e `433 para HTTPS`.

## HTTP/0.9 - A frase de efeito (1991)

> A versão mais simples do HTTP que é o `HTTP/0.9` (1991) consiste em apenas um único método `GET` para solicitações vindas do cliente até o servidor. O servidor recebe a requisição, responde com um `HTML` e, assim que o cliente recebe o conteúdo a conexão era encerrada.

- Não possuia cabeçalhos.
- `GET` era o único método permitido.
- Resposta do servidor era obrigatóriamente um `HTML`.

## HTTP/1.0 - (1996)

> Nesta nova versão o `HTTP` pode lidar com outros formatos de respostas, como imagens, arquivos de vídeo, textos simples ou qualquer outro tipo de conteúdo. Métodos como o `POST` e `HEAD` foram adicionados. Formatos de respostas/solicitação foram alterados, novos cabeçalhos foram adcionados na resposta/solicitação. Códigos de `STATUS` para identificar as respostas do servidor. Suporte a conjunto de caracteres, multipartes, autorização, cache e codificação de conteúdo também foram adcionados. Nesta versão os cabeçalhos de solicitação e resposta ainda eram codificados em `ASCII` mas o corpo da resposta poderia ser de qualquer tipo. Dessa forma o servidor poderia enviar qualquer tipo de conteúdo para o cliente. Uma das suas principais desvantagens é que não se poderia ter múltiplas requisições por conexão, ou seja, sempre que o cliente precisava de um novo conteúdo era necessário abrir uma nova conexão `TCP`.

### Handshake - Aperto de mão triplo.

> Isso indica que todas as conexões `TCP` começam com um handshake triplo no qual o cliente e o servidor compartilham uma série de pacotes antes de começar a compartilhar os dados do app.

- SYN o cliente pega um número aleatório e envia para o servidor.
- SYN ACK o server reconhece a solicitação enviando um pacote ACK de volta para o cliente que também é composto por um número aleatório captado pelo server, X + 1 é adicionado ao número aleatório enviado pelo cliente em SYN
- ACK o cliente incrementa o número Y recebido do server e envia um pacote ACK de volta com o número Y + 1.

> Após a conclusão do handshake triplo, o compartilhamento de dados entre cliente e server pode começar. Além de ser sem conexão, o `HTTP` é um protocolo sem estado, ou seja, o server não matém informações sobre o cliente e, portanto, cada requisição precisa ter as informações necessárias para que o server atenda a requisição por conta própria. isso causa um aumento no uso da largura de banda.

## HTTP/1.1 - (1997)

> Foi criada para melhorar e adicionar ainda mais recursos que na versão anterior. Novos métodos `HTTP` foram adicionados, `PUT`, `PATCH`, `OPTIONS` e `DELETE`. Indentificação do nome do host nesta versão se tornou obrigatório. Introduzido conexões persistentes, ou seja, as conexões não eram fechadas por padrão o que permitia múltiplas requisições sequenciais, então para fechar as conexões, o cabeçalho `Connection: close` precisava estar disponivel na requisição para encerrar a conexão com segurança. Esta versão incluia também auntenticação `digest` e `proxy.` como: `Cache`, `Intervalo de Bytes`, `Conjunto de Caracteres`, `Negociação de Linguagem`, `Cookies do Cliente`, `Suporte de comprenssão Aprimorado`, `Novos Códigos de Status` e mais.

> `Pipelining` fora introduzido, onde o cliente poderia enviar várias requisições ao server sem esperar pela resposta do server na mesma conexão, e o server teria que enviar a resposta na mesma sequência em que as requisições foram recebidas. Como o cliente identifica que este é o ponto em que o download da primeira resposta é concluído e o conteúdo e quando deve começar o conteúdo da próxima resposta?

> Para isso deve haver um cabeçalho `Content-Length`.

### Content-Length

> Usa-se o `Content-Length` presente, onde o cliente indentificar onde a resposta termina e começar a aguardar a próxima resposta. (de forma sequencial).

### Tranferências em Blocos

> No caso de conteúdo dinâmico, quando o servidor não consegue descobrir o `Content-Length` no ínicio da transmissão, ele pode começar a enviar o conteúdo em partes (bloco por bloco) e adicionar o `content-Length` para cada bloco quando enviado. Após todos os bloco serem enviados, ou seja, a transmissão completa foi concluída, é enviado um bloco vazio com o seu `Content-length` definido como zero para identificar para o cliente que a transmissão foi concluída. Para notificar o cliente sobre os status das transferências em blocos, o servidor inclui o cabeçalho `Transfer-Encoding: chunked`.

## SPDY - 2009

> Foi criado pela `GOOGLE` novos protocolos alternativos para tornar a web mais rápida e melhorar a sua segurança. Reduzindo as latências das páginas. Isso é uma marca registrada da `Google`e não uma sigla. Sabemos que se aumentarmos a largura de banda, o desempenho da de rede melhora, porém chega em um ponto em que não há muito ganho de desenpenho. Mas, se fizermos o mesmo com a latência, ou seja, se continuarmos diminuindo a latência, o ganho de desempenho é constante. Essa é a idéia central do `SPDY`: Diminuir a latência para aumentar o desempenho da rede.

- Latência: Atraso, ou seja, quanto tempo os dados levam para viajar entre a origem e o destino.
- Largura de Banda: Quantidade de dados que pode ser transferidos por segundos. (bits por segundo).

> Estes recursos incluiam, multiplexação, compressão, priorização, segurança e etc. Isso deu origin ao `HTTP/2`.

## HTTP/2 - 2015

> Este protocolo foi introduzido e projetado para transporte de conteúdo de baixa latência.

### Protocolo Binário

- Binário em vez de Textual.

> Isso é, protocolos binários são mais fácieis de serem revisados pela máquina, mas, não são fáciesi de serem lidos a olho nu. Seus principais blocos de contrução são `Frames` e `Streams`.

#### Quadros e Fluxos

> As mensagens `HTTP` agora são compostas por um ou mais quandros. Quadro `HEADERS` para todos os metadados e um quadro `DATA` para o payload, além de vários outros como `SETTINGS`, `RST_STREAM` e `PRIORITY`.

- Multiplexação / Várias solicitações `HTTP` assíncrnas em um única conexão.
- Compressçao de cabeçalhos usando `HPACK`.
- Server Push - Múltiplas respostas para uma única solicitação.
- solicitação Priorização.
- Segurança.

> Cada solicitação e resposta recebe um Id de fluxo exclusivo e é dividida em quadros. Quadros são pedaços binários de dados. Uma coleção de quadros é chamada de fluxo. cada quadro possui um ID único de fluxo que identifica o fluxo atual ao qual pertence, e cada quadro possui uma cabeçalho comum. Qualquer solicitação iniciada pelo cliente utiliza número ímpares e a resposta do server possui IDs de fluxo pares.

> Além dos `HEADERS` e `DATA`, outro tipo de quadro que é importante mensionar é o RST_STREAM, um tipo especial de quadro usado para abortar o fluxo, ou seja, o cliente pode enviar este quadro para informar ao server que não precisa mais daquele fluxo.

### Multiplexação

> uma vez aberta uma conexão `TCP`. todos os fluxos são enviados de uma forma assíncrina, ou seja, a resposta não tem ordem e o cliente usa o Id de fluxo atribuído para identificar o fluxo ao qual um pacote específico pertence. Isso resolve também o problema de bloqueio do cabeçlho de linha que esxistia no `HTTP/1.x`, ou seja o cliente não precisará esperar pela requisição que está demorando, e as outras requisições continuaram desndo precessadas.

### Compressão de cabeçalho

> Fazia parte de um `RFC` separada, cujo objetivo específico era otimizar os cabeçalhos enviados. A essência disso é que, quando acessamos o server constantemente a partir do mesmo cliente, há muitos dados redundantes que enviamos nos cabeçalhos repetidamente, e às vezes pode haver cookies aumentando o tamanho dos cabeçalhos, o que resulta em uso de largura de banda e aumento da latência, Para superar isso, o `HTTP/2` introduziu a compactação de cabeçalhos.

> Diferente de solicitações e resposta, os cabeçalhos não são compactos nos formatos `gzip` ou `compress` etc., mas hà um mecanismo diferente para a compactação de cabeçalhos, no qual os valores literais são codificados usando o código `Huffman` e uma tabela de cabeçalhos é mantida pelo cliente e pelo server, e tanto o cliente qunato o server omitem quaisquer cabeçalhos repetitivos nas solicitações subsequentes e os referenciam usando a tabela de cabeçalhos mantida por ambos.
