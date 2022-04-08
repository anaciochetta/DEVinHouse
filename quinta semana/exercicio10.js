var promise = new Promise(function(resolve, reject) {
    // fazer algo, possivelmente async, depois…
  
    if (/* tudo deu certo */) {
      resolve("Funcionou!");
    }
    else {
      reject(Error("Deu errado"));
    }
  });

  function sleep () {
    return new Promise ( (res, rej) => { 
       setTimeout( ... )
    })
  }