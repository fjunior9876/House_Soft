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
  ![image](https://github.com/fjunior9876/Playmove/assets/94969208/773ca813-3c7d-47b2-adf8-dfc51be5980b)


* Corpo da Requisição
![image](https://github.com/fjunior9876/Playmove/assets/94969208/f627c5ee-a50c-4378-9878-0c44cbb9df59)


* Códigos de Resposta

200 OK: Fornecedor salvo com sucesso,
400 Bad Request: Requisição inválida,
500 Internal Server Error: Erro interno ao salvar fornecedor.


## Atualizar Fornecedor
Atualiza os dados de um fornecedor existente.

* URL
![image](https://github.com/fjunior9876/Playmove/assets/94969208/405f6313-320a-4010-bc3d-827422a73626)

* Parâmetros da Requisição

id (int): ID do fornecedor a ser atualizado.

* Corpo da Requisição
![image](https://github.com/fjunior9876/Playmove/assets/94969208/75fc96f1-8cba-42af-8f3b-306e55c95414)

* Códigos de Resposta

200 OK: Fornecedor atualizado com sucesso,
400 Bad Request: Requisição inválida,
500 Internal Server Error: Erro interno ao atualizar fornecedor.

## Deletar Fornecedor
Remove um fornecedor com base no ID fornecido.

* URL
![image](https://github.com/fjunior9876/Playmove/assets/94969208/138bbb20-0940-4922-a2c5-aee5a332eb6f)

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
![image](https://github.com/fjunior9876/Playmove/assets/94969208/2af2b677-b473-4c4b-9a1c-f6a0cccdfe2c)

* Códigos de Resposta

200 OK: Retorna a lista de empresas com sucesso,
500 Internal Server Error: Erro interno ao listar empresas.

* Exemplo de Resposta

![image](https://github.com/fjunior9876/Playmove/assets/94969208/bebcb3a4-83bc-4398-a40d-7456091a96aa)

## Obter Empresa por ID
Retorna uma empresa específica com base no ID fornecido.

* URL
![image](https://github.com/fjunior9876/Playmove/assets/94969208/8306cb97-69c6-4747-a3b3-c11b16544367)

* Parâmetros da Requisição
  
id (int): ID da empresa a ser obtida.

* Códigos de Resposta

200 OK: Retorna a empresa com sucesso,
404 Not Found: Empresa não encontrada,
500 Internal Server Error: Erro interno ao obter empresa.

* Exemplo de Resposta
![image](https://github.com/fjunior9876/Playmove/assets/94969208/3fd754d0-524c-451f-a272-f84c357ee305)

## Salvar Empresa
Salva uma nova empresa.

* URL
![image](https://github.com/fjunior9876/Playmove/assets/94969208/a9db909e-9072-491e-836d-f1bb36fd1d61)


* Corpo da Requisição
![image](https://github.com/fjunior9876/Playmove/assets/94969208/fb50bbec-b2bf-473e-8f06-4af202c45202)


* Códigos de Resposta

200 OK: Empresa salva com sucesso,
400 Bad Request: Requisição inválida,
500 Internal Server Error: Erro interno ao salvar empresa.


## Atualizar Empresa
Atualiza os dados de uma empresa existente.

* URL
![image](https://github.com/fjunior9876/Playmove/assets/94969208/0be6e83c-22f6-4c81-9bc1-8d8004f26cfe)

* Parâmetros da Requisição

id (int): ID da empresa a ser atualizada.

* Corpo da Requisição
![image](https://github.com/fjunior9876/Playmove/assets/94969208/878d27b6-adb7-4ebf-99d5-dd3336e0a062)

* Códigos de Resposta

200 OK: Empresa atualizada com sucesso,
400 Bad Request: Requisição inválida,
500 Internal Server Error: Erro interno ao atualizar empresa.

## Deletar Empresa
Remove uma empresa com base no ID fornecido.

* URL
![image](https://github.com/fjunior9876/Playmove/assets/94969208/e694bb0d-6b64-423f-b15b-6fd08d83804e)

* Parâmetros da Requisição
  
id (int): ID da empresa a ser deletada.

* Códigos de Resposta

200 OK: Empresa deletada com sucesso,
400 Bad Request: Requisição inválida,
500 Internal Server Error: Erro interno ao deletar empresa.



## LICENÇA

Todos os direitos reservados a [Playmove](https://playmove.com.br/)


