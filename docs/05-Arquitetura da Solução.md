# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

A IBM definiu como arquitetura de um projeto, o conjunto de decisões significativas sobre a organização de um sistema de software, a seleção de elementos estruturais e suas interfaces, juntamente com o comportamento especificado nas colaborações entre estes elementos, a composição destes elementos em subsistemas progressivamente maiores e o estilo arquitetural que guia esta organização. (The Rational Unified Process: An Introduction)(IBM, apud Nhimi, 2016) Desta forma e possível compreender que a arquitetura e um dos princípios fundamentais para a materialização de um projeto. Além disso dentro da arquitetura da solução definiremos os componentes básicos para o funcionamento deste projeto e a definição das tecnologias a serem empregadas no projeto

## Diagrama de Classes

<ol>
 O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

![Guia de Controle Financeiro - Diagrama de Classes](https://github.com/ICEI-PUC-Minas-PMV-ADS/guia-de-bolso/blob/main/docs/img/Diagrama%20de%20Classes.jpg)

 Figura 13- Diagrama de Classes
</ol>

## Modelo ER

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.]

![Modelo ER](https://github.com/ICEI-PUC-Minas-PMV-ADS/guia-de-bolso/blob/main/docs/img/MODELO%20RELACIONAL%203.png)

Figura 14- Modelo RE


## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.
 
![Esquema Relacional](https://github.com/ICEI-PUC-Minas-PMV-ADS/guia-de-bolso/blob/main/docs/img/MODELO%20ER1.jpg)

Figura 15- Esquema Relacional

## Tecnologias Utilizadas

<ol>
 Para o desenvolvimento do sistema utilizaremos a linguagem C#, juntamente com o banco de dados em SQL, sera utilizada a ferramenta ASP.NET para desenvolvimento e administração de base de dados, além de ser sistema construído através da arquitetura MVC, tendo sua hospedarem no Horuku, acessado de um navegador padrão, como ferramentas adicionais como o Github como ferramenta de repositório do código fonte, e o Visual Studio como ferramenta de suporte ao desenvolvimento, Invision e Pansil, Affinty Designer para os projetos de interfaces e Teamplates.
 </ol>

## Hospedagem

Esse projeto após seu termino será lançado na plataforma de hospedagem Azure, e terá como endereço de URL:https://aspnet-7klx3wm5myj4e.azurewebsites.net/
