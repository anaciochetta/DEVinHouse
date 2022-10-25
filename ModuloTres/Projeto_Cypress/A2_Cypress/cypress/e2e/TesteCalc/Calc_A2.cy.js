//site usado para teste -> https://www.calculadora-online.xyz/

//contexto do teste
context("testesCalc", () => {
  //cenário do teste
  it("teste1+2", () => {
    //mapear o teste no site (f12)
    //colocar no console do chrome para verificar se é o botão certo -> document.querySelector('#')
    //# pq é id
    //cy.get('')

    //página sendo usada no teste
    cy.visit("https://www.calculadora-online.xyz/");

    //pega o elemento na tela e clica
    cy.get("#un").click();
    cy.get("#addition").click();
    cy.get("#deux").click();
    cy.get("#egale").click();
    //cy.get("#C").click();
  });
  //it.only só testa esse cenário
  it("teste2+2", () => {
    cy.visit("https://www.calculadora-online.xyz/");

    cy.get("#deux").click();
    cy.get("#addition").click();
    cy.get("#deux").click();
    cy.get("#egale").click();
    //cy.get("#C").click();
  });
  it("teste11+3", () => {
    cy.visit("https://www.calculadora-online.xyz/");

    cy.get("#un").click();
    cy.get("#un").click();
    cy.get("#addition").click();
    cy.get("#trois").click();
    cy.get("#egale").click();
  });
  it("teste6+1", () => {
    cy.visit("https://www.calculadora-online.xyz/");

    cy.get("#six").click();
    cy.get("#addition").click();
    cy.get("#un").click();
    cy.get("#egale").click();
  });
  it("teste7-2", () => {
    cy.visit("https://www.calculadora-online.xyz/");

    cy.get("#sept").click();
    cy.get("#moins").click();
    cy.get("#deux").click();
    cy.get("#egale").click();
  });
  it("teste10-5", () => {
    cy.visit("https://www.calculadora-online.xyz/");

    cy.get("#un").click();
    cy.get("#zero").click();
    cy.get("#moins").click();
    cy.get("#cinq").click();
    cy.get("#egale").click();
  });
  it("teste3x2", () => {
    cy.visit("https://www.calculadora-online.xyz/");

    cy.get("#trois").click();
    cy.get("#multiplier").click();
    cy.get("#deux").click();
    cy.get("#egale").click();
  });
  it("teste8x4", () => {
    cy.visit("https://www.calculadora-online.xyz/");

    cy.get("#huit").click();
    cy.get("#multiplier").click();
    cy.get("#quatre").click();
    cy.get("#egale").click();
  });
  it("teste8x4", () => {
    cy.visit("https://www.calculadora-online.xyz/");

    cy.get("#huit").click();
    cy.get("#multiplier").click();
    cy.get("#quatre").click();
    cy.get("#egale").click();
  });
  it("teste6/2", () => {
    cy.visit("https://www.calculadora-online.xyz/");

    cy.get("#six").click();
    cy.get("#diviser").click();
    cy.get("#deux").click();
    cy.get("#egale").click();
  });
  it("teste20/5", () => {
    cy.visit("https://www.calculadora-online.xyz/");

    cy.get("#deux").click();
    cy.get("#zero").click();
    cy.get("#diviser").click();
    cy.get("#cinq").click();
    cy.get("#egale").click();
  });
}); 