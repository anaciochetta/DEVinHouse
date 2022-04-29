const btn = document.getElementById("btnInverter");
btn.addEventListener("click", inverterCores);

function inverterCores() {
  const classeVermelho = "vermelho";
  const classeAzul = "azul";
  const lista = document.querySelectorAll("li");

  lista.forEach(function (item) {
    item.className === classeAzul
      ? (item.className = classeVermelho)
      : (item.className = classeAzul);
  });
}
