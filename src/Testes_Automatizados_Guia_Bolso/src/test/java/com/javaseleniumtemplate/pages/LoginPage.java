package com.javaseleniumtemplate.pages;

import com.javaseleniumtemplate.bases.PageBase;
import org.openqa.selenium.By;

public class LoginPage extends PageBase {
    //Mapping
    By cadName = By.id("cad_nome");
    By cadUser = By.id("cad_email");
    By cadPass = By.id("cad_senha");
    By btnCadastrar = By.id("BtnCadastrar");
    By txtTituloLogin = By.xpath("//*[@id=\"cadastro\"]/h2");

    By logUser = By.id("log_email");
    By logPass = By.id("log_senha");
    By btnLogin = By.id("BtnLogin");
    By logado = By.xpath("/html/body/div[1]/div/a[1]");

    By btnMenuMeuPerfil = By.xpath("/html/body/div[1]/div/a[4]");
    By alterName = By.id("txtnome");
    By btnCarregar = By.id("BtnCarregar");
    By btnAlterar = By.id("btnAlterar");

    By btnDespesa = By.xpath("//*[@id=\"visaogeral\"]/div[3]/div[2]/div/a[1]");
    By btnReceita = By.xpath("//*[@id=\"visaogeral\"]/div[3]/div[2]/div/a[2]");
    By btnDiferenca = By.xpath("//*[@id=\"visaogeral\"]/div[3]/div[2]/div/a[3]");


    By txtdescricao = By.id("txtdescricao");
    By txtvalordeps = By.id("txtvalor");
    By txttipodespesa = By.id("txttipodespesa");
    By datadesp = By.id("txtDataVencimento");
    By btnAddDespesa = By.id("btnAddDespesa");

    By txttiporeceita = By.id("txttiporeceita");
    By txtvalorreceita = By.id("txtvalorreceita");
    By btnAddReceita = By.id("btnAddReceita");

    By txttipodiferenca = By.id("txttipodiferenca");
    By txtvalor = By.id("txtvalor");
    By txtDataVencimento = By.id("txtDataVencimento");
    By btnAddDiferenca = By.id("btnAddDiferenca");

    By btnMenuLancamentos = By.xpath("/html/body/div[1]/div/a[2]");
    By btnMenuRelatorio = By.xpath("/html/body/div[1]/div/a[3]");

    By todasdesp = By.xpath("//*[@id=\"cadastro\"]/h2");

    By txtCad = By.xpath("//*[@id=\"cadastro\"]/h2");

    By txtlog = By.xpath("//*[@id=\"cadastro\"]/h2");



    //Actions
    public void preencherNome(String usuario){
        sendKeys(cadName, usuario);
    }
    public void preencherEamil(String usuario){
        sendKeys(cadUser, usuario);
    }

    public void preencherSenha(String senha){
        sendKeys(cadPass, senha);
    }
    public void clicarEmCadastro(){
        click(btnCadastrar);
    }
    public String retornaTituloTelaLogin(){
        return getText(txtTituloLogin);
    }
    public String retornaTituloTelaCad(){
        return getText(txtCad);
    }
    public String retornalancamentos(){
        return getText(todasdesp);
    }

    public String retornaTelaLogado(){
        return getText(logado);
    }
    public String retornaTelaLogadoIncorreto(){
        return getText(txtlog);
    }
    public void preencherLogEmail(String usuario){
        sendKeys(logUser, usuario);
    }
    public void preencherLogSenha(String senha){
        sendKeys(logPass, senha);
    }
    public void clicarEmLogin(){
        click(btnLogin);
    }
    public void clicaMenuLancamento(){
        click(btnMenuLancamentos);
    }
    public void clicarEmRelatorio(){
        click(btnMenuRelatorio);
    }
    public void alterarNome(String senha){
        clear(alterName);
        sendKeys(alterName, senha);
    }
    public void cliarCarregar(){
        click(btnCarregar);
    }

    public void cliarAlterar(){
        click(btnAlterar);
    }
    public void cliarMenuMeuPerfil(){
        click(btnMenuMeuPerfil);
    }
    public void cliarDespesa(){
        click(btnDespesa);
    }
    public void cliarReceita(){
        click(btnReceita);
    }
    public void cliarDiferenca(){
        click(btnDiferenca);
    }
    public void preencherDescricao(String descricao){
        sendKeys(txtdescricao, descricao);
    }
    public void preencherValDesp(String valdesps){
        sendKeys(txtvalordeps, valdesps);
    }
    public void preencherTipoDesp(String tipodesps){
        sendKeys(txttipodespesa,tipodesps);
    }
    public void preencherDataDesp(String datadesps){
        sendKeys(datadesp, datadesps);
    }
    public void clicarEmAddCadDesp(){
        click(btnAddDespesa);
    }
    public void preencherTipoReceita(String tipodesps){
        sendKeys(txttiporeceita,tipodesps);
    }
    public void preencherValorReceita(String datadesps){
        sendKeys(txtvalorreceita, datadesps);
    }
    public void clicarEmAddCadReceita(){
        click(btnAddReceita);
    }

    public void preencherTipoDiferenca(String tipodif){
        sendKeys(txttipodiferenca,tipodif);
    }
    public void preencherValorDiferenca(String valorDif){
        sendKeys(txtvalor,valorDif);
    }
    public void preencherDataDiferenca(String dataDif){
        sendKeys(txtDataVencimento,dataDif);
    }
    public void clicarEmAddCadDiferenca(){
        click(btnAddDiferenca);
    }
}

