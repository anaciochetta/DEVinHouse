context("teste1-EntradaESaidas", () => {
  before(() => {
    cy.visit("https://localhost:44360/ControleEntradasSaidas.aspx");
  });
  afterEach(() => {
    cy.get("#btnLimpar").click();
  });
  it("entrada1", () => {
    cy.get("#txtN1").type("Caneta");
    cy.get("#txtV1").type(234);
    cy.get("#txtN2").type("Folhas A4");
    cy.get("#txtV2").type(530);
    cy.get("input").contains("Enviar").click();

    cy.get("#lbVTotal")
      .invoke("text")
      .then(val => {
        expect(val).to.be.equal("Valor Total: 764");
      });

    cy.get("tbody tr").each(($el, index, $list) => {
      if (index > 0) {
        cy.get($el)
          .find("#pValor")
          .invoke("text")
          .then(val => {
            if (index == 1) {
              expect(val).to.be.equal("234");
            }
            if (index == 2) {
              expect(val).to.be.equal("530");
            }
          });
      }
    });
  });

  it("entrada2", () => {
    cy.get("#txtN1").type("Lápis");
    cy.get("#txtV1").type(4320);
    cy.get("input").contains("Enviar").click();

    cy.get("#lbVTotal")
      .invoke("text")
      .then((val) => {
        expect(val).to.be.equal("Valor Total: 4320");
      });

    cy.get("tbody tr").each(($el, index, $list) => {
      if (index > 0) {
        cy.get($el)
          .find("#pValor")
          .invoke("text")
          .then(val => {
            expect(val).to.be.equal("4320");
          });
      }
    });
  });

  it("entrada3", () => {
    cy.get("#txtN1").type("Bolsas");
    cy.get("#txtV1").type(135);
    cy.get("#txtN2").type("Cadernos");
    cy.get("#txtV2").type(1200);
    cy.get("#txtN3").type("Livros");
    cy.get("#txtV3").type(1200);
    cy.get("input").contains("Enviar").click();

    cy.get("#lbVTotal")
      .invoke("text")
      .then(val => {
        expect(val).to.be.equal("Valor Total: 2535");
      });

    cy.get("tbody tr").each(($el, index, $list) => {
      if (index > 0) {
        cy.get($el)
          .find("#pValor")
          .invoke("text")
          .then(val => {
            if (index == 1) {
              expect(val).to.be.equal("135");
            }
            if (index == 2) {
              expect(val).to.be.equal("1200");
            }
            if (index == 3) {
              expect(val).to.be.equal("1200");
            }
          });
      }
    });
  });
});
