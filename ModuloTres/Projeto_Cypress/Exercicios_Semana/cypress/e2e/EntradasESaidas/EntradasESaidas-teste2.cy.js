context("teste1-EntradaESaidas", () => {
  before(() => {
    cy.visit("https://localhost:44360/ControleEntradasSaidas.aspx");
  });
  it("entrada1", () => {
    cy.get("#txtN1").type("Caneta");
    cy.get("#txtV1").type(234);
    cy.get("#txtN2").type("Folhas A4");
    cy.get("#txtV2").type(530);
    cy.get("input").contains("Enviar");
  });

  it("entrada2", () => {
    cy.get("#txtN1").type("Lápis");
    cy.get("#txtV1").type(4320);
    cy.get("input").contains("Enviar");
  });

  it("entrada3", () => {
    cy.get("#txtN1").type("Bolsas");
    cy.get("#txtV1").type(135);
    cy.get("#txtN2").type("Cadernos");
    cy.get("#txtV2").type(1200);
    cy.get("#txtN1").type("Livros");
    cy.get("#txtV1").type(1200);
    cy.get("input").contains("Enviar");
  });
});
