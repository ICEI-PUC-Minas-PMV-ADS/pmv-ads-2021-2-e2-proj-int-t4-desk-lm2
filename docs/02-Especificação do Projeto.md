# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>
<ol>
 Após a definição do problema e de nosso público alvo a definição das próximas etapas passará pelo entendimento e a compreensão das pessoas as quais são o objeto desse estudo, desta forma está sendo realizando este levantamento, a fim de definir os desejos e frustrações de pessoas reais, que nos ajudará a criar um programa que irá ao seu término ajudar seus usuários, a criar de forma dinâmica e simplificada a visualização de seus controles financeiros. As informações coletadas dentro desse processo foram compiladas na forma de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições desse projeto, de onde daremos a partida para definir possíveis situações às quais serão solucionados ao final desse projeto.
</ol>

## Personas
<ol>
Segundo Spandin e Quincoses (2015, p.02) o estudo da persona da marca como objeto de investigação aconteceu pela motivação de entender como o perfil das marcas teve que se adaptar às novas exigências dos consumidores. Percebe-se que as marcas utilizam das personas para se tornarem humanas e tentar um contato mais direto com os públicos. Com a criação da persona da marca, ela passa a ser representada e percebida pelos públicos de forma mais espontânea e informal. (Quincoses e Spandin 2015), entender as personas de um projeto acaba por criar uma ligação da parte formal do projeto com a parte pessoal do mesmo, dando a ele uma identidade sobre a qual o trabalho indagado irá criar uma personalidade. Após a criação de nosso público alvo as personas como sendo:
 
* Ricardo Souza, 53 anos, empresário, consultor empresarial, divorciado, pai de três filhos, morador de Belo Horizonte- MG, atualmente trabalha 15hs por dia, no período da pandemia, as despesas de sua empresa e pessoais, acabaram sendo fundidas, dando a ele algumas dores de cabeça na hora de realizar os fechamentos, gastos com funcionários e compras de sua empresa estão misturadas às de sua vida pessoal, necessita de um sistema que mostre o que eles está gastando e como está gastando para que tenha a diversificação dessas despesas.
*	Beatriz Menezes, 40 anos, professora universitária, casada, dois filhos, moradora de Nova Lima - Mg, trabalhava 12 horas por dia, porém com a pandemia, o trabalho somado aos filhos em casa, mudou sua vida financeira por completo, seu controle de gastos com escola dos filhos, compras para casa. Além disso, seus investimentos para o futuro de seus filhos foram zerados, necessitando de um controle de seus gastos para saber em que consegue economizar e como retomar seus a autonomia de sua vida financeira.
*	Ângela Miranda, 20 anos, estudante de medicina, aux. Administrativa em uma empresa de radioterapia, moradora do Rio de Janeiro- RJ, solteira, apesar de seu salário Ângela, não consegue terminar o mês sem dívidas, necessitando todos meses de auxílio de seus pais para pagar suas contas, Ângela criou uma planilha de controle de seus gastos porém não diferencia as suas necessidades de coisas supérfluas para que possa reduzir esses custos.
*	Marco Nascimento, pedreiro, 35 anos, casado, pai de um filho, mora de aluguel, residente em Belo Horizonte. Com seu salário e de sua esposa, que trabalha de babá, consegue pagar todas as contas de casa e sobra um pouco para o lazer. Nunca pensou em investimentos, porém teve que poupar um pouco para comprar sua casa própria.
</ol>

## Histórias de Usuários
<ol>
 Com base na análise das personas forma identificadas as seguintes histórias de usuários:

 Tabela 1 – História de Usuário
 |PERSONA	|PROBLEMA	|SOLUÇÃO|
 |--------|---------|--------|
 |Ricardo Souza	   |Sobreposição de gastos pessoais e profissionais	|Ferramenta que diferencie seus gastos.
 |Beatriz Menezes	 |Desorganização financeira	|Controle de custos e revisão de despesas supérfluas
 |Ângela Miranda	  |Falta de controle de gastos	|Ferramenta que mostra diferenciação de gastos para melhor autonomia e controle.
 |Marco Nascimento	|Poupar para compra da casa própria	|Estabelecer metas de economia.

 Fonte: Elaborado pelos autores (2021).

 </ol>

## Requisitos
<ol>
 Os requisitos funcionais e não funcionais foram definidos da seguinte maneira:

 ### Requisitos Funcionais
<ol> 
 Tabela 2 — Requisitos Funcionais

 |ID	|Descrição do Requisito	|Prioridade|
 |---|-----------------------|----------|
 |RF-001|	Cadastrar conta	   | ALTA|
 |RF-002| Fazer Login	       | ALTA|
 |RF-003|	Alterar dados da conta| ALTA|
 |RF-004|	Excluir conta| BAIXA|
 |RF-005| Receita|	ALTA|
 |RF-006| Despesa|	ALTA|
 |RF-007|	Exibir Receitas|	MÉDIA|
 |RF-008|	Exibir Despesas|	MÉDIA|
 |RF-009|	Gerar gráfico de receitas|	BAIXA|
 |RF-010|	Gerar gráfico de despesas|	BAIXA|
 
 Fonte: Elaborado pelos autores (2021).
 
 obs: *CRUD: Criar, ler, atualizar e deletar (Create, Read, Update, Delete)


 </ol>

 ### Requisitos não Funcionais:
 <ol>
  
Tabela 3 – Requisitos não Funcionais
|ID	|Descrição do Requisito	|Prioridade|
|-------|------------------|---------|
|RNF-001|	O sistema será construído através arquitetura MVC| MÉDIA|
|RNF-002|	O sistema deve ser capaz de apresentar uma usabilidade intuitiva para o usuário| BAIXA|
|RNF-003|	O sistema deve ser capaz de tratar exceções e se recuperar de falhas sem que haja perda de dados|	ALTA|
|RNF-004|	O sistema vai utilizar C# e SQL| ALTA|
|RNF-005|	Será utilizada a ferramenta SQL Server para desenvolvimento e administração de base de dados|	ALTA|
|RNF-006|	O sistema não poderá demorar mais de 3 segundos para carregar|	ALTA|

  Fonte: Elaborado pelos autores (2021).

 </ol>
</ol>

## Restrições
 
O projeto está restrito aos itens apresentados na tabela a seguir:
 
Tabela 4 – Restrições

|ID|	Restrição|
|--|----------|
|01|	O projeto deverá ser entregue até o final do semestre|
|02|	Não funciona sem acesso a internet|
|03|	Interação com o cliente**|
|04|	Deverá ser gerenciável|

Fonte: Elaborado pelos autores (2021).

</ol>

## Diagrama de Casos de Uso
<ol>
 O diagrama de casos de usos foi elaborado da seguinte maneira:
 
 ![Guia de Controle Financeiro - Diagrama de caso de uso](https://github.com/ICEI-PUC-Minas-PMV-ADS/guia-de-bolso/blob/main/docs/img/130884385-c9203ee0-9433-4891-8f6e-be92a4061fd0.png)
 figura 01- Diagrama de Caso de Uso
 
</ol>
