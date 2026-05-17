# Crypto Money

Plataforma web completa para negociação de criptomoedas (Bitcoin, Ethereum, BNB, USDT). Sistema fullstack com autenticação de usuários, painel administrativo e interface responsiva.

Projeto desenvolvido como trabalho acadêmico na Faculdade de Tecnologia de Jundiaí – Deputado Ary Fossen (FATEC Jundiaí).

**Autores:** Pedro Dutra & Guilherme Lopes

---

## Índice

- [Visão Geral](#visão-geral)
- [Stack Tecnológico](#stack-tecnológico)
- [Requisitos do Sistema](#requisitos-do-sistema)
- [Instalação e Configuração](#instalação-e-configuração)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Funcionalidades](#funcionalidades)
- [Banco de Dados](#banco-de-dados)
- [Troubleshooting](#troubleshooting)

---

## Visão Geral

Crypto Money é uma aplicação web que simula uma plataforma de negociação de criptomoedas com sistema completo de autenticação e gerenciamento de usuários.

| Aspecto | Descrição |
|---|---|
| **Tipo** | Aplicação Web Fullstack |
| **Modelo** | Fictícia / Educacional |
| **Funcionalidade Principal** | Compra e venda de criptomoedas |
| **Foco** | Sistema de autenticação robusto |

---

## Stack Tecnológico

| Camada | Tecnologias |
|---|---|
| **Frontend** | HTML5, CSS3, JavaScript, Bootstrap 5 |
| **Backend** | PHP 7.4+ |
| **Banco de Dados** | MySQL / MariaDB |
| **Validação** | JavaScript (Client-side), PHP (Server-side) |

---

## Requisitos do Sistema

- **PHP:** 7.4 ou superior
- **MySQL/MariaDB:** 5.7+
- **Servidor Local:** XAMPP, WAMP, Laragon ou similar
- **Navegador:** Versão recente (Chrome, Firefox, Safari, Edge)

---

## Instalação e Configuração

### Passo 1: Preparar o Servidor
1. Instale um servidor local (XAMPP, WAMP ou Laragon)
2. Inicie os serviços de PHP e MySQL
3. Coloque o projeto na pasta raiz do servidor (ex: `htdocs` no XAMPP)

### Passo 2: Configurar o Banco de Dados
1. Acesse o phpMyAdmin (`http://localhost/phpmyadmin`)
2. Crie um banco de dados chamado `login`
3. Importe o arquivo `sql/login.sql`:
   - Selecione o banco `login`
   - Vá para "Importar"
   - Escolha o arquivo `sql/login.sql`
   - Clique em "Executar"

### Passo 3: Configurar Conexão
1. Abra `php/conexao.php`
2. Verifique as credenciais:
   ```php
   $host = "localhost";
   $user = "root";
   $password = "";
   $database = "login";
   ```
3. Ajuste conforme sua configuração do servidor

### Passo 4: Acessar a Aplicação
```
http://localhost/cripto-money/html/index.html
```
(O caminho pode variar conforme a estrutura do seu servidor)

---

## Estrutura do Projeto

```
cripto-money/
├── html/
│   └── index.html              Página inicial
├── php/
│   ├── conexao.php             Configuração de banco de dados
│   ├── cadastro.php            Formulário de cadastro
│   ├── cadastrar.php           Lógica de cadastro
│   ├── login.php               Formulário de login
│   ├── logar.php               Lógica de autenticação
│   ├── painel.php              Dashboard do usuário
│   ├── logout.php              Encerrar sessão
│   └── verifica_login.php      Middleware de autenticação
├── css/
│   ├── style.css               Estilos gerais
│   ├── form.css                Estilos de formulários
│   └── verificacao.css         Estilos de validação
├── js/
│   └── mascara.js              Máscaras de entrada (CPF, etc)
├── assets/
│   ├── images/                 Imagens da plataforma
│   └── icons/                  Ícones e favicon
├── sql/
│   └── login.sql               Script do banco de dados
└── README.md                   Documentação

```

---

## Funcionalidades

### Público (Não Autenticado)
- Visualizar página inicial
- Informações sobre criptomoedas suportadas
- Formulário de cadastro
- Formulário de login

### Autenticado
- Dashboard personalizado
- Visualizar saldo
- Histórico de transações
- Realizar operações de compra/venda
- Gerenciar perfil
- Logout seguro

---

## Banco de Dados

### Tabela Principal: `users`

| Campo | Tipo | Descrição |
|---|---|---|
| `id` | INT | Identificador único |
| `name` | VARCHAR(100) | Nome completo |
| `email` | VARCHAR(100) | Email único |
| `password` | VARCHAR(255) | Senha criptografada |
| `created_at` | TIMESTAMP | Data de criação |

**Nota:** Verifique `sql/login.sql` para detalhes completos do schema.

---

## Troubleshooting

### Erro: "Não consegue conectar ao banco de dados"
- Verifique se MySQL está rodando
- Confirme credenciais em `php/conexao.php`
- Certifique-se que o banco `login` foi criado

### Erro 404 ao acessar a página
- Confirme o caminho correto: `http://localhost/cripto-money/html/index.html`
- Verifique a estrutura de pastas
- Reinicie o servidor Apache

### Sessão não persiste após login
- Verifique se o PHP está com suporte a sessões
- Confirme as permissões de pasta (TEMP)
- Teste em um navegador diferente

### Formulário não funciona
- Verifique se JavaScript está habilitado
- Abra o console do navegador (F12) e procure por erros
- Confirme que `js/mascara.js` está sendo carregado

---

Desenvolvido como projeto educacional por FATEC Jundiaí
