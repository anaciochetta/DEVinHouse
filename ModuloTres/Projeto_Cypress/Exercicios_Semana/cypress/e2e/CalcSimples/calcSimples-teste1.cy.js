context("teste1-calcSimples", () => {
  // 1 -> O usuário fará inicialmente uma Soma entre 10 e 123, após isso ele limpará os campos e fara o mesmo fluxo para uma Subtração de 35 em 25, multiplicação de 5 por 55 e divisão de 20 por 2.

  before(() => {
    cy.visit("https://localhost:44360/CalcSimples.aspx");
  });
  afterEach(() => {
    cy.get("input").contains("Limpar").click();
  });

  it("calc10+123", () => {
    cy.get("#txtN1").type(10);
    cy.get("#txtN2").type(123);
    cy.get("input").contains("Calcular").click();
    //verifica a formula
    cy.get("#lbFormulaCalculo")
      .invoke("text")
      .then(valorTexto => {
        expect(valorTexto).to.be.equal("10 + 123");
      });
    //verifica o resultado
    cy.get("#lbResultado")
      .invoke("text")
      .then(valorTexto => {
        expect(valorTexto).to.be.equal("133");
      });
  });

  it("calc25-35", () => {
    cy.get("#txtN1").type(25);
    cy.get("#rbFuncao_1").click();
    cy.get("#txtN2").type(35);
    cy.get("input").contains("Calcular").click();
    cy.get("#lbFormulaCalculo")
      .invoke("text")
      .then(valorTexto => {
        expect(valorTexto).to.be.equal("25 - 35");
      });
      cy.get("#lbResultado")
      .invoke("text")
      .then(valorTexto => {
        expect(valorTexto).to.be.equal("-10");
      });
  });

  it("calc5x55", () => {
    cy.get("#txtN1").type(5);
    cy.get("#rbFuncao_2").click();
    cy.get("#txtN2").type(55);
    cy.get("input").contains("Calcular").click();
    cy.get("#lbFormulaCalculo")
      .invoke("text")
      .then(valorTexto => {
        expect(valorTexto).to.be.equal("5 * 55");
      });
      cy.get("#lbResultado")
      .invoke("text")
      .then(valorTexto => {
        expect(valorTexto).to.be.equal("275");
      });
  });

  it("calc20/2", () => {
    cy.get("#txtN1").type(20);
    cy.get("#rbFuncao_3").click();
    cy.get("#txtN2").type(2);
    cy.get("input").contains("Calcular").click();
    cy.get("#lbFormulaCalculo")
      .invoke("text")
      .then(valorTexto => {
        expect(valorTexto).to.be.equal("20 / 2");
      });
    cy.get("#lbResultado")
      .invoke("text")
      .then((valorTexto) => {
        expect(valorTexto).to.be.equal("10");
      });
  });
});
