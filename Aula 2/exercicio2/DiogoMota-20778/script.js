var arrayNumbers=[];

function adicionarNumero() {
    if(document.getElementById("newNumbers") && document.getElementById("newNumbers").value){
    var number = document.getElementById("newNumbers").value;
     document.getElementById("newNumbers").value = null;
    arrayNumbers.push(parseInt(number));
    console.log(arrayNumbers);}else {alert("Nenhum numero")}}

function calcular() {
    if(arrayNumbers.length>=5){
    alert(Math.max.apply(Math, arrayNumbers));
    } else {
    alert("Nao foram adicionados 5 numeros!")}
}