var Filme = /** @class */ (function () {
    function Filme() {
    }
    return Filme;
}());
var shrek2 = new Filme();
shrek2.nome = "Shrek 2";
shrek2.anoDeLancamento = 2004;
shrek2.diretor = "Andrew Adamson, Kelly Asbury e Conrad Vernon";
var texto = "O filme, " +
    shrek2.nome +
    " lançou em " +
    shrek2.anoDeLancamento +
    ". Os diretores são " +
    shrek2.diretor +
    ". Sendo o melhor filme do Shrek feito.";
console.log(texto);
