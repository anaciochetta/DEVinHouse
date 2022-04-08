function sleep(test) {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      if (test === true) {
        resolve({
          number: test,
          message: "Deu certo!",
        });
      } else {
        reject({
          number: test,
          message: "Deu ruim!",
        });
      }
    }, 3000);
  });
}

let resposta = "oi";
sleep(resposta)
  .then((resolve) => {
    console.log(resolve.number + " " + resolve.message);
  })
  .catch((reject) => {
    console.log(reject.number + "  " + reject.message);
  });
