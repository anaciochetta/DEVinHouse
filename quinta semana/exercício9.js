let currentTime = new Date();

function time() {
  let hour = currentTime.getHours();
  let minute = currentTime.getMinutes();
  let second = currentTime.getSeconds();
  console.log(`A hora atual é ${hour}:${minute}:${second}`);
}

console.log(time());

const timeNow = setInterval(() => console.log(time()), 2000);

console.log(timeNow);
