# API

* Framework: .Net 7.0.402 
* Linguagem de Programação: C#
* CORS: (appsettings.json)

![image](https://github.com/fjunior9876/Playmove/assets/94969208/efde41e1-b3b9-4b1c-a7a4-4cbddb316a77)


![image](https://github.com/fjunior9876/Playmove/assets/94969208/088eb99d-f739-442d-891d-b3d12279a6af)

## BANCO DE DADOS

* Database Name: FornecedoresDB
* Porta 30306
* Usuário de aplicação: root
* Senha do usuário de aplicação: admin2024
* Acesso via aplicação: (MariaDb) - DBeaver 24.1.1

## SCRIPT CRIAÇÃO DO BANCO DE DADOS

### Empresas
![image](https://github.com/fjunior9876/Playmove/assets/94969208/c0cba818-a9be-485e-85a2-c27742bb372f)

### Fornecedores
![image](https://github.com/fjunior9876/Playmove/assets/94969208/b8f84fe5-77e5-42f1-bbea-b63cfc17d869)


____________________________________________________________________________________________________

# Documentação da API de Fornecedores
## Endpoints
### Listar Fornecedores
Retorna uma lista de todos os fornecedores cadastrados.

* URL
![image](https://github.com/fjunior9876/Playmove/assets/94969208/76b8a5d0-0175-4d2a-a924-91f2dede680c)


* Códigos de Resposta

200 OK: Retorna a lista de fornecedores com sucesso,
500 Internal Server Error: Erro interno ao listar fornecedores.

* Exemplo de Resposta

![image](https://github.com/fjunior9876/Playmove/assets/94969208/f503b23a-05cd-4385-9cc2-adb2c3896196)

## Obter Fornecedor por ID
Retorna um fornecedor específico com base no ID fornecido.

* URL
![image](https://github.com/fjunior9876/Playmove/assets/94969208/548c56fc-78e3-420f-b32a-7554d52a7184)

* Parâmetros da Requisição
  
id (int): ID do fornecedor a ser obtido.

* Códigos de Resposta

200 OK: Retorna o fornecedor com sucesso,
404 Not Found: Fornecedor não encontrado,
500 Internal Server Error: Erro interno ao obter fornecedor.

* Exemplo de Resposta
![image](https://github.com/fjunior9876/Playmove/assets/94969208/827b7d67-6d62-430e-bc3a-73515967daf9)

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


