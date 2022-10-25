context("testesCalcSimples", () => {
  it("calc1+2", () => {
    cy.visit("https://localhost:44360/CalcSimples.aspx");
    //input de número
    //.type -> coloca o valor no input
    cy.get("#txtN1").type(1);
    cy.get("#txtN2").type(2);
    //aperta no botão de calcular
    cy.get("input").contains("Calcular").click();
  });

  it("calc234+134", () => { 
    cy.visit("https://localhost:44360/CalcSimples.aspx");
    cy.get("#txtN1").type(234);
    cy.get("#txtN2").type(134);
    cy.get("input").contains("Calcular").click();
  });

  it("calc10000+(-2346)", () => {
    cy.visit("https://localhost:44360/CalcSimples.aspx");
    cy.get("#txtN2").type(10000);
    cy.get("#txtN1").type(-2346);
    cy.get("input").contains("Calcular").click();
  });

  it("calc-45-45", () => {
    cy.visit("https://localhost:44360/CalcSimples.aspx");
    cy.get("#txtN1").type(-45);
    cy.get("#rbFuncao_1").click();
    cy.get("#txtN2").type(45);
    cy.get("input").contains("Calcular").click();
  });

  it("calc100-34", () => {-
    cy.visit("https://localhost:44360/CalcSimples.aspx");
    cy.get("#txtN1").type(100);
    cy.get("#rbFuncao_1").click();
    cy.get("#txtN2").type(34);
    cy.get("input").contains("Calcular").click();
  });

  it('calc-2x6', () => {
    cy.visit("https://localhost:44360/CalcSimples.aspx");
    cy.get("#txtN1").type(-2);
    cy.get("#rbFuncao_2").click();
    cy.get("#txtN2").type(6);
    cy.get("input").contains("Calcular").click();
  });

  it('calc999x78', () => {
    cy.visit("https://localhost:44360/CalcSimples.aspx");
    cy.get("#txtN1").type(999);
    cy.get("#rbFuncao_2").click();
    cy.get("#txtN2").type(78);
    cy.get("input").contains("Calcular").click();
  });

  it('calc36/1', () => {
    cy.visit("https://localhost:44360/CalcSimples.aspx");
    cy.get("#txtN1").type(36);
    cy.get("#rbFuncao_3").click();
    cy.get("#txtN2").type(1);
    cy.get("input").contains("Calcular").click();
  });

  it('calc160/20', () => {
    cy.visit("https://localhost:44360/CalcSimples.aspx");
    cy.get("#txtN1").type(160);
    cy.get("#rbFuncao_3");
    cy.get("#txtN2").type(20);
    cy.get("input").contains("Calcular").click();
  });
});

/* Somar 234 de 134;
Somar -2346 de 10000;
Subtrair 45 de -45;
Subtrair 34 de 100;
Multiplicar -2 por 6;
Multiplicar 999 por 78;
Dividir 36 por 0;
Dividir 160 por 20;
 */
