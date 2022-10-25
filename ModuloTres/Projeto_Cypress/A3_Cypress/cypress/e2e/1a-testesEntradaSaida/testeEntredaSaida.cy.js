context("controleEntradasSaidas", () => {
  it("adicionar2registros", () => {
    cy.visit("https://localhost:44360/ControleEntradasSaidas.aspx");

    //adicionar dois registros na tabela
    cy.get("#txtN1").type("Carro");
    cy.get("#txtV1").type(25000);
    cy.get("#txtN2").type("Casa");
    cy.get("#txtV2").type(300000);
    cy.get("input").contains("Enviar");

    //verificar a tabela com os inputs

    //verifica quantos itens tem na tabela
    cy.get("table tbody tr").should("have.lenght", 3)

    //para verificar o primeiro registro
    //mapeia a tabela
    cy.get("tbody tr")
    //para cada elemento, index e lista
    .each(($el, index, $list) => {
    //procura o primeiro elemento da primeira linha
    //se não for o primeiro vai dar erro pois os valores não são iguais
        if(index == 1)
        cy.get($el).find('#pValor')
        .invoke("text")
        .then(val1 =>{
            expect(val1).to.equal(25000)
        })
    })
  });
});
