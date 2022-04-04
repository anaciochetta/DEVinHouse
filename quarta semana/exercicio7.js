const temperature = [ 0, 32, 45, 50, 75, 80, 99, 120 ];
let celsius = 0

const newTemperature = temperature.map((fahrenheit) => Math.round( ( fahrenheit - 32 ) * 5 / 9 ))

 console.log(`${temperature} para ${newTemperature}`)



