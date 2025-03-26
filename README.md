# 🎲 Empresa de Brinquedos API

Projeto desenvolvido em C# com ASP.NET Core 8 e Entity Framework Core para gerenciamento de brinquedos de uma empresa voltada a crianças de até 12 anos. A aplicação expõe endpoints RESTful para CRUD completo com persistência em banco de dados Oracle.

## 📅 Data de entrega
**26/03/2025**

---

## 🚀 Tecnologias utilizadas

- .NET 8
- C#
- ASP.NET Core Web API
- Entity Framework Core
- Banco de dados Oracle
- Swagger para testes de endpoints
- Postman para validação de requisições
- Visual Studio 2022

---

## 📦 Tabela no banco de dados: `TDS_TB_BRINQUEDOS`

A tabela contém as seguintes colunas:

| Campo             | Tipo         | Descrição                  |
|------------------|--------------|----------------------------|
| `Id_brinquedo`   | int          | Identificador do brinquedo |
| `Nome_brinquedo` | string       | Nome do brinquedo          |
| `Tipo_brinquedo` | string       | Tipo (educativo, etc)      |
| `Classificacao`  | string       | Faixa etária               |
| `Tamanho`        | string       | Pequeno, Médio, Grande     |
| `Preco`          | decimal(10,2)| Preço                      |

---

## 🔁 Funcionalidades da API

| Método | Endpoint               | Ação                           |
|--------|------------------------|--------------------------------|
| GET    | `/api/brinquedos`     | Retorna todos os brinquedos   |
| GET    | `/api/brinquedos/{id}` | Retorna um brinquedo por ID   |
| POST   | `/api/brinquedos`     | Adiciona um novo brinquedo    |
| PUT    | `/api/brinquedos/{id}` | Atualiza um brinquedo         |
| DELETE | `/api/brinquedos/{id}` | Remove um brinquedo           |

---

## 🧪 Testes no Swagger

Acesse: `http://localhost:5000/swagger`

- Interface amigável para testar todos os endpoints
- Cada rota possui documentação, parâmetros e resposta esperada

### ✅ Exemplo de POST (inserção)

```json
{
  "nome_brinquedo": "Quebra-Cabeça Turma da Mônica",
  "tipo_brinquedo": "Educativo",
  "classificacao": "6+",
  "tamanho": "Médio",
  "preco": 49.90
}
```

---

## 🔄 Testes no Postman

- Basta criar requisições HTTP apontando para `http://localhost:5000/api/brinquedos`
- Envie os dados no corpo da requisição como `application/json`

---

## ⚙️ Como executar o projeto

1. Clone o repositório
2. Configure a string de conexão Oracle no `appsettings.json`
3. Abra no Visual Studio
4. Compile e execute (Ctrl + F5)
5. Acesse o Swagger: `http://localhost:5000/swagger`

---

## ✍️ Autor

Desenvolvido por Giovanna ✨
