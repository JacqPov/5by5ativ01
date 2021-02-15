# 5by5 Atividade 1

## Jogo da Velha

### Explicação: 
Criamos uma matriz 3 por 3, do tipo string para preencher com os valores X e O. Denominamos nossa matriz de tabuleiro.
Para o jogo, separamos em funções:  imprimir o mesmo; alocar as peças e informar se a posição desejada está livre ou ocupada. 

Caso o jogador informe um valor diferente de 0, 1 e 2 o programa irá solicitar novamente a inserção dos dados até que estes sejam informados corretamente.
Para validar o status do jogador separamos em 5 funções: empate, linha, coluna, diagonal primária e diagonal secundária.

Após, alocamos uma função para mostrar o status de cada jogador a partir das verificações feitas nas funções informadas acima; retornando 0 caso fosse empate, 1 caso o jogador 1 fosse o vencedor e 2 caso o jogador 2 fosse o vencedor e em seguida informando o fim do jogo.

### Como rodar

#### Clonar o projeto na maquina local - CLI

```bash
git clone https://github.com/JacqPov/5by5ativ01.git
```

após isso basta abrir o projeto em alguma IDE fazer o `build` e `run`.

#### Versão

v1.0  - 12/02/2021

#### Desenvolvedores

Jacqueline Povinelli

Saulo Godoy Proetti
