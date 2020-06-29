# ZALLPY CHALLENGE BACKEND (API) COM C# ASP.NET CORE

![Alt text](https://github.com/mauriciocontrole/zallpy_challenge_back/blob/master/zallpy_challenge_gif.gif?raw=true "Optional Title")



## SOFTWARES UTILIZADOS:
- MySQL 5.7 Command Line Client

- VSCode 1.46.1 x64

- SDK Flutter 1.17.2
- Android SDK version 29.0.3
- Android Studio 3.6

- Git 2.27.0


## BANCO DE DADOS

Para acesso ao MySQL, estão pré-definidas na API as seguintes credenciais:
- server=localhost
- port=3306 (porta padrão do MySQL)
- database=question_form
- uid=root
- password=1234

Caso seu MySQL esteja com uma senha diferente, faça a troca para "1234" ou então, altere o valor da chave "password" no arquivo chamado "appsettings.json" colocando a sua senha. Este arquivo se localiza no projeto "zallpy_challenge_back".


Escolha se prefere a inserção dos dados de forma automática ou manual e siga as instruções.


### BANCO DE DADOS - INSERÇÃO AUTOMÁTICA


1) Abra o "MySQL 5.7 Command Line Client".

2) Verifique qual é o caminho do arquivo "zallpy_challenge_database.sql" que está dentro do projeto "zallpy_challenge_back".

3) Utilize então o comando "SOURCE" para criar um novo banco já com a tabela e os registros inclusos.

Exemplo:
SOURCE C:/Users/mtss/Desktop/zallpy/01_project/zallpy_challenge_back/zallpy_challenge_database.sql;

4) Verifique se o banco foi criado corretamente.


### BANCO DE DADOS - INSERÇÃO MANUAL


1) Abra o "MySQL 5.7 Command Line Client".

2) Execute as seguintes querys para preparar o banco:

CREATE DATABASE question_form;

SHOW DATABASES;

USE question_form;

CREATE TABLE questions(Id INT NOT NULL, QuestionBody VARCHAR(100) NOT NULL, AnswerCorrect CHAR(2) NOT NULL, PRIMARY KEY(Id));

SHOW TABLES;

INSERT INTO questions (Id, QuestionBody, AnswerCorrect) VALUES (1, 'Qual é a origem da BMW?', 'A3');
INSERT INTO questions (Id, QuestionBody, AnswerCorrect) VALUES (2, 'Qual é a origem da Toyota?', 'A4');
INSERT INTO questions (Id, QuestionBody, AnswerCorrect) VALUES (3, 'Qual é a origem da Mini?', 'A1');
INSERT INTO questions (Id, QuestionBody, AnswerCorrect) VALUES (4, 'Qual é a origem da General Motors?', 'A2');
INSERT INTO questions (Id, QuestionBody, AnswerCorrect) VALUES (5, 'Qual é a origem da Rolls-Royce?', 'A1');

SELECT * FROM questions;

3) Verifique se o banco foi criado corretamente.


## BACKEND (API)


1) Faça o clone do repositório do projeto back: 
> git clone https://github.com/mauriciocontrole/zallpy_challenge_back.git

2) Foi utilizado o pacote Pomelo para comunicação do sistema Back/API e o MySQL:
> dotnet add package Pomelo.EntityFrameworkCore.MySql --version 3.1.1

3) Baixa todas as dependências do projeto:
> dotnet restore

4) Abra o VSCode dentro da pasta do projeto.

5) Aperte Ctrl+F5 para iniciar a API.


## FRONTEND


ATENÇÃO: Este projeto se baseou na utilização de um emulador. Desta maneira, o endereço de IP configurado para que o front busque os dados é "10.0.2.2".


1) Faça o clone do repositório do projeto: 
git clone https://github.com/mauriciocontrole/zallpy_challenge_front.git

2) Abra o projeto utilizando o Android Stuido (ou outro de sua preferência).

3) Abra um emulador.

4) Aperte o play para carregar o APP.


## REFERÊNCIAS


BACK/API
- [Preparar o ambiente do VSCode](https://medium.com/danielpadua/vscode-asp-net-core-preparar-ambiente-de-desenvolvimento-adf30cefea07)
- [Tutorial de criação de uma WebAPI](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio-code)
- [Criação de uma webAPI e arquitetura(Models, Controllers, Data)](https://www.youtube.com/watch?v=but7jqjopKM)
- [Integração com o MySQL utilizando o pacote Pomelo.](https://www.youtube.com/watch?v=_jdsAOGiiC8)


FRONT
- [Resolução de problema de conexão HTTP (Certificado SSL).](https://github.com/flutterchina/dio/issues/32#issuecomment-487401443)
- [Instrução condicional.](https://www.it-swarm.dev/pt/dart/como-usar-instrucao-condicional-no-atributo-filho-de-um-widget-de-flutter-widget-central/836981321/)
- [Utilização do "then".](https://stackoverflow.com/a/53543019/13815325)
- [Endereço de IP "10.0.2.2".](https://stackoverflow.com/a/9515414/13815325)
