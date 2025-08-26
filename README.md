
# Adequeção de Rodeiros para otimização de logistica de Entregas

Este projeto tem como objetivo apresentar o levantamento inicial de requisitos para o desenvolvimento de um sistema de logística de rodeiros de trens, destinado à empresa "VALE S/A". Atualmente, este processo na empresa é manual, o que resulta em diversos desafios operacionais. Todas as transações, sendo na maioria delas busca de rodeiros, são realizadas com o auxílio de arquivos excel gerados por diferentes sistemas manuais, que são feitos com tecnologia distintas, impossibilitando a comunicação e criação de relatórios mais simplificados. Além disso, o controle de rodeiros é realizado de forma manual, com registros dispersos em diversos locais, dificultando a gestão e o controle do estoque de rodeiros disponíveis.
Um dos principais problemas do sistema atual é a dificuldade em consultar a disponibilidade dos rodeiros. Durante a busca, o usuário deve executar um conflito de dados entre planilhas de Excel que são geradas por esses sistemas distintos. 
O sistema proposto visa solucionar esses problemas e otimizar o processo de busca e logística desses rodeiros. Através da automação, o sistema permitirá o conflito de dados de forma mais eficiente, rápida e precisa, seguindo as regras de negócio, como por exemplo a quilometragem, notas de manutenção e disponibilidade de um determinado rodeiro.
Outro benefício importante do sistema é a integração automática desses dados conflitados, podendo ser exportado em csv e ser usado em outra aplicação, como em um banco de dados. 



## Sobre


O Apliciativo basicamente agrupa arquivos de Excel com dados divergentes e conflita as informações, fitra resutados e lista os rodeiros disponíveis, baseando-se nos seguintes critérios: \
1 - se a quilometragem for menor do que 1000\
2 - se nao possui notas de manutenção\
3 - e a família for menor do que 4(ainda em desenvolvimento.).

*O ASR é uma aplicação de desktop autônoma (standalone). Ele não depende de outros sistemas para funcionar, apenas do sistema operacional Windows e do .NET Runtime.

## Funções do Produto:
As principais funções a serem desempenhadas pelo software são:\
1- Permitir que o usuário selecione os quatro arquivos de entrada necessários.\
2 - Processar os arquivos para consolidar as informações.\
3 - Apresentar os dados consolidados em uma grade visual.
4 - Permitir a exportação dos dados consolidados para os formatos Excel e CSV.\

## COMO USAR ESTE APLICATIVO: 
### 1 - Iniciando a tea de boas vindas do usuário: 
<img width="875" height="508" alt="1" src="https://github.com/user-attachments/assets/c2049cfa-9333-4753-8d13-88566d9b16ae" />. \
### 2 - ao clicar em iniciar ele abre a tela de iserir arquivos:
<img width="806" height="480" alt="2" src="https://github.com/user-attachments/assets/52251287-16db-4a02-b1b3-956f640cfc9f" />. \
### 3 - Ao clicar em "carregar e pocessar arquivos", ele abre uma janela do windows explorer
<img width="870" height="504" alt="3" src="https://github.com/user-attachments/assets/98d55fd3-9970-4daf-8b0b-6c078daeca4a" />. \
### 4 - Após isso ele carrega os dados, e abaixo deles as ferramentas de manipulação desses dados:
<img width="800" height="479" alt="4" src="https://github.com/user-attachments/assets/924aa99b-7792-4391-b018-b0a370d67c52" />. \
###  5 - então ao clicar em "Eportar para .csv" ele cria um arquivo no windows explorer.
<img width="877" height="503" alt="5" src="https://github.com/user-attachments/assets/acee08d6-42b2-46c2-b8f0-f21963e68450" />. \
### 6 - A janea de filtros está em construção.
<img width="1199" height="559" alt="6" src="https://github.com/user-attachments/assets/7ab697a5-73fe-44bd-b12e-31caba18e2ea" />. \
### 7 - A de interação com o BD também.
<img width="239" height="224" alt="7" src="https://github.com/user-attachments/assets/7f3162d3-4b8c-4c9a-bd67-c738e3f14ae3" />. \
