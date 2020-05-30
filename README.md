# api_net_core_jwt_ef_core

API padrão para criação de projetos que necessitam de um login basico e tendem a utilizar Entity Framework Core

# Prerequesitos
  MySql
  
  Docker

# Inicializando projeto

Visual Studio 2019

> Package Manager Console  
>> update-database

> Iniciar projeto no VS 2019

# Arquitetura do projeto:

Backend (WebApi):
	
	> Repository: Utilizando EF Core, faz acesso ao banco de dados. É chamado em outras partes do projeto via DependencyInjection.
	
	> Service: executam as regras de negocio, sendo a ligação entre a Controller e o Repository. É chamado em outras partes do projeto via DependencyInjection.
	
	> Controller: Recebem as requisições do e chaman o Service via DependencyInjection.
  
	
# Ferramentas adicionais usadas

AutoMapper DependencyInjection v7.0.0: 
  > utilizado para fazer a transformação de objetos que chegam da requisição para os objetos utilizados dentro do sistema.
  
  > https://www.codementor.io/@zedotech/how-to-using-automapper-on-asp-net-core-3-0-via-dependencyinjection-zq497lzsq


JWT v3.1.4:
  > utilizado para gerar tokens de acesso a api
  
  > https://balta.io/blog/aspnetcore-3-autenticacao-autorizacao-bearer-jwt
  

Entity Framework Core v3.1.4:
  > utilizado para fazer a comunicação com o banco de dados
  
  > http://www.macoratti.net/17/05/efcore_mysql1.htm


Entity Framework Core MySql:
  > utilizado para possibilitar a integração do EF Core com o banco MySql
  
  > http://www.macoratti.net/17/05/efcore_mysql1.htm
  

DependencyInjection:
  > Utilizado para facilitar a instancia de classes Repository, Service entre outras no sistema


Postman:
  > utilizado para consumir os endpoints
  
  > utilizar a collection "api_net_core_jwt_ef_core.postman_collection" na raiz do repositorio para consumir os endpoints
