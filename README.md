# blazor-auto-custom-validation-attributes
Herdando a classe ValidationAttribute para criar validações customizadas, uma maneira poderosa e flexível de adicionar regras de validação específicas para as suas necessidades no Front-end com Blazor

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

## Sobre o projeto
Este projeto mostra como herdar a classe ValidationAttribute para criar validações customizadas, uma maneira poderosa e flexível de adicionar regras de validação específicas para as suas necessidades no Front-end com Blazor.

O <code>ValidationAttribute</code> é uma classe base que herdamos para implementar nossas próprias validações. Ela nos oferece propriedades e métodos:

**Propriedades:**

<code>ErrorMessage</code>: Mensagem de erro que será exibida se a validação falhar.

<code>ErrorMessageResourceName</code> e <code>ErrorMessageResourceType</code>: Para suportar mensagens de erro localizadas.

**Métodos:**

<code>IsValid(object? value)</code>: Valida o valor do campo e retorna true ou false. (Recomendado apenas para validações simples.)

<code>IsValid(object? value, ValidationContext context)</code>: Permite validações mais complexas com acesso ao contexto do modelo.

Os validadores customizados podem ser incrivelmente úteis quando projetados corretamente. Sempre que usar, procure criar validadores reutilizáveis, claros e testáveis, garantindo que as mensagens de erro sejam claras e informativas.

<div align="center">
    <img src="https://github.com/user-attachments/assets/feb015a6-f8ba-4e65-9506-2c3028299756"</img>
    <img src="https://github.com/user-attachments/assets/79a467a6-4ebd-401c-948e-4e471fde57ac"</img>
    <img src="https://github.com/user-attachments/assets/00c2df0a-a952-4d82-be2b-fb814456f62d"</img>
    <img src="https://github.com/user-attachments/assets/410aad1e-2707-4077-8b85-5c55cd0d1cea"</img>
</div>

## Referências
https://learn.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-9.0

https://learn.microsoft.com/en-us/aspnet/core/blazor/forms/validation?view=aspnetcore-9.0

## Licença
GPL-3.0 license
