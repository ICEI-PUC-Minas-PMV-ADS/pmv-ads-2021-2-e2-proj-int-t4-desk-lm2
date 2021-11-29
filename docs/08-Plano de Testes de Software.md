# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>


<ol>
 
 
  Os requisitos para realização dos testes de software são:
   
   ● Site publicado na Internet.
 
   ● Navegador da Internet - Chrome, Firefox ou Edge.
 
   ● Conectividade de Internet.

 Os testes funcionais a serem realizados no site são descritos a seguir.
 
## CASOS DE TESTES SUCESSO: CT-01 (RF-001), CT-02 (RF002,RF003,RF004), CT-03 (RF-005, RF-006, RF-007), CT-04 (RF-011,RF-012,RF-013)
<ol>

  | CASO DE TESTE| CT-01 – CADASTRO DE CONTA|
  |--------------|------------------------|
  |REQUISITOS ASSOCIADOS	|RF-001|
  |                                                   |
  |OBJETIVO DO TESTE	| Verificar se o cadastro foi realizado com sucesso e se o redirecionamento ocorreu de forma correta.|
  |      |	1) Acessar o Navegador|
  |PASSOS| 2) Clicar no botão do botão cadastro|
  |      | 3) Visualizar a pagina de login para entrar no site|
  |                                                          |
  |CRITÉRIO DE ÊXITO| ●	O site deve apresentar na página principal o botão Cadastro e após efetivação da conta redirecionar para tela de Login.|

 
|CASO DE TESTE|CT-02 – LOGIN , ALTERAÇÃO E EXCLUSÃO DE CONTA|
|--------------|-------------------------------------|
|REQUISITOS ASSOCIADOS	|RF-002 – RF-003 – RF-004| 
|OBJETIVO DO TESTE|	Verificar se os botões estão posicionados de forma correta e se está ocorrendo o login,alteração e exclusão da conta de forma efetiva.|
|      	|1)	Acessar o Navegador|
|       |2)	Clicar no botão de Login|
|       |3)	Fazer o Login|
|       |4)	Clicar em Meu Perfil|
|Passos |5)	Clicar em Alterar Conta|
|       |6)	Digitar os dados a serem alterados|
|       |7)	Clicar em concluir|
|       |8)	Clicar no botão Excluir Cota|
|       |9)	Clicar em Concluir|
|       |10)	Sair da Conta|
|                 	| ●	Após realização do login o site deve apresentar um menu central com todas as opções de CRUD investimentos,receitas e despesas sendo exibidos.|
|CRITÉRIO DE ÊXITO	| ●	Após realização do login o site deve apresentar a opção meu perfil com o botão Alterar Conta e redirecionando para tela de alterar os dados. |
|                 	| ●	Após realização do login o site deve apresentar a opção meu perfil com o botão Excluir Conta e redirecionando para tela de excluir os dados. |

|CASO DE TESTE |	CT-03 – CADASTRO RECEITAS E DESPESAS|
|-------------|------------------------------------------------| 
|REQUISITOS ASSOCIADOS|RF-005–RF-006–RF-007|
|OBJETIVO DO TESTE    |Verificar se os botões e inserções de daos estão ocorrendo de forma correta e se as suas funcionalidades estão sendo exibidas|
|      	              |1)	Logar no site|
|                     |2)	Clicar no botão receitas|
|                     |3)	Validar se ouve mudança no saldo atual|
|Passos               |4)	Validar se ouve mudança no saldo atual|
|                     |5)	Clicar no botão despesas|
|                     |6)	Validar se ouve mudança no saldo atual|                                                                                                      |
|                 |	●	Após realizar login e clicar no botão despesas você deve adionar um valor para validar se ouve a inserção no saldo atual.       |
|CRITÉRIO DE ÊXITO|	●	Após realizar login e clicar no botão despesas você deve adionar um valor para validar se ouve a inserção no saldo atual.       |
|||

|CASO DE TESTE |	CT-04 – VISUALIZAÇÃO DOS GRAFICOS DE RECEITAS DESPESAS|
|-------------|------------------------------------------------| 
|REQUISITOS ASSOCIADOS|RF-011–RF-012–RF-013|                    
|OBJETIVO DO TESTE    |Verificar se os botões e graficos estão posicionados de forma correta e se as suas funcionalidades estão sendo exibidas|
|	                    |1)	Logar no site|
|Passos               |2)	Clicar no botão relatorios|
|                     |3)	Validar se os graficos estão sendo exibidos|
|                 |	●	Após realizar login e clicar no botão relatorios no site,validar se esta sendo exibido na tela o grafico de receitas.     |
|CRITÉRIO DE ÊXITO|	●	Após realizar login e clicar no botão relatorios no site,validar se esta sendo exibido na tela o grafico de despesas.     |

 </ol>

 
## CASOS DE TESTE INSUCESSO: CT-01 (RF-001,RF-002)
<ol>
 
 |CASO DE TESTE |	CT-01 – CADASTRO E LOGIN INCORRETOS| 
 |-------------|-----------------------|
 |REQUISITOS ASSOCIADOS	|RF-001-RF-002|
 |OBJETIVO DO TESTE|Verificar se todos os redirecionamento e validação do formulário de cadastro e login estão com validação.|
 |                 |1) Acessar o Navegador|
 |Passos           |2) Clicar no botão do menu cadastro|
 |                 |3) Digitar vários caracteres especiais|
 |                 |4) Clicar em cadastrar|
 |                  	| ●	Clicar no botão cadastro e digitar caracteres especiais e validar se ocorre o redirecionamento para tela cadastro|
 |Critérios de Êxito	| ●	Clicar no botão login e digitar caracteres especiais e validar se ocorre o redirecionamento para tela cadastro|
 


  </ol>
 </ol>

