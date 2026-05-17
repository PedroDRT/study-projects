# Tourist Spot - Busan

Landing page responsiva apresentando pontos turísticos de Busan, na Coreia do Sul. Projeto desenvolvido com foco em design moderno e experiência do usuário.

**Desenvolvido como projeto de aprendizado — Rocketseat**

---

## Índice

- [Visão Geral](#visão-geral)
- [Como Utilizar](#como-utilizar)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Seções da Página](#seções-da-página)
- [Stack Tecnológico](#stack-tecnológico)
- [Design](#design)
- [Personalização](#personalização)

---

## Visão Geral

| Característica | Descrição |
|---|---|
| **Tipo** | Página estática |
| **Linguagens** | HTML5, CSS3 |
| **Layout** | Responsivo (Mobile-first) |
| **Categoria** | Landing Page Informativa |
| **Requisitos** | Navegador moderno |

---

## Como Utilizar

### Execução Local

A aplicação não requer dependências ou configuração prévia. Basta abrir o arquivo `index.html` em um navegador:

1. Localize o arquivo `index.html` na pasta do projeto
2. Abra em seu navegador preferido (duplo clique ou arrastar para a aba)
3. A página carregará instantaneamente

**Navegadores suportados:** Chrome, Firefox, Safari, Edge (versões recentes)

---

## Estrutura do Projeto

```
tourist-spot/
├── index.html          Markup HTML5
├── style.css           Folha de estilos e layout responsivo
├── README.md           Documentação do projeto
└── assets/
    ├── image1.jpg      Imagem hero - Busan
    ├── image2.jpg      Templo Haedong Yonggungsa
    ├── image3.jpg      Templo Beomeo-sa
    └── image4.jpg      Parque Yongdusan
```

---

## Seções da Página

### Header
- Mensagem introdutória: "Sua próxima viagem"
- Título: "Conheça Busan"
- Seção hero com imagem de destaque e descrição da cidade

### Conteúdo Principal
A página apresenta três pontos turísticos estratégicos:

| Destino | Localização | Características |
|---|---|---|
| **Templo Haedong Yonggungsa** | Extremo nordeste de Busan | Único templo budista à beira-mar; construído em 1376; vista panorâmica do Mar do Leste |
| **Templo Beomeo-sa** | Montanha Geumjeongsa | Um dos maiores santuários do país; arquitetura preservada da Dinastia Joseon |
| **Parque Yongdusan** | Centro de Busan | Torre de 120m; 2 museus especializados; ambiente familiar |

---

## Stack Tecnológico

| Tecnologia | Descrição |
|---|---|
| **HTML5** | Estrutura semântica |
| **CSS3** | Layout responsivo, grid, flexbox |
| **Media Queries** | Adaptação para múltiplos dispositivos |

---

## Design

### Referência de Design
O layout foi desenvolvido baseado no design original disponível no Figma:  
[Local Turístico — Community](https://www.figma.com/design/NOYzad7CNP6NRMKBf2EvVD/Local-Tur%C3%ADstico--Community-?m=auto&t=zr5Aq9x1yyI4G0sn-6)

### Diretrizes Visuais
- **Paleta de cores:** Tons neutros com acentos em azul e verde
- **Tipografia:** Hierarquia definida com contraste de tamanhos
- **Espaçamento:** Layout generoso com divisores para separação de conteúdo
- **Imagens:** Otimizadas para web em resolução alta

---

## Personalização

### Modificar Conteúdo
1. Abra `index.html` em um editor de texto
2. Altere os títulos (tags `h1`, `h2`, `h3`) e descrições conforme necessário
3. Substitua as imagens em `assets/` mantendo a estrutura de diretórios

### Customizar Estilos
1. Abra `style.css`
2. Ajuste variáveis de cor, tipografia e dimensões
3. Recarregue a página no navegador para visualizar as mudanças

### Adicionar Novos Destinos
Para expandir a seção de destinos, adicione um novo bloco `<article>`:

```html
<article>
  <img src="assets/imageX.jpg" alt="Descrição da imagem">
  <h3>N. Nome do Destino</h3>
  <p class="description">Descrição detalhada do destino...</p>
  <p>Bom para:</p>
  <ul>
    <li>Público-alvo 1</li>
    <li>Público-alvo 2</li>
  </ul>
</article>
```

---

## Informações Técnicas

| Aspecto | Detalhe |
|---|---|
| **Compatibilidade** | Chrome, Firefox, Safari, Edge (versões modernas) |
| **Breakpoints** | Responsivo de 320px até 1920px |
| **Paths** | Imagens com caminhos relativos em `assets/` |
| **Performance** | Sem dependências externas; carregamento imediato |

---

Desenvolvido como projeto educacional pela Rocketseat