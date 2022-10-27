context("teste1-EntradaESaidas", () => {
  before(() => {
    cy.visit("https://localhost:44360/ControleEntradasSaidas.aspx");
  });
  afterEach(() => {
    cy.get("#btnLimpar").click();
  });

  it("entrada1", () => {
    cy.get("#txtN1").type("Boneca");
    cy.get("#txtV1").type(4);
    cy.get("#txtN2").type("Carrinho");
    cy.get("#txtV2").type(1);
    cy.get("#txtN3").type("Doces");
    cy.get("#txtV3").type(5);
    cy.get("#txtN4").type("Refrigerante");
    cy.get("#txtV4").type(6);
    cy.get("input").contains("Enviar").click();

    //verifica valor total
    cy.get("#lbVTotal")
      .invoke("text")
      .then((val) => {
        expect(val).to.be.equal("Valor Total: 16");
      });

    //verifica cada um dos campos valor grid
    cy.get("tbody tr").each(($el, index, $list) => {
      if (index > 0) {
        cy.get($el)
          .find("#pValor")
          .invoke("text")
          .then((val) => {
            if (index == 1) {
              expect(val).to.be.equal("4");
            }
            if (index == 2) {
              expect(val).to.be.equal("1");
            }
            if (index == 3) {
              expect(val).to.be.equal("5");
            }
            if (index == 4) {
              expect(val).to.be.equal("6");
            }
          });
      }
    });
  });

  it("entrada2", () => {
    cy.get("#txtN1").type("Boneca");
    cy.get("#txtV1").type(78);
    cy.get("#txtN2").type("Bolo");
    cy.get("#txtV2").type(3);
    cy.get("#txtN3").type("Doces");
    cy.get("#txtV3").type(8);
    cy.get("input").contains("Enviar").click();

    cy.get("#lbVTotal")
      .invoke("text")
      .then((val) => {
        expect(val).to.be.equal("Valor Total: 89");
      });

    cy.get("tbody tr").each(($el, index, $list) => {
      if (index > 0) {
        cy.get($el)
          .find("#pValor")
          .invoke("text")
          .then((val) => {
            if (index == 1) {
              expect(val).to.be.equal("78");
            }
            if (index == 2) {
              expect(val).to.be.equal("3");
            }
            if (index == 3) {
              expect(val).to.be.equal("8");
            }
          });
      }
    });
  });
  it("entrada3", () => {
    cy.get("#txtN1").type("Café");
    cy.get("#txtV1").type(2);
    cy.get("#txtN2").type("Coxinha");
    cy.get("#txtV2").type(3);
    cy.get("#txtN3").type("Pavê");
    cy.get("#txtV3").type(1);
    cy.get("#txtN4").type("Bolo Seco");
    cy.get("#txtV4").type(1);
    cy.get("#txtN5").type("Gelatina");
    cy.get("#txtV5").type(2);
    cy.get("input").contains("Enviar").click();

    cy.get("#lbVTotal")
      .invoke("text")
      .then((val) => {
        expect(val).to.be.equal("Valor Total: 9");
      });
    cy.get("tbody tr").each(($el, index, $list) => {
      if (index > 0) {
        cy.get($el)
          .find("#pValor")
          .invoke("text")
          .then((val) => {
            if (index == 1) {
              expect(val).to.be.equal("2");
            }
            if (index == 2) {
              expect(val).to.be.equal("3");
            }
            if (index == 3) {
              expect(val).to.be.equal("1");
            }
            if (index == 4) {
              expect(val).to.be.equal("1");
            }
            if (index == 5) {
              expect(val).to.be.equal("2");
            }
          });
      }
    });
  });
});
