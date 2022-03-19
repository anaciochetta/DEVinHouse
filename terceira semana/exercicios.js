let txtnome;
txtnome = prompt("Qual o seu nome?");
document.getElementById("resposta").innerHTML = txtnome;


function mostrar(){
    let nome = document.getElementById("nome").value;
    let sobrenome = document.getElementById("sobrenome").value;
    let idade = document.getElementById("idade").value;
    let rsim = document.getElementById("rsim").checked;
    let rnao = document.getElementById("rnao").checked;
    
    if (rsim == true){

    dados = "Seja bem vindo " + nome + " " + sobrenome + "! Sua idade é " + idade +
    " e você pratica esportes.";
    document.getElementById("dados").innerHTML = dados;
    
} 
if (rnao == true){
    dados = "Seja bem vindo " + nome + " " + sobrenome + "! Sua idade é " + idade +
" e você não pratica esportes." 
document.getElementById("dados").innerHTML = dados

}

}


sobrenoMe =  prompt("Qual o seu sobrenome?");
noMe =  prompt("Qual o seu nome?");
alert(noMe + " " + sobrenoMe)

let stringSobrenome = sobrenoMe.String()
let maisculo = stringSobrenome.toUperCase()
let tamanho = stringSobrenome.lenght

alert("Olá, " + maisculo +". Seu sobrenome contém " + tamanho + " letras.")

