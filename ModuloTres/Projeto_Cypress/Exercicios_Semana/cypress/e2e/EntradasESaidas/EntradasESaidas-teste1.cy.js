context("teste1-EntradaESaidas", () => {
  before(() => {
    cy.visit("https://localhost:44360/ControleEntradasSaidas.aspx");
  });
  afterEach(() => {
    cy.get("#btnLimpar").click();
  });
  () => {};
  it("entrada1", () => {
    cy.get("#txtN1").type("Boneca");
    cy.get("#txtV1").type(4);
    cy.get("#txtN2").type("Carrinho");
    cy.get("#txtV2").type(1);
    cy.get("#txtN1").type("Doces");
    cy.get("#txtV1").type(5);
    cy.get("#txtN2").type("Refrigerante");
    cy.get("#txtV2").type(6);
    cy.get("input").contains("Enviar");
  });

  it("entrada2", () => {
    cy.get("#txtN1").type("Boneca");
    cy.get("#txtV1").type(78);
    cy.get("#txtN2").type("Bolo");
    cy.get("#txtV2").type(3);
    cy.get("#txtN1").type("Doces");
    cy.get("#txtV1").type(8);
    cy.get("input").contains("Enviar");
  });

  it("entrada3", () => {
    cy.get("#txtN1").type("Café");
    cy.get("#txtV1").type(2);
    cy.get("#txtN2").type("Coxinha");
    cy.get("#txtV2").type(3);
    cy.get("#txtN1").type("Pavê");
    cy.get("#txtV1").type(1);
    cy.get("#txtN2").type("Bolo Seco");
    cy.get("#txtV2").type(1);
    cy.get("#txtN2").type("Gelatina");
    cy.get("#txtV2").type(2);
    cy.get("input").contains("Enviar");
  });
});
