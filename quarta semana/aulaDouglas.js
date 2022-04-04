// array com objetos
const usuarios = [
    {
        nome: 'max',
        sobrenome: 'barros'
    },
    {
        nome: 'ana',
        sobrenome: 'banana'
    }
]

// criar un nickname com o nome e o sobrenome
const novosNomes = usuarios.map((usuario) => {
    const ano = new Date().getFullYear()
    const nickname = `${usuario.nome}_${usuario.sobrenome}_${ano}`
    //return nickname // volta somente os nicknames
    return {... usuario, nickname} //retorna o array usuarios + nickname
})

console.log(novosNomes)
