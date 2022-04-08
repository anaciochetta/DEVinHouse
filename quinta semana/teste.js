const test = 10;

function functionTesteCallback(callback, errorCallback) {
  return new Promise((resolve, reject) => {
    if (test >= 15) {
      reject({
        name: test,
        message: "Qualquer coisa",
      });
    } else {
      resolve({
        name: test,
        message: "Outra coisa",
      });
    }
  });
}

functionTesteCallback()
  .then((result) => {
    console.log(result.name + " " + result.message);
  })
  .catch((error) => {
    console.log(error.name + " " + error.message);
  });

///do raul #tira-duvidas

function meuSle(teste) {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      let respostaCerta = `Tempo de sleep cinco segundos`;
      let respostaErrada = "TEVE ERRO";
      if (teste === "true") {
        resolve(console.log(respostaCerta.toUpperCase()));
      } else {
        reject(console.log(respostaErrada));
      }
    }, 5000);
  });
}
let resposta = "tr";
meuSle(resposta)
  .then((resolve) => {
    resolve;
  })
  .catch((reject) => {
    reject;
  });

/// do pablo tira-duvidas

const meuSleep = new Promise((resolve, reject) => {
  setTimeout(() => {
    let error = false;

    if (!error) {
      resolve(console.log(`Tempo de sleep cinco segundos`));
    } else {
      reject(console.log("TEVE ERRO"));
    }
  }, 5000);
});

// //chamar a promise encadeando o then.

meuSleep
  .then((resposta) => {
    return resposta;
  })
  .then((stringmodificado) => {
    console.log(stringmodificado);
  });
