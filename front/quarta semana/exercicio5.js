var animals = [
    { animal: 'Cachorro', raca: 'Akita' },
    { animal: 'Cachorro', raca: 'Boxer' },
    { animal: 'Cachorro', raca: 'Dálmata' },
    { animal: 'Cachorro', raca: 'Pastor alemão' },
    { animal: 'Gato', raca: 'Persa' },
    { animal: 'Gato', raca: 'Sphynx' },
    { animal: 'Gato', raca: 'Siamês' },
    ]

animals.forEach(function(animals){
    console.log(animals)
})

const animalsNames = animals.map((animal) => {
    return {... animal} 
})

console.log(animalsNames)
