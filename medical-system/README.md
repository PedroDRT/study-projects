# Medical System

Sistema de gerenciamento médico desktop desenvolvido em C# com Windows Forms. Plataforma para cadastro de pacientes, médicos e agendamento de consultas com sistema de autenticação.

Projeto desenvolvido como trabalho acadêmico na Senac Jundiaí.

---

## Índice

- [Visão Geral](#visão-geral)
- [Stack Tecnológico](#stack-tecnológico)
- [Requisitos do Sistema](#requisitos-do-sistema)
- [Instalação e Configuração](#instalação-e-configuração)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Arquitetura](#arquitetura)
- [Funcionalidades](#funcionalidades)
- [Banco de Dados](#banco-de-dados)
- [Guia de Uso](#guia-de-uso)

---

## Visão Geral

Medical System é uma aplicação desktop para gerenciamento de consultórios médicos, oferecendo funcionalidades completas de cadastro, autenticação e agendamento de consultas.

| Aspecto | Descrição |
|---|---|
| **Tipo** | Aplicação Desktop |
| **Plataforma** | Windows |
| **Modelo** | Cliente-Servidor com banco de dados centralizado |
| **Foco** | Gerenciamento médico e agenda de consultas |

---

## Stack Tecnológico

| Camada | Tecnologias |
|---|---|
| **Frontend** | Windows Forms, .NET Framework 4.7.2 |
| **Backend** | C# 7.0+, padrão DAO |
| **Banco de Dados** | SQL Server / SQL Server Express |
| **Arquitetura** | DAO + Entidades + Model |

---

## Requisitos do Sistema

### Ambiente de Desenvolvimento
- **Visual Studio:** 2015 ou superior (Community, Professional ou Enterprise)
- **.NET Framework:** 4.7.2 ou superior
- **SQL Server:** 2012 ou superior, ou SQL Server Express

### Requisitos de Execução
- **Windows:** 7 ou superior
- **.NET Framework 4.7.2** instalado no computador do usuário final
- **SQL Server** com acesso à base de dados `DBConsult`

---

## Instalação e Configuração

### Passo 1: Preparar o Ambiente
1. Instale o Visual Studio (versão Community é suficiente)
2. Instale o .NET Framework 4.7.2 (incluído no VS)
3. Instale SQL Server ou SQL Server Express

### Passo 2: Criar o Banco de Dados
1. Abra o SQL Server Management Studio
2. Crie um novo banco de dados chamado `DBConsult`
3. Execute os scripts SQL para criar as tabelas:
   - `cadcli` (clientes)
   - `medicos` (médicos)
   - `agenda` (consultas agendadas)

**Nota:** Os schemas das tabelas estão definidos nos respectivos DAOs do projeto.

### Passo 3: Configurar a Conexão
1. Abra o arquivo `SistemaMedico\App.config`
2. Localize a tag `<connectionStrings>`
3. Ajuste a connection string:
   ```xml
   <add name="ConsultDB" 
        connectionString="Data Source=SEU_SERVIDOR\SQLEXPRESS;Initial Catalog=DBConsult;Integrated Security=true;" />
   ```
   - Substitua `SEU_SERVIDOR` pelo nome do seu servidor SQL
   - Exemplos: `localhost`, `USUARIO-PC`, `.\SQLEXPRESS`

### Passo 4: Compilar e Executar
1. Abra `SistemaMedico.sln` no Visual Studio
2. Compile o projeto (Build → Build Solution ou Ctrl+Shift+B)
3. Execute a aplicação (Debug → Start Debugging ou F5)
4. A tela de login será exibida

---

## Estrutura do Projeto

```
medical-system/
├── SistemaMedico.sln               Solução Visual Studio
├── SistemaMedico/
│   ├── Program.cs                  Ponto de entrada da aplicação
│   ├── App.config                  Configuração (connection string)
│   │
│   ├── Formulários (Views)
│   ├── Login.cs                    Tela de autenticação
│   ├── SistemaMedico.cs            Menu principal
│   ├── CadastroCli.cs              Cadastro de clientes
│   ├── Medico.cs                   Gerenciamento de médicos
│   ├── Agendacli.cs                Agendamento de consultas
│   │
│   ├── DAO/                        Camada de acesso a dados
│   ├── clienteDAO.cs               Operações com clientes
│   ├── medicoDAO.cs                Operações com médicos
│   └── agendaDAO.cs                Operações com agenda
│   │
│   ├── Entidades/                  Modelos de dados
│   ├── clienteENT.cs               Entidade: Cliente
│   ├── medicoENT.cs                Entidade: Médico
│   └── agendaENT.cs                Entidade: Consulta
│   │
│   ├── Moldel/                     Camada de negócios
│   ├── clienteMODEL.cs             Lógica de clientes
│   ├── medicoMODEL.cs              Lógica de médicos
│   └── agendaMODEL.cs              Lógica de agenda
│   │
│   ├── Resources/                  Recursos (imagens, ícones)
│   ├── Properties/                 Configurações do projeto
│   └── SistemaMedico.csproj        Arquivo do projeto
│
├── .gitignore                      Arquivos ignorados pelo Git
└── README.md                       Esta documentação
```

---

## Arquitetura

A aplicação segue o padrão de três camadas:

### DAO (Data Access Object)
Responsável pela comunicação direta com o banco de dados. Implementa operações CRUD:
- `clienteDAO.cs` - Gerencia dados de clientes
- `medicoDAO.cs` - Gerencia dados de médicos
- `agendaDAO.cs` - Gerencia dados de consultas

### Entidades
Classes que representam os objetos de negócio:
- `clienteENT.cs` - Representa um cliente
- `medicoENT.cs` - Representa um médico
- `agendaENT.cs` - Representa uma consulta

### Model (Camada de Negócios)
Implementa a lógica de negócio e validação:
- `clienteMODEL.cs` - Regras de negócio para clientes
- `medicoMODEL.cs` - Regras de negócio para médicos
- `agendaMODEL.cs` - Regras de negócio para agenda

---

## Funcionalidades

### Autenticação
- Login seguro para acesso ao sistema
- Validação de credenciais via banco de dados

### Gerenciamento de Clientes
- Cadastro de novos pacientes
- Edição de informações (nome, CPF, idade, convênio)
- Listagem e pesquisa de clientes
- Exclusão de registros

### Gerenciamento de Médicos
- Cadastro de médicos
- Edição de dados profissionais
- Listagem de especialidades
- Gerenciamento de disponibilidade

### Agendamento de Consultas
- Agendar consultas para clientes
- Associar médicos disponíveis
- Definir data e horário
- Visualizar agenda
- Cancelar consultas

---

## Banco de Dados

### Tabela: cadcli (Clientes)

| Campo | Tipo | Descrição |
|---|---|---|
| `id_cli` | INT | Identificador único |
| `nome_cli` | VARCHAR(100) | Nome completo |
| `cpf_cli` | VARCHAR(14) | CPF formatado |
| `idade_cli` | INT | Idade |
| `convenio_cli` | VARCHAR(50) | Convênio de saúde |

### Tabela: medicos (Médicos)

| Campo | Tipo | Descrição |
|---|---|---|
| `id_med` | INT | Identificador único |
| `nome_med` | VARCHAR(100) | Nome completo |
| `crm_med` | VARCHAR(10) | CRM (Conselho Regional de Medicina) |
| `especialidade_med` | VARCHAR(50) | Especialidade |

### Tabela: agenda (Consultas)

| Campo | Tipo | Descrição |
|---|---|---|
| `id_agenda` | INT | Identificador único |
| `id_cli` | INT | FK - Cliente |
| `id_med` | INT | FK - Médico |
| `data_agenda` | DATE | Data da consulta |
| `hora_agenda` | TIME | Horário da consulta |
| `status_agenda` | VARCHAR(20) | Status (Agendada, Realizada, Cancelada) |

---

## Guia de Uso

### Iniciando o Aplicativo
1. Execute `SistemaMedico.exe` ou pressione F5 no Visual Studio
2. A tela de login será apresentada

### Tela de Login
- Insira as credenciais cadastradas
- Clique em "Entrar"
- Em caso de erro, verifique a conexão com o banco de dados

### Menu Principal
Após login bem-sucedido, você terá acesso a:
- **Cadastro de Clientes** - Gerenciar pacientes
- **Médicos** - Gerenciar corpo clínico
- **Agenda** - Agendar e visualizar consultas
- **Sair** - Encerrar a sessão

### Dicas
- Mantenha os dados de clientes e médicos sempre atualizados
- Valide disponibilidade de médicos antes de agendar
- Use a pesquisa para localizar registros rapidamente

---

Desenvolvido como projeto educacional por Senac Jundiaí
