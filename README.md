# SearchDemonSlayerAPI ⚔️

Aplicação web desenvolvida em **Blazor WebAssembly (WASM)** (.NET 10+) para listar e buscar personagens do universo de **Demon Slayer (Kimetsu no Yaiba)** consumindo a API pública [Demon Slayer API](https://www.demonslayer-api.com/documentation).

## Sobre o Projeto

Este projeto foi desenvolvido como atividade prática da disciplina de **Usabilidade, Desenvolvimento Web, Mobile e Jogos** (**Lista 24 - BlazorWebAssembly**).

### Objetivos:
- Desenvolver uma aplicação SPA utilizando **Blazor WebAssembly** em **.NET 10+**.
- Consumir endpoints REST de forma assíncrona utilizando `HttpClient` e `GetFromJsonAsync`.
- Implementar recursos de **busca por nome** e **listagem paginada** de personagens.
- Exibir em cards responsivos os dados retornados pela API:
  - **Nome** (`name`)
  - **Idade** (`age`)
  - **Raça** (`race`)
  - **Citação / Frase marcante** (`quote`)
  - **Imagem do personagem** (`img`)

---

## Funcionalidades

1. **Listagem Paginada de Personagens:**
   - Carrega inicialmente a página 1 da API com botões de navegação (**Anterior** e **Próxima**).
   - Mostra o total de páginas e o número de personagens exibidos.
2. **Busca por Nome:**
   - Permite pesquisar qualquer personagem (Ex: *Tanjiro Kamado*, *Nezuko Kamado*, *Giyu Tomioka*, *Muzan Kibutsuji*, etc.).
   - Disparo por clique no botão **Buscar** ou pressionando a tecla **Enter**.
3. **Cards Informativos dos Personagens:**
   - Imagem oficial com tratamento contra falha de carregamento.
   - Nome destacado com badge identificando se é **Humano** ou **Demônio**.
   - Idade tratada (indicando anos ou "Desconhecida" para demônios ancestrais com idade indefinida).
   - Destaque especial para a **Citação / Frase marcante** do personagem em caixa estilizada.
4. **Tratamento de Exceções e Feedback Visual:**
   - Spinner animado durante o carregamento.
   - Mensagens de alerta caso o personagem não seja encontrado ou ocorra erro de conexão.

---

## Como Executar

### Pré-requisitos

- [.NET SDK 10+](https://dotnet.microsoft.com/download) instalado.

### Passos

1. Clone o repositório:
   ```bash
   git clone https://github.com/JoaoGargano/search-demon-slayer-api.git
   ```

2. Acesse a pasta do projeto (onde fica o arquivo `.csproj`):
   ```bash
   cd search-demon-slayer-api/SearchDemonSlayerAPI
   ```

3. Execute a aplicação:
   ```bash
   dotnet run
   ```

4. Abra o navegador no endereço indicado no terminal (ex: `http://localhost:5xxx` ou `https://localhost:7xxx`).

---

## Endpoints da API Utilizados

- **Listagem Paginada:**
  - `GET https://www.demonslayer-api.com/api/v1/characters?page=1`
- **Busca por Nome:**
  - `GET https://www.demonslayer-api.com/api/v1/characters?name={nome}`

### Exemplo de Retorno JSON:
```json
{
  "content": [
    {
      "id": 1,
      "name": "Tanjiro Kamado",
      "age": 16,
      "gender": "Male",
      "race": "Human",
      "description": "Is the main protagonist of Demon Slayer...",
      "img": "https://www.demonslayer-api.com/api/v1/characters/images/1.webp",
      "quote": "Work at it. All I can do is work hard! That’s the story of my life!"
    }
  ]
}
```

---

## Tecnologias Utilizadas

- **C#** / **.NET 10**
- **Blazor WebAssembly (Standalone App)**
- **System.Net.Http.Json** (`GetFromJsonAsync`)
- **Newtonsoft.Json** & **System.Text.Json.Serialization**
- **Bootstrap 5** (Layout em grid responsivo e cards estilizados)

---

## 📄 Licença

Este projeto está sob a licença [MIT](LICENSE).
