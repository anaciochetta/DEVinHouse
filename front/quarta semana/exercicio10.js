const contasClientes = [
    {
      id: 1,
      saldo: 500,
    },
    {
      id: 2,
      saldo: 30000,
    },
    {
      id: 3,
      saldo: 50,
    },
  ];

const checkId = (id) => contasClientes.find((contaID) => contaID.id === id) //função para conferir o id da conta

function checkOperacao (conta, valor){
    if (valor <= 0){
        console.log(`Valor inválido.`)
        return false
    }
    if (checkId(!conta)){
        console.log(`Conta inválida.`);
    return;
    }
    return true
}

function atualizaSaldo (id, saldo) {
    contasClientes.map((conta) => (conta.id === id ? { ...conta, saldo } : conta));
    console.log(`Seu saldo atual é: ${saldo}`);}


function depositar (id, valor){
    const conta = checkId(id)
    if(checkOperacao(conta, valor) == true)
    {
        const saldoConta = conta.saldo
        let saldoAtual = saldoConta + valor
        console.log(`Deposito ocorreu com sucesso!`)
        atualizaSaldo(conta, saldoAtual)
    }
    else console.log(`Operação inválida!`)
}

function sacar (id, valor){
    const conta = checkId(id)
    if(checkOperacao(conta, valor) == true)
    {
        const saldoConta = conta.saldo
        if(saldoConta < valor)
        {
            console.log(`Saldo insuficiente, seu saldo atual é: ${saldoConta}`)
        }
        else{
            let saldoAtual = saldoConta - valor
            console.log(`Saque ocorreu com sucesso!`)
            atualizaSaldo(conta, saldoAtual)
            
        }
    }
    else console.log(`Operação inválida!`)
}

sacar(1, 50)
depositar (3, 1)
sacar(2, 300000)
depositar(3, 12)