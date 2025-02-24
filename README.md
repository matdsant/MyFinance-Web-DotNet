# 🧮 MyFinance-Web-DotNet

📌 **MyFinance** é um projeto do Curso de Pós-Graduação em Engenharia de Software da PUC-MG.

## 📖 Sobre o Projeto

O **"MyFinance Web"** é um sistema para controle de finanças pessoais, desenvolvido como uma aplicação web baseada no padrão **MVC (Model-View-Controller)** com **ASP.NET Core** na versão **.NET 6.0.**. O banco de dados utilizado será o **SQL Server** e o repositório do projeto será gerenciado via **GitHub**, permitindo o controle de versões e acompanhamento das alterações realizadas.

Durante o desenvolvimento, abordaremos aspectos como questões arquiteturais, técnicas de manutenção e refatoração de código, além de práticas de testes e implantação. Mais detalhes sobre a disciplina serão fornecidos no módulo inicial do curso.

## 🚀 Tecnologias Utilizadas
- **C#**
- **.NET Core**
- **ASP.NET MVC**
- **Entity Framework Core**
- **SQL Server**
- **Bootstrap (para estilização da interface)**

## 📂 Estrutura do Projeto
A estrutura básica do projeto segue o padrão MVC:

```bash
MyFinance-Web-DotNet/
├── Controllers/        # Controladores da aplicação
├── Models/            # Modelos da aplicação
├── Views/             # Arquivos de interface (HTML + Razor)
├── wwwroot/           # Arquivos estáticos (CSS, JS, imagens)
├── appsettings.json   # Configurações da aplicação
├── Program.cs         # Configuração inicial do projeto
├── Startup.cs         # Configuração dos serviços e middleware
```
## 🚀 Como Construir e Executar

#### 🔧 Requisitos

- .NET SDK instalado
- Editor de código, como Visual Studio Code ou Visual Studio

#### 📥 Clonar o repositório

O projeto está alocado no repositório em questão
```
$ git clone https://github.com/seu-usuario/MyFinance-Web-DotNet.git
```
```
$ cd MyFinance-Web-DotNet/myfinance-web-dotnet
```
#### 🏗 Construção do Projeto
```
$ dotnet build
```
Se a construção for bem-sucedida, o executável será gerado em ```bin/Debug/net9.0/myfinance-web-dotnet.dll.```

#### ▶ Executando a Aplicação
Comando que deve ser utilizado:
```
$ dotnet run
```
A aplicação estará diponível:
```
Now listening on: http://localhost:5240
```
E para encerrar sua execução, pressione **Ctrl+C**.


#### 📝 Licença

Este projeto está sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.


## 🔍 Descrição do Problema

#### Proposta

Vamos criar uma aplicação web para que famílias possam registrar suas receitas e despesas para análise de seus gastos e consequentemente um melhor planjeamento financeiro.
Esta aplicação deve permitir que o usuário monte uma espécie de Plano de Contas para categorizar todas as Transações realizadas. É importante que se tenha também relatórios de despesas por período, permitindo uma análise detalhada das finanças.


**RF001** - Plano de Contas: O sistema deve permitir o cadastro de Plano de Contas para categorização das Receitas e Despesas previamente estabelecidas.

**Exemplo**:

![image](https://github.com/user-attachments/assets/fec68eae-d997-4864-8998-986efe25dccc)

