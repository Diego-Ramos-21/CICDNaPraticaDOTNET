# CICDNaPraticaDOTNET
Projeto do curso DIO - Continuous Integration (CI) e Continuous Delivery(CD) na prática com .NET

## Infos
Esta API apresenta algumas imagens presentes em um repertorio, para poder acessa-los é necessário seguir os seguintes comandos

https://localhost:{Porta}/ -> endereço base

## Controllers
### 1. cat -> Acessa o repertorio de gatos
#### Parâmetros
- Image | bool | Se verdadeiro apresenta a imagem na tela

### 2. dog -> Acessa o repertorio de cachorros
#### Parâmetros
- Image | bool | Se verdadeiro apresenta a imagem na tela

### 3. fox -> Acessa o repertorio de raposas
#### Parâmetros
- Image | bool | Se verdadeiro apresenta a imagem na tela

### 4. turtle -> Acessa o repertorio de tartarugas
#### Parâmetros
- Image | bool | Se verdadeiro apresenta a imagem na tela

### 5. fish -> Acessa o repertorio de peixes
#### Parâmetros
- Image | bool | Se verdadeiro apresenta a imagem na tela

### 6. hamster -> Acessa o repertorio de hamsters
#### Parâmetros
- Image | bool | Se verdadeiro apresenta a imagem na tela

### 7. anime -> Acessa o repertorio de animes
#### Parâmetros
- Image | bool | Se verdadeiro apresenta a imagem na tela

### 8. images -> Centraliza todos os comandos individuais em um único usando apenas o parametro de Category, para diferenciá-los
#### Parâmetros
- Image | bool | Se verdadeiro apresenta a imagem na tela
- Category | inteiro | Recebe um inteiro de 1 - 7 que definirá qual repertorio acessar
