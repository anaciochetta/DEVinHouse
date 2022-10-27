/* Em Calc Simples o usuário fará inicialmente uma Multiplicação entre 10 e 100, na sequência uma divisão de 90 por 3, uma soma 125 com 25 e uma subtração de 1 para 2. Após isso ele preenche esses dois dados na tela usando os seguintes nomes respectivamente Ração, Petiscos, Coleiras e Remédios. */

context("Teste de Conexão", () => {
  it("teste2", () => {
    cy.visit("https://localhost:44360/CalcSimples.aspx");

    //multiplicação
    cy.get("#txtN1").type(10);
    cy.get("#rbFuncao_2").click();
    cy.get("#txtN2").type(100);
    cy.get("input").contains("Calcular").click();
    cy.get("input").contains("Limpar").click();

    //divisão
    cy.get("#txtN1").type(90);
    cy.get("#rbFuncao_3").click();
    cy.get("#txtN2").type(3);
    cy.get("input").contains("Calcular").click();
    cy.get("input").contains("Limpar").click();

    //soma
    cy.get("#txtN1").type(25);
    cy.get("#txtN2").type(125);
    cy.get("input").contains("Calcular").click();
    cy.get("input").contains("Limpar").click();

    //subtração
    cy.get("#txtN1").type(2);
    cy.get("#rbFuncao_1").click();
    cy.get("#txtN2").type(1);
    cy.get("input").contains("Calcular").click();

    cy.visit("https://localhost:44360/ControleEntradasSaidas.aspx");

    cy.get("#txtN1").type("Ração");
    cy.get("#txtV1").type(1000);
    cy.get("#txtN2").type("Pestiscos");
    cy.get("#txtV2").type(30);
    cy.get("#txtN3").type("Coleira");
    cy.get("#txtV3").type(150);
    cy.get("#txtN4").type("Remédios");
    cy.get("#txtV4").type(1);
    cy.get("input").contains("Enviar").click();

    cy.get("#lbVTotal")
      .invoke("text")
      .then((val) => {
        expect(val).to.be.equal("Valor Total: 1181");
      });

    //valida número
    cy.get("#txtV1")
      .invoke("prop", "value")
      .then((valinput) => {
        expect(valinput).to.be.equal('1000');
        cy.get("tbody tr").each(($el, index, $list) => {
          if (index > 0) {
            cy.get($el)
              .find("#pValor")
              .invoke("text")
              .then((valgrid) => {
                if (index == 1) {
                  expect(valgrid).to.be.equal(valinput);
                }
              });
          }
        });
      });

      //valida nome
      cy.get("#txtN1")
      .invoke("prop", "value")
      .then((valinput) => {
        expect(valinput).to.be.equal('Ração');
        cy.get("tbody tr").each(($el, index, $list) => {
          if (index > 0) {
            cy.get($el)
              .find("#pNome")
              .invoke("text")
              .then((valgrid) => {
                if (index == 1) {
                  expect(valgrid).to.be.equal(valinput);
                }
              });
          }
        });
      });
  });
});
