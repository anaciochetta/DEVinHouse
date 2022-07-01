const minhaInstancia = new XMLHttpRequest();

minhaInstancia.onreadystatechange = (props) => console.log(props)
minhaInstancia.onload = (props) => console.log(props) //caso de certo
minhaInstancia.onerror = (props) => console.log(props) //erro
minhaInstancia.open('GET','https://api.github.com/users')
minhaInstancia.send();