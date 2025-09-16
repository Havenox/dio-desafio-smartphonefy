# 📱 Smartphonefy

Um sistema de modelagem de celulares desenvolvido em **C# .NET**, como parte de um desafio da [DIO](https://dio.me/users/eduardonascto). O projeto aplica conceitos de **Programação Orientada a Objetos (POO)**, com abstração, herança e polimorfismo.

---

## 📖 Descrição

O **Smartphonefy** foi projetado para simular o funcionamento de celulares de diferentes marcas e modelos, aproveitando ao máximo os conceitos de orientação a objetos. Ele permite:

* Modelar um **Smartphone** como classe abstrata.
* Criar implementações específicas para **Nokia** e **iPhone**.
* Sobrescrever métodos para representar comportamentos distintos, como a instalação de aplicativos.

Assim como no desafio anterior, o código base já existia e continha trechos sinalizados com **TODO**. Minha tarefa foi **complementar a implementação**, o que reforçou a prática de trabalhar em projetos já iniciados.

---

## ⚙️ Funcionalidades

* **Classe abstrata Smartphone**:

  * Modelo base, não pode ser instanciada.
  * Propriedades: número, modelo e IMEI.
  * Métodos comuns (ligar, receber ligação).
* **Classe Nokia**:

  * Herda de **Smartphone**.
  * Implementa sua própria forma de instalar aplicativos.
* **Classe iPhone**:

  * Herda de **Smartphone**.
  * Implementa sua própria forma de instalar aplicativos.

---

## 🛠️ Estrutura do Projeto

* **Smartphone.cs** → classe abstrata base.
* **Nokia.cs** → classe concreta herdando de Smartphone.
* **iPhone.cs** → classe concreta herdando de Smartphone.
* **Program.cs** → fluxo principal para executar e testar as funcionalidades.

---

## 🚀 Tecnologias Utilizadas

* Linguagem: **C#**
* Plataforma: **.NET 9+**
* Paradigma: **Programação Orientada a Objetos (POO)**

---

## 📂 Como Executar

1. Clone o repositório:

```bash
git clone https://github.com/Havenox/dio-desafio-smartphonefy.git
```

2. Acesse a pasta do projeto:

```bash
cd dio-desafio-smartphonefy
```

3. Compile e execute:

```bash
dotnet run
```

---

## 🧩 Exemplo de Uso

```
Smartphonefy - Sistema de Celulares

Digite a opção desejada:

1 - Criar Nokia
2 - Criar iPhone
3 - Instalar aplicativo
4 - Fazer ligação
5 - Receber ligação
0 - Encerrar aplicação
```

Exemplo de saída ao instalar um app em celulares diferentes:

```
Instalando aplicativo no Nokia: WhatsApp
Instalando aplicativo no iPhone: WhatsApp
```

---

## 🎯 Objetivos Atingidos

* Aplicar **abstração** para definir o modelo base de smartphone.
* Exercitar **herança** e criação de subclasses específicas.
* Utilizar **polimorfismo** para métodos com implementações distintas.
* Praticar a implementação de código em um **projeto parcialmente pronto**.
* Consolidar conceitos fundamentais de POO em C#.

---

## 📌 Autor

👤 **[Eduardo Nascimento](https://www.instagram.com/eduardohavenox/)**
🔗 [GitHub](https://github.com/Havenox)
💼 [LinkedIn](https://www.linkedin.com/in/havenox)
🎓 [DIO](https://dio.me/users/eduardonascto)

---

## 🙏 Agradecimentos

Agradeço à DIO pela proposta do desafio e ao professor Leonardo Buta, pelas aulas que tornaram clara a importância da **abstração e polimorfismo** no desenvolvimento orientado a objetos.

---

## 🏆 Considerações

Este projeto reforçou o aprendizado sobre **POO em C#**, mostrando a importância de abstrair, herdar e especializar classes em sistemas reais. O **Smartphonefy** exemplifica como reutilizar código e ao mesmo tempo criar comportamentos específicos, além de treinar a habilidade de trabalhar em projetos com código já iniciado.
