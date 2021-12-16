# Registro de Testes de Software
<ol>
  
<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para os testes do software será realizado quatro testes o Cadastro, Login, Cadastros de Débitos, Receita e Investimentos e Relatórios, da seguinte maneira.
 
## Programação de teste
Escolher a abordagem de teste caixa preta:

Partição de equivalência e condição limite:
  O teste com base na análise de classe de equivalência (sinônimos: particionamento de equivalência, análise de domínio) é uma forma de análise de teste de caixa preta que tenta reduzir o número total de testes possíveis para um conjunto mínimo de testes que revelarão o número máximo de erros possível. Isso consiste em um método que particiona o conjunto de entradas e saídas em um número finito de classes de equivalência que permitem a seleção de um valor de teste representativo para cada classe. O teste que resulta do valor representativo para uma classe é chamado de "equivalente" aos outros valores na mesma classe. Se nenhum erro foi localizado no teste do valor representativo, conclui-se que todos os outros valores "equivalentes" também não identificariam quaisquer erros.

### Passo a passo
  <ol>
    
  * Decompor o programa em funções. 
  * Identificar as variáveis que determinam o comportamento de cada função.
  * Particionar os valore de cada variável em classes de equivalência. 
  * Exibir os resultados.
  
  </ol>
 

### Casos de Testes
  <ol>
    
|Caso de Teste|	CT-01 – CADASTRO DE CONTA|
--------------|----------------------------|
|Pré-condições|	Estar na tela de cadastro usuário| 
|Procedimento	|1)	Criar senha e login |
|             |2)	Selecionar opção “Cadastrar”|
|Dados de entrada	|Senha válida (1234) e login válido(abcd)|
|Resultado Esperado	|Cadastrar no sistema|
|Resultado Obtido|Sucesso|	
|Avaliação|Teste realizado, automaricamente e manualmente resultado esperado obtido|	
#### Teste Cadastro Conta   
![Guia de Controle Financeiro - teste cadastro](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t4-desk-lm2/blob/main/docs/img/testecadastro.png)
    
|Caso de Teste	|CT-02 – LOGIN , ALTERAÇÃO E EXCLUSÃO DE CONTA|
|------|-------|
|Pré-condições	|Estar cadastrado no sistema |
|Procedimento	|1)	Digitar login e senha |
||2)	Selecionar opção “Entar”|
|Dados de entrada	|Senha válida (1234) e login válido (abcd)|
|Resultado Esperado	|Entrar no sistema|
|Resultado Obtido| Sucesso|	
|Avaliação|Teste realizado, automaricamente e manualmente resultado esperado obtido|	
 #### Teste Login   
![Guia de Controle Financeiro - teste Login](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t4-desk-lm2/blob/main/docs/img/teste%20tela%20login.png)
 #### Teste Alterar Conta   
![Guia de Controle Financeiro - teste alterar conta](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t4-desk-lm2/blob/main/docs/img/testealterarconta.png)

|Caso de Teste	|CT-03 – CADASTRO RECEITAS DESPESAS|
|---|---|
|Pré-condições	|Estar logado no sistema |
||1)	Acessar Tela Receita e Despesa|
|Procedimento	|2)	 Digitar dados solicitados|
||3)	Selecionar opção “Cadastrar”|
|Dados de entrada	|Valor(R$), Data(DD/MM/AAAA)|
|Resultado Esperado	|Cadastro Realizado|
|Resultado Obtido	|Sucesso|
|Avaliação	|Teste realizado, automaricamente e manualmente resultado esperado obtido|
 #### Teste Cadastro Conta   
![Guia de Controle Financeiro - teste cadastro receita](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t4-desk-lm2/blob/main/docs/img/teste%20cadastro%20receita.png)

|Caso de Teste	|CT-04 – VISUALIZAÇÃO DOS RELATORIO DE RECEITAS E DESPESAS|
|---|----|
|Pré-condições	|Realizar cadastro de Pelo menos 01 tipo de despesa, receita|
|Procedimento	|1)	Acessar Tela Relatório.|
||2)	Selecionar opção “Gerar”|
|Dados de entrada	|Valor(R$), Data(DD/MM/AAAA)|
|Resultado Esperado	|Gerar Relatório |
|Resultado Obtido	| Sucesso|
|Avaliação	|Teste realizado, automaricamente e manualmente resultado esperado obtido|
 #### Teste Gerar Relatorios   
![Guia de Controle Financeiro - teste Relatorio](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t4-desk-lm2/blob/main/docs/img/testerelatorios.png)

</ol>
  
### Testes automatizado
<ol>
  
 #### Teste Sucesso  
![Guia de Bolso - teste Sucesso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t4-desk-lm2/blob/main/src/teste%20sucesso.mp4)
     
 #### Teste Insucesso   
![Guia de Bolso - teste insucesso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t4-desk-lm2/blob/main/src/teste%20insucesso.mp4)
  
  #### Arquivos de Teste   
![Guia de Bolso - Arquivos de teste](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t4-desk-lm2/tree/main/src/Testes_Automatizados_Guia_Bolso)
</ol>

</ol>  
</ol>
