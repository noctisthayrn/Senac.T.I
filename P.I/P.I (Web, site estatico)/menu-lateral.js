//Controle para expandir a barra lateral quando clicar no botão de três barras

var btnExp = document.querySelector('#btn-exp')

var menuSide = document.querySelector('.menu-lateral')

btnExp.addEventListener('click', function(){
    menuSide.classList.toggle('expandir')
})