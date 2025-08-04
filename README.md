# Crud Básico - Com Orientação a Objetos
Sistema Web para gerenciamento básico de dados com operações de Create, Read, Update e Delete.

# Descrição:
Aplicação desenvolvida com foco em orientação a objetos e boas práticas de arquitetura, utilizando o padrão MVC. O sistema permite realizar operações básicas de cadastro, edição, visualização e exclusão de registros em banco de dados.

A estrutura foi organizada em camadas, com destaque para o uso de Services, Entities e Enums, promovendo modularidade e reutilização de código. O projeto também utiliza Entity Framework com Migrations para gerenciamento do banco de dados MySQL.


# Objetivo
Aplicar os conceitos fundamentais da POO, como:
- Encapsulamento: organização e proteção dos dados internos das classes.
- Herança: reutilização de código entre classes relacionadas.
- Polimorfismo: flexibilidade na manipulação de objetos.
- Abstração: definição clara das responsabilidades de cada classe

# Funcionalidades 
- Listagem de registros (Select): exibe os dados armazenados.
- Atualização de registros (Update): permite modificar informações existentes.
- Exclusão de registros (Delete): remove dados do sistema.
  

## Padrão
- MVC (Model-View-Controller)
- Arquitetura em Camadas

## Design Patterns
- Separation of Concerns
- Service Layer Pattern
- Enum-based Logic

# :open_file_folder: Estrutura
A divisão das responsabilidades está organizada da seguinte maneira:

#### Controllers/
- Responsáveis por receber as requisições e direcionar para os serviços apropriados.

#### Services/
- Contêm a lógica de negócio e regras de validação.

#### Entities/
- Representam os modelos de dados utilizados na aplicação.

#### Enums/
- Definem constantes utilizadas para facilitar a leitura e manutenção do código.

#### Views/
- Interface do usuário construída com Razor Pages e Bootstrap.

#### Migrations/
- Gerenciamento da estrutura do banco de dados via Entity Framework.

# :hammer_and_wrench: Tecnologias

- [<img align="center" alt="CSharp" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg"> C#]
- [<img align="center" alt="aspnet" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original.svg"> ASP.NET Core]
- [<img align="center" alt="entity framework core" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original.svg"> Entity Framework Core]
- [<img align="center" alt="mysql" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/mysql/mysql-original.svg"> MySQL]
- [<img align="center" alt="bootstrap" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/bootstrap/bootstrap-original.svg"> Bootstrap]
- [<img align="center" alt="razor pages" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original.svg"> Razor Pages]


# :hammer_and_pick: Ferramentas

- [<img align="center" alt="VSCode" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/visualstudio/visualstudio-plain.svg"> Visual Studio]
- [<img align="center" alt="Git" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/git/git-original.svg"> Git](https://www.git.com/)
- [<img align="center" alt="GitHub" height="30" width="40" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/github/github-original.svg"> GitHub](https://git-scm.com/)


