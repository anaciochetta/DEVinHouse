context("Teste de Conexão", () => {
  /*  Em Calc Simples o usuário fará inicialmente uma Soma entre 10 e 123 e na sequência uma subtração de 70 em 97. Após isso ele preenche esses dois dados na tela usando os seguintes nomes, respectivamente, Pássaros e Peixes. */
  it("teste1", () => {
    it("calc10+123", () => {
      cy.visit("https://localhost:44360/CalcSimples.aspx");

      cy.get("#txtN1").type(10);
      cy.get("#txtN2").type(123);
      cy.get("input").contains("Calcular").click();

      cy.get("#lbFormulaCalculo")
        .invoke("text")
        .then((valorTexto) => {
          expect(valorTexto).to.be.equal("10 + 123");
        });

      cy.get("#lbResultado")
        .invoke("text")
        .then((valorTexto) => {
          expect(valorTexto).to.be.equal("133");
        });
        
        cy.get("input").contains("Limpar").click();
    });

    it("calc97-70", () => {
      cy.visit("https://localhost:44360/CalcSimples.aspx");

      cy.get("#txtN1").type(97);
      cy.get("#rbFuncao_1").click();
      cy.get("#txtN2").type(70);
      cy.get("input").contains("Calcular").click();
      cy.get("#lbFormulaCalculo")
        .invoke("text")
        .then((valorTexto) => {
          expect(valorTexto).to.be.equal("97 - 70");
        });
      cy.get("#lbResultado")
        .invoke("text")
        .then((valorTexto) => {
          expect(valorTexto).to.be.equal("27");
        });
    });
  });

  it("entrada1", () => {
    cy.visit("https://localhost:44360/ControleEntradasSaidas.aspx");

    cy.get("#txtN1").type("Pássaros");
    cy.get("#txtV1").type(133);
    cy.get("#txtN2").type("Peixes");
    cy.get("#txtV2").type(27);
    cy.get("input").contains("Enviar").click();

    cy.get("#lbVTotal")
      .invoke("text")
      .then(val => {
        expect(val).to.be.equal("Valor Total: 160");
      });

    cy.get("tbody tr").each(($el, index, $list) => {
      if (index > 0) {
        cy.get($el)
          .find("#pValor")
          .invoke("text")
          .then(val => {
            if (index == 1) {
              expect(val).to.be.equal("133");
            }
            if (index == 2) {
              expect(val).to.be.equal("27");
            }
          });
      }
    });
  });
});
