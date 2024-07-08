# API_Teste_Playmove

API que trata a chamada das requisições do Teste aplicado pela Playmove.


* Framework: .Net 7.0.402 
* Linguagem de Programação: C#
* CORS: (appsettings.json)

![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/b6fd8f5e-a213-431e-8358-846a47bbceb0)



![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/81d41fc5-4073-4da6-a4fe-9b7a1ce6b1a7)


## BANCO DE DADOS

* Database Name: FornecedoresDB
* Porta 30306
* Usuário de aplicação: root
* Senha do usuário de aplicação: admin2024
* Acesso via aplicação: (MariaDb) - DBeaver 24.1.1

## SCRIPT CRIAÇÃO DO BANCO DE DADOS

### Empresas
![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/af75d78e-4d58-4f07-a9d8-cd7755cee77f)


### Fornecedores
![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/4bd8f342-e22e-41e5-bd71-f3dc14311833)




____________________________________________________________________________________________________

# Documentação da API de Fornecedores
## Endpoints
### Listar Fornecedores
Retorna uma lista de todos os fornecedores cadastrados.

* URL
![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/7ad430d0-87b7-4408-979a-4980b3a8c17a)



* Códigos de Resposta

200 OK: Retorna a lista de fornecedores com sucesso,
500 Internal Server Error: Erro interno ao listar fornecedores.

* Exemplo de Resposta

![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/3d6efa9b-0240-43fa-b82e-6567b52dab8d)



## Obter Fornecedor por ID
Retorna um fornecedor específico com base no ID fornecido.

* URL
  
![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/07f7e857-0e84-4591-a2ad-6047dea6ec2a)


* Parâmetros da Requisição
  
id (int): ID do fornecedor a ser obtido.

* Códigos de Resposta

200 OK: Retorna o fornecedor com sucesso,
404 Not Found: Fornecedor não encontrado,
500 Internal Server Error: Erro interno ao obter fornecedor.

* Exemplo de Resposta
![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/6cbc33b3-d19c-44da-886f-a9327fb4bf6c)


## Salvar Fornecedor
Salva um novo fornecedor.

* URL
  
 ![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/fd635797-6536-43c8-b5f3-3f5f1d1ffd94)


* Corpo da Requisição
![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/2546277a-c29d-4ede-b893-1d9045dea32c)



* Códigos de Resposta

200 OK: Fornecedor salvo com sucesso,
400 Bad Request: Requisição inválida,
500 Internal Server Error: Erro interno ao salvar fornecedor.


## Atualizar Fornecedor
Atualiza os dados de um fornecedor existente.

* URL
  
![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/3557fd51-4ece-4559-a956-cb64598514b6)


* Parâmetros da Requisição

id (int): ID do fornecedor a ser atualizado.

* Corpo da Requisição
![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/b648c976-3059-4c2b-a994-e243ce70fd78)


* Códigos de Resposta

200 OK: Fornecedor atualizado com sucesso,
400 Bad Request: Requisição inválida,
500 Internal Server Error: Erro interno ao atualizar fornecedor.

## Deletar Fornecedor
Remove um fornecedor com base no ID fornecido.

* URL
  
![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/dc136afa-a5af-4cad-b768-574b5312f47a)


* Parâmetros da Requisição
  
id (int): ID do fornecedor a ser deletado.

* Códigos de Resposta

200 OK: Fornecedor deletado com sucesso,
400 Bad Request: Requisição inválida,
500 Internal Server Error: Erro interno ao deletar fornecedor.


_____________________________________________________________________________________________________
# Documentação da API de Empresas
## Endpoints
### Listar Empresas
Retorna uma lista de todas empresas cadastradas.

* URL
  
![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/1e5b080d-cf4c-4c5c-846d-251a6a12c2d1)


* Códigos de Resposta

200 OK: Retorna a lista de empresas com sucesso,
500 Internal Server Error: Erro interno ao listar empresas.

* Exemplo de Resposta

![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/0e69b7f3-8d71-48e7-b98c-664a2c985d61)


## Obter Empresa por ID
Retorna uma empresa específica com base no ID fornecido.

* URL
  
![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/89696297-24f5-4d16-a813-46959256640b)


* Parâmetros da Requisição
  
id (int): ID da empresa a ser obtida.

* Códigos de Resposta

200 OK: Retorna a empresa com sucesso,
404 Not Found: Empresa não encontrada,
500 Internal Server Error: Erro interno ao obter empresa.

* Exemplo de Resposta
![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/5ce2d2e9-56ff-4554-a712-5c4fb884714e)


## Salvar Empresa
Salva uma nova empresa.

* URL
  
![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/c94dd791-1c26-459e-92b6-eb61b8551d34)



* Corpo da Requisição
![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/37c0dc9b-36f8-48e2-8a76-17e0ad7a41e1)



* Códigos de Resposta

200 OK: Empresa salva com sucesso,
400 Bad Request: Requisição inválida,
500 Internal Server Error: Erro interno ao salvar empresa.


## Atualizar Empresa
Atualiza os dados de uma empresa existente.

* URL
  
![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/205bd592-ccfe-4aac-a699-6b977aa64c43)


* Parâmetros da Requisição

id (int): ID da empresa a ser atualizada.

* Corpo da Requisição
![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/c033c83a-5343-4d04-bff2-81bd2100c087)


* Códigos de Resposta

200 OK: Empresa atualizada com sucesso,
400 Bad Request: Requisição inválida,
500 Internal Server Error: Erro interno ao atualizar empresa.

## Deletar Empresa
Remove uma empresa com base no ID fornecido.

* URL
  
![image](https://github.com/fjunior9876/Teste_Playmove/assets/94969208/c88b1edb-1073-41af-9b66-60351c38490a)


* Parâmetros da Requisição
  
id (int): ID da empresa a ser deletada.

* Códigos de Resposta

200 OK: Empresa deletada com sucesso,
400 Bad Request: Requisição inválida,
500 Internal Server Error: Erro interno ao deletar empresa.



## LICENÇA

Todos os direitos reservados a [Playmove](https://playmove.com.br/)


