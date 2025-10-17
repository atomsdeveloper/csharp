// A ideia é ter uma raiz de nó, cada nó com no máximo dois filhos (esquerdo e direito). Onde o da esquerda sendo menor que a raiz e o da direita sendo maior que a raiz.

// A busca em uma árvore de busca binária é eficiente, com complexidade média de O(log n) para operações de busca, inserção e remoção, desde que a árvore esteja balanceada. No entanto, no pior caso (quando a árvore está desbalanceada), essas operações podem ter complexidade O(n).

// Percurso de árvore de pesquisa binária:

// Pré-encomenda (Pre-order).
// 1. Raiz através do nó raiz.
// 2. Passe pela subárvore esquerda.
// 3. Passe pela subárvore direita.

// Em ordem (In-order).
// 1. Passe pela subárvore esquerda.
// 2. Raiz através do nó raiz.
// 3. Passe pela subárvore direita.

// Pós-encomenda (Post-order).
// 1. Passe pela subárvore esquerda.
// 2. Passe pela subárvore direita.
// 3. Raiz através do nó raiz.

// A estrutura de dados SortedList usan internamente uma árvore de busca binária para armazenar seus elementos em ordem classificada com base nas chaves.