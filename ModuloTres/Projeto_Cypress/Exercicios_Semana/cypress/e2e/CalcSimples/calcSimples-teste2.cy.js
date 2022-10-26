context("teste2-calcSimples", () => {
  // 2 -> O usuário Subtrairá 70 de -45, na sequência limpará os campos e fará a tabuada do 2 ao 10.
  before(() => {
    cy.visit("https://localhost:44360/CalcSimples.aspx");
  });
  afterEach(() => {
    cy.get("input").contains("Calcular").click();
  });
  it("calc(-45)-70", () => {
    cy.get("#txtN1").type(-45);
    cy.get("#rbFuncao_1").click();
    cy.get("#txtN2").type(70);
  });

  it.only("tabuada2", () => {
    for (let i = 1; i < 11; i++) {
      //não sei o que fazer com isso
      var result = i * 2;
      cy.get("#txtN1").type(2);
      cy.get("#rbFuncao_2").click();
      cy.get("#txtN2").type(i);
      cy.get("input").contains("Calcular").click();
      cy.get("#lbFormulaCalculo")
        .invoke("text")
        .then((valorTexto) => {
          expect(valorTexto).to.be.equal("2 * " + i);
        });
      cy.get("#lbResultado")
        .invoke("text")
        .then((valorTexto) => {
          expect(valorTexto).to.be.equal(result.toString());
        });
      cy.get("input").contains("Limpar").click();
    }
  });
});
