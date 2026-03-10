# 🎵 Screen Sound - Gerenciador de Bandas

Este é um projeto simples desenvolvido em **C#** que permite registrar, avaliar e visualizar bandas através de uma aplicação de console.

O projeto foi criado como parte dos estudos de **Desenvolvimento em C# - Alura**, com o objetivo de praticar conceitos fundamentais como **dicionários, listas, funções, menus interativos e estruturas condicionais**.

---

## 📌 Sobre o projeto

O **Screen Sound** é um pequeno sistema de gerenciamento de bandas executado diretamente no terminal.

O programa permite que o usuário:

* Registrar novas bandas
* Visualizar todas as bandas cadastradas
* Avaliar bandas registradas
* Exibir a média de avaliações de uma banda
* Navegar por um menu interativo

Todas as interações acontecem diretamente pelo **console**, através de um menu de opções.

As bandas e suas avaliações são armazenadas em um **Dictionary**, onde:

* **Key** → nome da banda
* **Value** → lista de notas atribuídas à banda

---

## ⚙️ Funcionamento

Ao iniciar o programa, o usuário visualiza um **menu com opções disponíveis**.

Cada opção executa uma funcionalidade específica do sistema.

### Menu de opções

```
Digite 1 para registrar uma banda
Digite 2 para mostrar todas as bandas
Digite 3 para avaliar uma banda
Digite 4 para exibir a média de uma banda
Digite 0 para sair
```

Dependendo da opção escolhida, o sistema executa a função correspondente.

A navegação do menu é controlada utilizando a estrutura **switch**.

---

## 💻 Exemplo de execução

### Registro de banda

Registrando bandas:

<img width="473" height="463" alt="image" src="https://github.com/user-attachments/assets/395fb8b0-edeb-4e09-9f8f-26c06ac40343" />

<img width="562" height="145" alt="image" src="https://github.com/user-attachments/assets/7d590d90-4ca5-404e-b466-0f62ee0785a8" />

---

### Listagem de bandas

Listando bandas registradas:

<img width="508" height="477" alt="image" src="https://github.com/user-attachments/assets/fc97d2f8-b390-49ae-a3b9-9c971f7af260" />

<img width="683" height="175" alt="image" src="https://github.com/user-attachments/assets/c3225ceb-fe4c-47a6-a0a8-ddda10bbd273" />

---

## 🛠️ Tecnologias utilizadas

* **C#**
* **.NET**
* **Console Application**

---

## 📚 Conceitos praticados

Este projeto foi desenvolvido para praticar diversos conceitos fundamentais da programação:

* Criação e utilização de **funções**
* Estrutura de **menu interativo**
* Estrutura condicional **switch**
* Utilização de **Dictionary em C# (`Dictionary<string, List<int>>`)**
* Utilização de **listas (`List<int>`)**
* Entrada de dados do usuário (`Console.ReadLine`)
* Saída de dados no console (`Console.WriteLine`)
* Manipulação de coleções de dados
* Cálculo de média utilizando **LINQ (`Average()`)**
* Organização do código em **múltiplas funções**
