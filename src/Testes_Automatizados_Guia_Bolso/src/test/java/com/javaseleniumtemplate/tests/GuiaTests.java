package com.javaseleniumtemplate.tests;

import com.javaseleniumtemplate.bases.TestBase;
import com.javaseleniumtemplate.pages.LoginPage;
import com.javaseleniumtemplate.pages.MainPage;
import org.testng.Assert;
import org.testng.annotations.Test;

public class GuiaTests extends TestBase {

    LoginPage loginPage;


    @Test
    public void efeturarCadastroConta(){
        //Objects instances
        loginPage = new LoginPage();
        String nome = "Teste5";
        String email = "teste18@gmail.com";
        String senha = "123";
        String titulologin = "Realizar Login";
        loginPage.preencherNome(nome);
        loginPage.preencherEamil(email);
        loginPage.preencherSenha(senha);
        loginPage.clicarEmCadastro();
        Assert.assertEquals(titulologin, loginPage.retornaTituloTelaLogin());
    }


    @Test
    public void efeturarLogin(){
        loginPage = new LoginPage();
       // efeturarCadastroConta();
        String email = "teste18@gmail.com";
        String senha = "123";
        String titulologin = "Visão Geral";
        loginPage.preencherLogEmail(email);
        loginPage.preencherLogSenha(senha);
        loginPage.clicarEmLogin();
        Assert.assertEquals(titulologin, loginPage.retornaTelaLogado());
    }

    @Test
    public void efeturarAlteracaoConta(){
        //Objects instances
        loginPage = new LoginPage();
        //efeturarCadastroConta();
      //  efeturarLogin();
        String nome = "teste55";
        String titulologin = "Realizar Login";
        loginPage.cliarMenuMeuPerfil();
        loginPage.cliarCarregar();
        loginPage.alterarNome(nome);
        loginPage.cliarAlterar();
        Assert.assertEquals(titulologin, loginPage.retornaTituloTelaLogin());
    }

    @Test
    public void efeturarCadastroDespesa(){
        loginPage = new LoginPage();
    //    efeturarCadastroConta();
     //   efeturarLogin();
        loginPage.cliarDespesa();

        String descricao = "Tenis";
        String valor = "10";
        String tipo = "teste";
        String data = "14/12/2021";
        String titulologin = "Visão Geral";

        loginPage.preencherDescricao(descricao);
        loginPage.preencherValDesp(valor);
        loginPage.preencherTipoDesp(tipo);
        loginPage.preencherDataDesp(data);
        loginPage.clicarEmAddCadDesp();
        Assert.assertEquals(titulologin, loginPage.retornaTelaLogado());
    }

    @Test
    public void efeturarCadastroReceita(){
        loginPage = new LoginPage();
    //    efeturarCadastroConta();
    //    efeturarLogin();
        loginPage.cliarReceita();

        String tipo = "teste";
        String valor = "10";
        String titulologin = "Visão Geral";
        loginPage.preencherTipoReceita(tipo);
        loginPage.preencherValorReceita(valor);
        loginPage.clicarEmAddCadReceita();
        Assert.assertEquals(titulologin, loginPage.retornaTelaLogado());
    }


    @Test
    public void efeturarCadastroDiferenca(){
        loginPage = new LoginPage();
  //      efeturarCadastroConta();
   //     efeturarLogin();
        loginPage.cliarDiferenca();

        String tipo = "teste";
        String valor = "10";
        String data = "14/12/2021";
        String titulologin = "Visão Geral";
        loginPage.preencherTipoDiferenca(tipo);
        loginPage.preencherValorDiferenca(valor);
        loginPage.preencherDataDiferenca(data);
        loginPage.clicarEmAddCadDiferenca();
        Assert.assertEquals(titulologin, loginPage.retornaTelaLogado());
    }

    @Test
    public void visualizacaoLancamentosRelatorios(){
        loginPage = new LoginPage();
    //    efeturarCadastroConta();
    //    efeturarLogin();
        loginPage.clicaMenuLancamento();
        String titulancamento = "Todas as Despesas";
        Assert.assertEquals(titulancamento, loginPage.retornalancamentos());
        loginPage.clicarEmRelatorio();
    }


    @Test
    public void efeturarCadastroDespesaReceitaDiferenca()throws  InterruptedException{
        loginPage = new LoginPage();
    //    efeturarCadastroConta();
        efeturarLogin();
        Thread.sleep(1000);
        efeturarCadastroDespesa();
        Thread.sleep(1000);
        efeturarCadastroReceita();
        Thread.sleep(1000);
        efeturarCadastroDiferenca();
        Thread.sleep(1000);
        visualizacaoLancamentosRelatorios();
    }

    @Test
    public void efeturarCadastroAlteracaoExclusaoConta(){
        loginPage = new LoginPage();
        efeturarCadastroConta();
        efeturarLogin();
        efeturarAlteracaoConta();
    }

    @Test
    public void todasosCasosSucesso()throws InterruptedException{
        loginPage = new LoginPage();
        efeturarCadastroConta();
        Thread.sleep(1000);
        efeturarLogin();
        Thread.sleep(1000);
        efeturarAlteracaoConta();
        Thread.sleep(1000);
        efeturarLogin();
        Thread.sleep(1000);
        efeturarCadastroDespesa();
        Thread.sleep(1000);
        efeturarCadastroReceita();
        Thread.sleep(1000);
        efeturarCadastroDiferenca();
        Thread.sleep(1000);
        visualizacaoLancamentosRelatorios();
    }

    ////////// CASOS INSUCESSO /////


    @Test
    public void efeturarCadastroLoginInsucesso(){
        loginPage = new LoginPage();
        String nome = "Teste5";
        String email = "teste5.com";
        String senha = "123";
        String tituCad = "Realizar Cadastro";
        String titulologin = "Realizar Login";
        String url = "http://siteguiabolso.azurewebsites.net/login.aspx";
        loginPage.preencherNome(nome);
        loginPage.preencherEamil(email);
        loginPage.preencherSenha(senha);
        loginPage.clicarEmCadastro();
        Assert.assertEquals(tituCad, loginPage.retornaTituloTelaCad());
        loginPage.navigateTo(url);
        loginPage.preencherLogEmail(email);
        loginPage.preencherLogSenha(senha);
        loginPage.clicarEmLogin();
        Assert.assertEquals(titulologin, loginPage.retornaTelaLogadoIncorreto());
    }
}
