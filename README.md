# 📘 Cadastro de Alunos

Este é um sistema simples em **C#** para cadastro e análise de alunos.
O programa permite registrar informações básicas de até **30 alunos**, calcular a **média de idade** e verificar quem foi **aprovado** com base em uma **nota de corte definida pelo usuário**.

## 🚀 Funcionalidades

* Cadastro de:

  * Nome
  * Matrícula
  * Idade
  * Curso (Sistema A, B ou C)
  * Nota final
* Validação de entradas (idade positiva e notas entre 0 e 10).
* Cálculo da **média de idade** dos alunos cadastrados.
* Definição de uma **nota de corte** para aprovação.
* Exibição da lista de alunos **aprovados** (ou aviso se ninguém atingir a nota).

## 🛠️ Tecnologias utilizadas

* **C#**
* **.NET (Console Application)**

## ▶️ Como executar

1. Compile o código em um ambiente com suporte a **.NET SDK**.
2. Execute o programa:

   ```bash
   dotnet run
   ```
3. Informe:

   * Quantidade de alunos a cadastrar
   * Dados de cada aluno
   * Nota de corte para aprovação

## 📊 Exemplo de uso

```
=== Cadastro de Alunos ===
Quantos alunos deseja cadastrar (máximo 30)? 2

Aluno 1:
Nome: Ana
Matrícula: 001
Idade: 20
Curso: Sistema A
Nota final: 8.5

Aluno 2:
Nome: João
Matrícula: 002
Idade: 22
Curso: Sistema B
Nota final: 6.0

Média de idade dos alunos: 21.0 anos
Digite a nota de corte para aprovação: 7

== Alunos Aprovados ==

Nome: Ana
Matrícula: 001
Idade: 20
Curso: Sistema A
Nota: 8.5
```

## 📌 Observações

* O limite de alunos é definido pela constante `MAX_ALUNOS = 30`.
* Caso nenhuma nota atinja a nota de corte, o sistema informa que **nenhum aluno foi aprovado**.

---

✨ Projeto feito para fins de **aprendizado em C# e manipulação de arrays**.
